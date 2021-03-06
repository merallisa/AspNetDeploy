﻿using System;
using System.Globalization;
using System.IO;
using System.Net;
using AspNetDeploy.Contracts;
using AspNetDeploy.Model;
using SharpSvn;

namespace AspNetDeploy.SourceControls.SVN
{
    public class SvnSourceControlRepository : ISourceControlRepository
    {
        public LoadSourcesResult LoadSources(SourceControlVersion sourceControlVersion, string path)
        {
            NetworkCredential credentials = new NetworkCredential(
                        sourceControlVersion.SourceControl.GetStringProperty("Login"),
                        sourceControlVersion.SourceControl.GetStringProperty("Password"));

            using (SvnClient client = new SvnClient())
            {
                client.Authentication.DefaultCredentials = credentials;

                if (!Directory.Exists(path))
                {
                    return this.LoadSourcesFromScratch(sourceControlVersion, path, client);
                }
                
                return this.LoadSourcesWithUpdate(path, client);
            }
        }

        private LoadSourcesResult LoadSourcesWithUpdate(string path, SvnClient client)
        {
            SvnUpdateResult result;

            try
            {
                client.Update(path, out result);
            }
            catch (SvnWorkingCopyException e)
            {
                client.CleanUp(path);
                client.Update(path, out result);
            }

            SvnInfoEventArgs info;
            client.GetInfo(path, out info);

            return new LoadSourcesResult
            {
                RevisionId = info.LastChangeRevision.ToString(CultureInfo.InvariantCulture)
            };
        }

        private LoadSourcesResult LoadSourcesFromScratch(SourceControlVersion sourceControlVersion, string path, SvnClient client)
        {
            SvnUpdateResult result;
            Directory.CreateDirectory(path);

            string uriString = sourceControlVersion.SourceControl.GetStringProperty("URL") + "/" + sourceControlVersion.GetStringProperty("URL");

            client.CheckOut(new Uri(uriString), path, out result);

            SvnInfoEventArgs info;
            client.GetInfo(path, out info);

            return new LoadSourcesResult
            {
                RevisionId = info.LastChangeRevision.ToString(CultureInfo.InvariantCulture)
            };
        }
    }
}

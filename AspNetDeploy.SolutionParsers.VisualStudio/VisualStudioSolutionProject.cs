﻿using System;
using System.Collections.Generic;
using System.Globalization;
using AspNetDeploy.Contracts;
using AspNetDeploy.Model;

namespace AspNetDeploy.SolutionParsers.VisualStudio
{
    public class VisualStudioSolutionProject : ISolutionProject
    {
        public string Name { get; set; }
        public string ProjectFile { get; set; }
        public Guid Guid { get; set; }
        public Guid TypeGuid { get; set; }
        public ProjectType Type { get; set; }
        public string TargetFrameworkVersion { get; set; }
        public string OutputPath { get; set; }
        public int MvcVersion { get; set; }

        public IList<string> ContentFiles { get; set; }
        public IList<string> ReferenceLibraries { get; set; }

        public virtual IList<KeyValuePair<string, string>> GetProperties()
        {
            return new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("TypeGuid", this.TypeGuid.ToString()),
                new KeyValuePair<string, string>("TargetFrameworkVersion", this.TargetFrameworkVersion),
                new KeyValuePair<string, string>("OutputPath", this.OutputPath),
                new KeyValuePair<string, string>("MvcVersion", this.MvcVersion.ToString(CultureInfo.InvariantCulture))
            };
        }

        public VisualStudioSolutionProject()
        {
            this.ContentFiles = new List<string>();
            this.ReferenceLibraries = new List<string>();
        }
    }
}
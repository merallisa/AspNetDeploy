﻿using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using SatelliteService;
using SatelliteService.Bootstrapper;

namespace SatelliteHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectFactoryConfigurator.Configure();

            Uri httpUrl = new Uri("http://localhost:8090/AspNetDeploySatellite/DeploymentService");

            ServiceHost host = new ServiceHost(typeof(DeploymentService), httpUrl);
           
            WSHttpBinding wsHttpBinding = new WSHttpBinding(SecurityMode.Message);
            wsHttpBinding.MaxBufferPoolSize = 1024 * 1024 * 10;
            wsHttpBinding.MaxReceivedMessageSize = 1024 * 1024 * 10;
            wsHttpBinding.ReaderQuotas.MaxArrayLength = 1024 * 1024 * 10;

            host.AddServiceEndpoint(typeof(IDeploymentService), wsHttpBinding, "");

            ServiceMetadataBehavior serviceMetadataBehavior = new ServiceMetadataBehavior();
            //serviceMetadataBehavior.HttpGetEnabled = true;
            host.Description.Behaviors.Add(serviceMetadataBehavior);
            //Start the Service
            host.Open();

            Console.WriteLine("Running");
            Console.ReadKey();
        }
    }
}
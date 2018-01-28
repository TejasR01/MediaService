using System;
using System.Configuration;
using System.IO;
using Microsoft.WindowsAzure.MediaServices.Client;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //    // Read values from the App.config file.

    //    private static readonly string _AADTenantDomain =
    //        ConfigurationManager.AppSettings["AMSAADTenantDomain"];
    //    private static readonly string _RESTAPIEndpoint =
    //        ConfigurationManager.AppSettings["AMSRESTAPIEndpoint"];
    //    private static readonly string _AMSClientId =
    //        ConfigurationManager.AppSettings["AMSClientId"];
    //    private static readonly string _AMSClientSecret =
    //        ConfigurationManager.AppSettings["AMSClientSecret"];

    //    private static CloudMediaContext _context = null;
    //    static void Main(string[] args)
    //    {
    //        AzureAdTokenCredentials tokenCredentials =
    //            new AzureAdTokenCredentials(_AADTenantDomain,
    //                new AzureAdClientSymmetricKey(_AMSClientId, _AMSClientSecret),
    //                AzureEnvironments.AzureCloudEnvironment);

    //        var tokenProvider = new AzureAdTokenProvider(tokenCredentials);

    //        _context = new CloudMediaContext(new Uri(_RESTAPIEndpoint), tokenProvider);

    //        // List all available Media Processors
    //        foreach (var mp in _context.MediaProcessors)
    //        {
    //            Console.WriteLine(mp.Name);
    //        }

    //        Console.ReadLine();
    //    }
    //}
}

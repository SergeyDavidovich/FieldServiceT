using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Syncfusion.Blazor;


namespace FieldServiceT
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Register Syncfusion license 
            Syncfusion.Licensing.SyncfusionLicenseProvider
                .RegisterLicense("MzMyMzY5QDMxMzgyZTMzMmUzMFhXa3BYRWZjOUI2YVBVSXl1bzlvQ28vQVloZm4wODEweDdMMUlORHAvczA9");

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

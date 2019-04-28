using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

namespace FitUpdate
{
    public class Program
    {
        public static List<Uri> _consulUri = new List<Uri>();
        
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Run();
        }

        public static IWebHost CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration(cb => 
            {
                _consulUri.Add(new Uri("http://localhost:8500"));
                var configuration = cb.Build();
                //cb.AddConsul(new[] { configuration.GetValue<Uri>("CONSUL_URL") }, configuration.GetValue<string>("CONSUL_PATH"));
                cb.AddConsul(_consulUri, "key1");
            })
            .UseStartup<Startup>()
            .Build();
    }
}

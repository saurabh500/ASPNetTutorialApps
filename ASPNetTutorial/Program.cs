using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace aspnetcoreapp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .AddCommandLine(args)
                .Build();


            var host = new WebHostBuilder()
                .UseConfiguration(config)
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();
            
            host.Run();
        }
    }
}

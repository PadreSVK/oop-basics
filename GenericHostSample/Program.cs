using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace GenericHostSample
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await CreateHostBuilder(args)
                .Build()
                .RunAsync();
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
          Host.CreateDefaultBuilder(args)
              .ConfigureServices((hostContext, services) =>
              {
                  var configurationSection = hostContext.Configuration.GetSection("TestVariable").Value;
                  services.AddHostedService<SimpleHostedService>();
              })
            .ConfigureLogging((hostContext, configLogging) =>
            {
                configLogging.AddConsole();
            });
    }
}

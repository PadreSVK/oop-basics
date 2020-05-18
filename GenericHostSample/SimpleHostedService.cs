using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GenericHostSample
{
    public class SimpleHostedService : IHostedService
    {
        private ILogger<SimpleHostedService> logger;

        public SimpleHostedService(ILogger<SimpleHostedService> logger)
        {
            this.logger = logger;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            logger.LogInformation("Custom hosted service started");
            while (true)
            {
                await Task.Delay(1000);
                logger.LogInformation("while invoke");
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            logger.LogInformation("Custom hosted service stopped");
            return Task.CompletedTask;
        }
    }
}

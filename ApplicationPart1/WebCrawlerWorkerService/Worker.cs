using Abot2;
using Abot2.Poco;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebCrawlerWorkerService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
               
                WebCrowlerAbotX webCrowlerAbotX = new WebCrowlerAbotX();
                var siteToCrawl = new Uri("https://www.edmunds.com/");

                //Uncomment to demo major features
                //DemoCrawlerX_PauseResumeStop();
               //webCrowlerAbotX.DemoCrawlerXJavascriptRendering();
               webCrowlerAbotX.DemoParallelCrawlerEngine();
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
             
                

                await Task.Delay(60 * 1000, stoppingToken);
            }
        }
    }
}

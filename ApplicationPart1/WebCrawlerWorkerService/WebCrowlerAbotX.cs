using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Abot2;
using Abot2.Crawler;
using Abot2.Poco;
using AbotX2.Crawler;
using AbotX2.Parallel;
using AbotX2.Poco;
using Serilog;
using FileWorxObjects;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text.RegularExpressions;
using System.Threading;

namespace WebCrawlerWorkerService
{
    class WebCrowlerAbotX
    {

        private  string BaseUrl = "https://localhost:44391/";
        private HttpClient client;
        public  void DemoCrawlerXPauseResumeStop()
        {
            var crawler = new CrawlerX(GetSafeConfig());

            crawler.PageCrawlCompleted += (sender, args) =>
            {
                //You will be interested in args.CrawledPage & args.CrawlContext
                crawler.CrawlContext.CrawlBag = args.CrawledPage.ParsedLinks;
            };

            var crawlerTask = crawler.CrawlAsync(new Uri("http://blahblahblah.com"));

            System.Threading.Thread.Sleep(3000);
            crawler.Pause();
            System.Threading.Thread.Sleep(10000);
            crawler.Resume();

            var result = crawlerTask.Result;
            var Links = result.CrawlContext.CrawlBag;

        }

        public  void DownloadContentLinks(IEnumerable<HyperLink> Links)
        {

         
              var pathToPhantomJSExeFolder = @".\Packages\PhantomJS.2.1.1\tools\phantomjs";
               var config = new CrawlConfigurationX
               {
                   IsJavascriptRenderingEnabled = false,
                   JavascriptRendererPath = pathToPhantomJSExeFolder,
                   IsSendingCookiesEnabled = true,
                   MaxConcurrentThreads = 1,
                   MaxPagesToCrawl = 1,
                   JavascriptRenderingWaitTimeInMilliseconds = 3000,
                   CrawlTimeoutSeconds = 20
               };
               foreach (var link in Links)
               {

                   var crawler = new CrawlerX(config);
                   crawler.PageCrawlCompleted += (sender, args) =>
                   {
                       //args.CrawledPage.Content.Text has an image
                       crawler.CrawlContext.CrawlBag = args.CrawledPage.Content.Text;
                   };

                   var crawlerTask = crawler.CrawlAsync(new Uri(link.HrefValue.AbsoluteUri));
                   var result = crawlerTask.Result.CrawlContext.CrawlBag;
                   var title = Regex.Match(result, @"\<title\b[^>]*\>\s*(?<Title>[\s\S]*?)\</title\>",
                       RegexOptions.IgnoreCase).Groups["Title"].Value;
                   string filename = "C:\\Users\\Hussam.Ibraheem\\Desktop\\HTMLPage\\News" + Guid.NewGuid().ToString()+".html";

                   client = new HttpClient();
                   client.BaseAddress = new Uri(BaseUrl);
                   client.DefaultRequestHeaders.Accept.Clear();
                   client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                   client.Timeout = TimeSpan.FromMinutes(5);
                   HttpResponseMessage response = client.PostAsJsonAsync("api/Html/GETHTML", link.HrefValue.AbsoluteUri).Result;
                   HtmlFile htmlFile = new HtmlFile();

                   if (response.IsSuccessStatusCode)
                   {
                       var body = response.Content.ReadAsStringAsync().Result;
                       htmlFile = JsonConvert.DeserializeObject<HtmlFile>(body);
                       filename = htmlFile.NameFile;
                   }
                   else
                   {
                       if (client.BaseAddress == null)
                       {
                           client.BaseAddress = new Uri(BaseUrl);
                       }
                       htmlFile.NameFileUser = title;
                       htmlFile.NameFile = filename;
                       htmlFile.LinkPage = link.HrefValue.AbsoluteUri;
                       htmlFile.ClassIDFileOrUser = 5;
                       htmlFile.CreationDateFileUser = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");

                       HttpResponseMessage responsecreate = client.PostAsJsonAsync("api/Html",htmlFile ).Result;

                   }


                   FileStream fs1 = new FileStream(filename , FileMode.OpenOrCreate, FileAccess.Write);
                   StreamWriter writer = new StreamWriter(fs1);
                   writer.Write(result);
                   writer.Close();
               }
        }

    
        //Can Use CrawlerX
        public  void DemoCrawlerXJavascriptRendering()
        {

            var pathToPhantomJSExeFolder = @".\Packages\PhantomJS.2.1.1\tools\phantomjs";
            var config = new CrawlConfigurationX
            {
                IsJavascriptRenderingEnabled = false,
                JavascriptRendererPath = pathToPhantomJSExeFolder,
                IsSendingCookiesEnabled = true,
                MaxConcurrentThreads = 1,
                MaxPagesToCrawl = 1,
                JavascriptRenderingWaitTimeInMilliseconds = 3000,
                CrawlTimeoutSeconds = 20
            };
            var crawler = new CrawlerX(config);

            crawler.PageCrawlCompleted += (sender, args) =>
            {
               
                crawler.CrawlContext.CrawlBag = args.CrawledPage.ParsedLinks;
            };

            var crawlerTask = crawler.CrawlAsync(new Uri("http://www.millwoodinn.com/"));
            var result = crawlerTask.Result.CrawlContext.CrawlBag;
            DownloadContentLinks((IEnumerable<HyperLink>)result);


        }
     

        public static async Task DemoCrawlerXAutoTuning(Uri siteToCrawl)
        {
            var config = GetSafeConfig();
            config.AutoTuning = new AutoTuningConfig
            {
                IsEnabled = true,
                CpuThresholdHigh = 85,
                CpuThresholdMed = 65,
                MinAdjustmentWaitTimeInSecs = 10
            };
            //Optional, configure how aggressively to speed up or down during throttling
            config.Accelerator = new AcceleratorConfig();
            config.Decelerator = new DeceleratorConfig();

            //Now the crawl is able to "AutoTune" itself if the host machine
            //is showing signs of stress.
            using (var crawler = new CrawlerX(config))
            {
                crawler.PageCrawlCompleted += (sender, args) =>
                {
                    //Check out args.CrawledPage for any info you need
                };
                await crawler.CrawlAsync(siteToCrawl);
            }
        }

        public static async Task DemoCrawlerXThrottling(Uri siteToCrawl)
        {
            var config = GetSafeConfig();
            config.AutoThrottling = new AutoThrottlingConfig
            {
                IsEnabled = true,
                ThresholdHigh = 2,
                ThresholdMed = 2,
                MinAdjustmentWaitTimeInSecs = 10
            };
            //Optional, configure how aggressively to speed up or down during throttling
            config.Accelerator = new AcceleratorConfig();
            config.Decelerator = new DeceleratorConfig();

            //Now the crawl is able to "Throttle" itself if the site being crawled
            //is showing signs of stress.
            using (var crawler = new CrawlerX(config))
            {
                crawler.PageCrawlCompleted += (sender, args) =>
                {
                    //Check out args.CrawledPage for any info you need
                };
                await crawler.CrawlAsync(siteToCrawl);
            }
        }
        //Can Use ParallelCrawlerEngine
        public void DemoParallelCrawlerEngine()
         {
             var siteToCrawlProvider = new SiteToCrawlProvider();
             siteToCrawlProvider.AddSitesToCrawl(new List<SiteToCrawl>
             {
                 new SiteToCrawl{ Uri = new Uri("http://www.millwoodinn.com/") },
                 //new SiteToCrawl{ Uri = new Uri("https://www.alraimedia.com/") }
                 
             });

            var pathToPhantomJSExeFolder = @".\Packages\PhantomJS.2.1.1\tools\phantomjs";
            var config = new CrawlConfigurationX
            {
                IsJavascriptRenderingEnabled = false,
                JavascriptRendererPath = pathToPhantomJSExeFolder,
                IsSendingCookiesEnabled = true,
                MaxConcurrentThreads = 1,
                MaxPagesToCrawl = 1,
                JavascriptRenderingWaitTimeInMilliseconds = 3000,
                CrawlTimeoutSeconds = 20
            };
          

             var crawlEngine = new ParallelCrawlerEngine(
                 config,
                 new ParallelImplementationOverride(config,
                     new ParallelImplementationContainer()
                     {
                         SiteToCrawlProvider = siteToCrawlProvider,
                         WebCrawlerFactory = new WebCrawlerFactory(config)//Same config will be used for every crawler
                     })
                 );

            crawlEngine.AllCrawlsCompleted += (sender, eventArgs) =>
            {
                Console.WriteLine("Completed crawling all sites");
            };
            crawlEngine.SiteCrawlCompleted += (sender, eventArgs) =>
            {
                Console.WriteLine("Completed crawling site {0}", eventArgs.CrawledSite.SiteToCrawl.Uri);
            };
            crawlEngine.CrawlerInstanceCreated += (sender, eventArgs) =>
            {
                //Register for crawler level events. These are Abot's events!!!
                eventArgs.Crawler.PageCrawlCompleted += (abotSender, abotEventArgs) =>
                {
                    var Links = (IEnumerable<HyperLink>)abotEventArgs.CrawledPage.ParsedLinks;
                  //  DownloadContentLinks(Links);
                   
                        foreach (var link in Links)
                        {
                            Console.WriteLine(link.HrefValue.AbsoluteUri);
                        }
                    
                };
              
            };

           crawlEngine.StartAsync();
            
            Console.Read();
           
        }

        private static CrawlConfigurationX GetSafeConfig()
        {
            /*The following settings will help not get your ip banned
             by the sites you are trying to crawl. The idea is to crawl
             only 5 pages and wait 2 seconds between http requests
             */
            return new CrawlConfigurationX
            {
                MaxPagesToCrawl = 10,
                MinCrawlDelayPerDomainMilliSeconds = 2000
            };
        }

    }
}

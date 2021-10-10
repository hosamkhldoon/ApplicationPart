using FileWorxObjects;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;
using DTO;

namespace WorkerServiceContact
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        
        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            
            return base.StartAsync(cancellationToken);
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {

                _logger.LogInformation("Number Of News Added To DataBase : {count}", ReadDataFileAndDownload());
                await Task.Delay(60 * 1000, stoppingToken);
            }
        }
        private int ReadDataFileAndDownload()
        {
            string BaseUrl = "https://localhost:44391/";
            HttpClient client;
            int CountNews = 0;
            ContactQueryService contactQuery = new ContactQueryService();
            contactQuery.QType = "Reception";
            client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = TimeSpan.FromMinutes(5);
            HttpResponseMessage response = client.PutAsJsonAsync("api/Contact", contactQuery).Result;


            if (response.IsSuccessStatusCode)
            {
                var body = response.Content.ReadAsStringAsync().Result;
                List<Contact> ContactData = JsonConvert.DeserializeObject<List<Contact>>(body);
                foreach (var item in ContactData)
                {
                    
                     

                        WebRequest request = WebRequest.Create(item.Address);

                        request.Method = WebRequestMethods.Ftp.ListDirectory;
                        string password = Eramake.eCryptography.Decrypt(item.Password);
                        request.Credentials = new NetworkCredential(item.UserName, password);
                        using (var responseFtp = (FtpWebResponse)request.GetResponse())

                        {

                            StreamReader streamReader = new StreamReader(responseFtp.GetResponseStream());

                            List<string> directories = new List<string>();

                            string line = streamReader.ReadLine();

                            while (!string.IsNullOrEmpty(line))

                            {

                                directories.Add(line);

                                line = streamReader.ReadLine();

                            }


                            streamReader.Close();
                          
                                
                             for (int i = 0; i <= directories.Count - 1; i++)
                             {
                                 if (directories[i].Contains("."))
                                 {

                                        string path = @item.Address+"/" + @directories[i].ToString();
                                        FtpWebRequest requestfile = (FtpWebRequest)WebRequest.Create(path);
                                        requestfile.Method = WebRequestMethods.Ftp.DownloadFile;                                      
                                        requestfile.Credentials = new NetworkCredential(item.UserName, password);
                                        FtpWebResponse responsefile = (FtpWebResponse)requestfile.GetResponse();
                                    
                                        Stream responseStream = responsefile.GetResponseStream();
                                        StreamReader reader = new StreamReader(responseStream);

                                        FtpWebRequest requestdate = (FtpWebRequest)WebRequest.Create(path);
                                        requestdate.Method = WebRequestMethods.Ftp.GetDateTimestamp;
                                        requestdate.Credentials = new NetworkCredential(item.UserName, password);
                                        responsefile = (FtpWebResponse)requestdate.GetResponse();
                                       ContactReadService contact = new ContactReadService();
                                        HttpResponseMessage responsecontactdate = client.GetAsync("api/Contact/" + item.IDBusiness).Result;
                                    

                                        if (responsecontactdate.IsSuccessStatusCode)
                                        {
                                           body = responsecontactdate.Content.ReadAsStringAsync().Result;
                                           contact = JsonConvert.DeserializeObject<ContactReadService>(body);
                                        }
                                      
                                        TimeSpan DifferenceTime = responsefile.LastModified - contact.LastFileDate;
                                        if (Math.Floor(DifferenceTime.TotalSeconds) > 0)
                                        {  
                                            NewsUpdateService newsobject = new NewsUpdateService();
                                            PhotoUpdateService photoobject = new PhotoUpdateService();

                                            string[] File = Strings.Split(reader.ReadToEnd(), "$%$");
                                            if (File[4] == "News")
                                            {

                                                newsobject.NameFileUser = File[0];
                                                newsobject.DescriptionNewsPhoto = File[1];
                                                newsobject.CategoryNews = File[2];
                                                newsobject.BodyNewsPhoto = File[3];
                                              
                                                newsobject.CreationDateFileUser = responsefile.LastModified.ToString("MM/dd/yyyy hh:mm:ss tt");
                                                if (client.BaseAddress == null)
                                                {
                                                    client.BaseAddress = new Uri(BaseUrl);
                                                }
                                                HttpResponseMessage responsenews = client.PostAsJsonAsync("api/News", newsobject).Result;



                                                if (responsenews.IsSuccessStatusCode)
                                                {
                                                    CountNews++;

                                                }
                                            }
                                            else
                                            {
                                                photoobject.NameFileUser = File[0];
                                                photoobject.DescriptionNewsPhoto = File[1];
                                                photoobject.LocationPhoto = File[2];
                                                photoobject.BodyNewsPhoto = File[3];
                                           
                                                if (client.BaseAddress == null)
                                                {
                                                    client.BaseAddress = new Uri(BaseUrl);
                                                }
                                                photoobject.CreationDateFileUser = responsefile.LastModified.ToString("MM/dd/yyyy hh:mm:ss tt");
                                                HttpResponseMessage responsephoto = client.PostAsJsonAsync("api/Photo", photoobject).Result;



                                                if (responsephoto.IsSuccessStatusCode)
                                                {
                                                    CountNews++;
                                                }




                                            }
                                            contact.LastFileDate = responsefile.LastModified;
                                            if (client.BaseAddress == null)
                                            {
                                                client.BaseAddress = new Uri(BaseUrl);
                                            }
                                            HttpResponseMessage responsecontact = client.PutAsJsonAsync("api/Contact/" + item.IDBusiness, contact).Result;

                                            if (responsecontact.IsSuccessStatusCode)
                                            {

                                            }
                                        }
                                        reader.Close();
                                        responsefile.Close();
                                 }
                             

                             }
                            
                                                                  
                        }

                    
                }
               
            }
            return CountNews;
        }
 
     
    }
}

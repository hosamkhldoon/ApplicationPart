using FileWorxObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
namespace ApiClients
{
   public class FileOperationClient
    {
        private string BaseUrl = "https://localhost:44391/";
        private HttpClient client;
        public string UploadFile(FileOperation file)
        {

            client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = TimeSpan.FromMinutes(15);
            HttpResponseMessage response = client.PostAsJsonAsync("api/FileOperation", file).Result;



            if (response.IsSuccessStatusCode)
            {
                 return "Saved Successfully";
            }
           
            

            return "";


        }
    }
}

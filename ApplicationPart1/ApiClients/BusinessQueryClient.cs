using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using FileWorxObjects;
using Newtonsoft.Json;
using System.Linq;

namespace ApiClients
{
    public class BusinessQueryClient
    {

        private string BaseUrl = "https://localhost:44391/";
        private HttpClient client;
        public List<BusinessObject> GetAllNewsAndPhotos()
        {

            client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = TimeSpan.FromMinutes(5);
            HttpResponseMessage response = client.GetAsync("api/Business").Result;
          
      
            if (response.IsSuccessStatusCode)
            {
               var body= response.Content.ReadAsStringAsync().Result;
              List<BusinessObject> NewsAndPhotosData = JsonConvert.DeserializeObject<List<BusinessObject>>(body);
                return NewsAndPhotosData ;
            }
            return null;
        }
      
  

    }
}

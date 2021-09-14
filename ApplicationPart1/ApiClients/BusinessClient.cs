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
    public class BusinessClient
    {
        private string BaseUrl = "https://localhost:44391/";
        private HttpClient client; 
        public BusinessObject ReadNewsOrPhotoOrUser(int id)
        {

            client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/Business/" + id).Result;

  
            if (response.IsSuccessStatusCode)
            {
                var body = response.Content.ReadAsStringAsync().Result;
                BusinessObject BusinessData = JsonConvert.DeserializeObject<BusinessObject>(body);
                return BusinessData;
            }
            return null;
        }
   
        public string DeleteNewsOrPhotoOrUser(int id)
        {

            client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.DeleteAsync("api/Business/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                return "Deleted Successfully";
            }


            return "";


        }

    }
}

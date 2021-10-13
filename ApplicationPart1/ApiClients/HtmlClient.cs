using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using FileWorxObjects;
using System.Net.Http.Json;
using DTO;
namespace ApiClients
{
    public class HtmlClient
    {
        private string BaseUrl = "https://localhost:44391/";
        private HttpClient client;
        public HtmlFileReadService ReadHtmlPage(int id)
        {

            client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = TimeSpan.FromMinutes(5);
            HttpResponseMessage response = client.GetAsync("api/Html/" + id).Result;


            if (response.IsSuccessStatusCode)
            {
                var body = response.Content.ReadAsStringAsync().Result;
                HtmlFileReadService HtmlData = JsonConvert.DeserializeObject<HtmlFileReadService>(body);
                return HtmlData;
            }
            return null;
        }
        public string DeleteHtmlPage(int id)
        {
            client = new HttpClient();

            client.BaseAddress = new Uri(BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = TimeSpan.FromMinutes(5);
            HttpResponseMessage response = client.DeleteAsync("api/Html/" + id).Result;



            if (response.IsSuccessStatusCode)
            {

                return "Deleted Successfully";
            }


            return "";


        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace SmartCityMobile.Data
{
    public class Call
    {
        private static HttpClient _httpClient = new HttpClient { BaseAddress = new Uri("http://10.0.0.126:49874") };

        protected static string GetDataFromHttpClient(string url)
        {
            //call http
            var reponseHttp = _httpClient.GetAsync(url).Result;
            //lire le resultat => json
            string jsonResult = reponseHttp.Content.ReadAsStringAsync().Result;
            //ajout des tests de communications
            return jsonResult;
        }

        protected static string PostDataFromHttpClient(string url, object content)
        {
            var json = JsonConvert.SerializeObject(content);
            var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
            //call http
            var reponseHttp = _httpClient.PostAsync(url, stringContent).Result;
            //lire le resultat => json
            string jsonResult = reponseHttp.Content.ReadAsStringAsync().Result;
            return jsonResult;
        }

        protected static string PutDataFromHttpClient(string url, object content)
        {
            var json = JsonConvert.SerializeObject(content);
            var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
            //call http
            var reponseHttp = _httpClient.PutAsync(url, stringContent).Result;
            //lire le resultat => json
            string jsonResult = reponseHttp.Content.ReadAsStringAsync().Result;
            //ajout des tests de communications
            return jsonResult;
        }
    }
}

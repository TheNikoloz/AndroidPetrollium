using System;
using System.Net.Http;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;

namespace Petrolium.Utilities
{
    public class DataRequest
    {
        public static T GetDataFromApi<T>(string url)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Method = "GET";
            webRequest.Accept = "application/json";
            webRequest.ContentType = "application/json";

            var response = webRequest.GetResponse();

            using(var responseSream = new StreamReader(response.GetResponseStream()))
            {
                string jsonString = responseSream.ReadToEnd();

                return JsonConvert.DeserializeObject<T>(jsonString);
            }

        }
    }
}

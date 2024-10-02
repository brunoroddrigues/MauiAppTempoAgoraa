using MauiAppTempoAgoraa.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppTempoAgoraa.Service
{
    public class DataService
    {

        public static async Task<Tempo?> GetPrevisaoDoTempo(
            string cidade)
        {
            // https://openweathermap.org/current#current_JSON
            // https://home.openweathermap.org/api_keys
            string appId = "6135072afe7f6cec1537d5cb08a5a1a2";

            string url = $"https://api.openweathermap.org/data/2.5/" +
                         $"weather?q={cidade}&units=metric&appid={appId}";

            Tempo tempo = null;

            using (HttpClient Client = new HttpClient())
            {
                HttpResponseMessage response = await Client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;


                    Debug.WriteLine("------------------------------");
                    Debug.WriteLine(json);
                    Debug.WriteLine("------------------------------");


                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;


//using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using SQLite;
using System.Net.Http.Json;
using System.Text.Json;


namespace Spide_Tech_App
{

	public class UserService
	{
        private readonly HttpClient _httpclient;

		public UserService()
		{
			this._httpclient = new HttpClient(); ;

        }

		public async Task<T> GetAsync<T>(string url)
		{


            //string url = "http://192.168.20.165:4000/api/users/63";

            _httpclient.BaseAddress = new Uri(url);

            HttpResponseMessage response = await _httpclient.GetAsync("");

            //var response = await _httpclient.GetAsync(url);

			if (response.IsSuccessStatusCode)
			{
				var jsonstring = await response.Content.ReadAsStringAsync();
				return JsonSerializer.Deserialize<T>(jsonstring);
			}

			throw new HttpRequestException($"Request failed with status code {response.StatusCode}");

		}

        public async Task<T> PostAsync<T>(string url,HttpContent content)
        {


            //string url = "http://192.168.20.165:4000/api/users/63";

            _httpclient.BaseAddress = new Uri(url);

            HttpResponseMessage response = await _httpclient.PostAsync("", content);

            //var response = await _httpclient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var jsonstring = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<T>(jsonstring);
            }

            throw new HttpRequestException($"Request failed with status code {response.StatusCode}");

        }

    }

}
		
		
		
    
	

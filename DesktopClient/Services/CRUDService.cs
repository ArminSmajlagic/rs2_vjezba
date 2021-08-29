using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using Newtonsoft.Json;

namespace DesktopClient.Services
{
    public class CRUDService
    {
        HttpClient http = HttpClientFactory.Create();

        public CRUDService()
        {

        }

        public async Task<T> Get<T>()
        {
            //HTTP Client factory

            //var result = await http.GetAsync(URLService.UrlFormater("Get"));
            //var content = result.Content;
            //var data = await content.ReadAsStringAsync();
            //return JsonConvert.DeserializeObject<T>(data);

            //Flurl Http

            return await URLService.UrlFormater("Get").GetJsonAsync<T>();
        }

        public async Task<T> Get<T>(string id)
        {
            return await URLService.UrlFormater("GetByID", id).GetJsonAsync<T>();
        }   

        public async Task<T> Insert<T>(string id)
        {
            return await URLService.UrlFormater("GetByID", id).GetJsonAsync<T>();
        }

        public async Task<T> Update<T>(string id)
        {
            return await URLService.UrlFormater("GetByID", id).GetJsonAsync<T>();
        }

        public async Task<T> Delete<T>(string id)
        {
            return await URLService.UrlFormater("GetByID", id).GetJsonAsync<T>();
        }
    }
}

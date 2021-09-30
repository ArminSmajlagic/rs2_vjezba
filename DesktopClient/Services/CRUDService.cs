using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using Newtonsoft.Json;
using IdentityModel.Client;

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


            //var discDoc = await http.GetDiscoveryDocumentAsync("https://localhost:44324/");
            //TokenResponse token = await http.RequestClientCredentialsTokenAsync(
            //            new ClientCredentialsTokenRequest() { 
            //                Address = discDoc.TokenEndpoint,
            //                ClientId= "desk_cli_1",
            //                ClientSecret= "desk_cli_1",
            //                Scope = "TheMainApi"
            //            }
            //            );
            //var client = HttpClientFactory.Create();
            //client.SetBearerToken(token.AccessToken);
            //var res = await client.GetAsync(URLService.UrlFormater("Get"));
            //var content = await res.Content.ReadAsStringAsync();

            //HTTP Client factory

            //var result = await http.GetAsync(URLService.UrlFormater("Get"));
            //var content = result.Content;
            //var data = await content.ReadAsStringAsync();
            //return JsonConvert.DeserializeObject<T>(content);

            //Flurl Http

            return await URLService.UrlFormater("Get").GetJsonAsync<T>();
        }

        public async Task<T> Get<T>(string id)
        {
            return await URLService.UrlFormater("GetByID", id).GetJsonAsync<T>();
        }   

        public async Task<T> Insert<T>()
        {
            return await URLService.UrlFormater("Insert").GetJsonAsync<T>();
        }

        public async Task<T> Update<T>(string id)
        {
            return await URLService.UrlFormater("Update", id).GetJsonAsync<T>();
        }

        public async Task<T> Delete<T>(string id)
        {
            return await URLService.UrlFormater("Delete", id).GetJsonAsync<T>();
        }
    }
}

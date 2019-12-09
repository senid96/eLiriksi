using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using liriksi.Model;
namespace liriksi.WinUI
{
   public class APIService
    {
        public string _route { get; set; }
        public APIService(string route)
        { 
            _route = route;
        }

        public async Task<T> Get<T>(object search)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}"; //pravi se ruta.. u setingsu je definisan api

            if (search != null)
            {
                url += "?";
                url += await search.ToQueryString();
            }

            var result = await url.GetJsonAsync<T>();
            return result;
        }
        public async Task<T> GetById<T>(object id)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}"; //pravi se ruta.. u setingsu je definisan api

            var result = url.GetJsonAsync<T>();
            return await result; 
        }
        public async Task<T> Insert<T>(object obj)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}"; //pravi se ruta.. u setingsu je definisan api

            var result = await url.PostJsonAsync(obj).ReceiveJson<T>();
            return result;
        }
        public async Task<T> Update<T>(object id, object obj)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}"; //pravi se ruta.. u setingsu je definisan api
            
            var result = await url.PutJsonAsync(obj).ReceiveJson<T>();
            return result;
        }
    }
}

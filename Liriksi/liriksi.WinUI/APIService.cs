using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using liriksi.Model;
namespace liriksi.WinUI
{
    class APIService
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
    }
}

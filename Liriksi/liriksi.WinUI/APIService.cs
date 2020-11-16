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
        public static string _username { get; set; }
        public static string _password { get; set; }
        public static Model.User _currentUser { get; set; }
        public string _route { get; set; }
        public APIService(string route)
        { 
            _route = route;
        }

        public async Task<T> Get<T>(object search, string method)
        {
            string url;
            if (String.IsNullOrEmpty(method))
                url = $"{Properties.Settings.Default.APIUrl}/{_route}"; //pravi se ruta.. u setingsu je definisan api
            else
                url = $"{Properties.Settings.Default.APIUrl}/{_route}/{method}";

            if (search != null)
            {
                url += "?";
                url += await search.ToQueryString();
            }

            var result = await url.WithBasicAuth(_username, _password).GetJsonAsync<T>();
            return result;
        }
        public async Task<T> GetById<T>(object id, string method)
        {
            string url;
            if (String.IsNullOrEmpty(method))
                url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}"; //pravi se ruta.. u setingsu je definisan api
            else
                url = $"{Properties.Settings.Default.APIUrl}/{_route}/{method}/{id}"; 

            var result = url.WithBasicAuth(_username, _password).GetJsonAsync<T>();
            return await result; 
        }
        public async Task<T> Insert<T>(object obj, string method)
        {
            var url = "";
            if(string.IsNullOrEmpty(method))
                url = $"{Properties.Settings.Default.APIUrl}/{_route}"; 
            else
                url = $"{Properties.Settings.Default.APIUrl}/{_route}/{method}"; 

            var result = await url.WithBasicAuth(_username, _password).PostJsonAsync(obj).ReceiveJson<T>();
            return result;
        }
        public async Task<T> Update<T>(object id, object obj)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}"; 
            
            var result = await url.WithBasicAuth(_username, _password).PutJsonAsync(obj).ReceiveJson<T>();
            return result;
        }
    }
}

using Flurl.Http;
using liriksi.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

public class APIService
{
    public static string _username { get; set; }
    public static string _password { get; set; }
    public static liriksi.Model.User _currentUser { get; set; }
    public string _route { get; set; }
#if DEBUG
    //private string _apiUrl = "http://192.168.1.17:65113/api"; //xiaomi
    private string _apiUrl = "http://10.0.2.2:65113/api"; //emulator
#endif
#if RELEASE
    private string _apiUrl = "https://mywebsite.com/api/";
#endif
    public APIService(string route)
    {
        _route = route;
    }
    public async Task<T> Get<T>(object search, string method)
    {
        string url;
        if (String.IsNullOrEmpty(method))
            url = $"{_apiUrl}/{_route}"; //pravi se ruta.. u setingsu je definisan api
        else
            url = $"{_apiUrl}/{_route}/{method}";

        try
        {
            if (search != null)
            {
                url += "?";
                url += await search.ToQueryString();
            }

            var result = await url.WithBasicAuth(_username, _password).GetJsonAsync<T>();
            return result;
        }
        catch (FlurlHttpException ex)
        {
            if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Niste autentificirani", "Ok");
            }
            throw;
        }
    }
    public async Task<T> GetById<T>(object id, string method)
    {
        string url;
        if (String.IsNullOrEmpty(method))
            url = $"{_apiUrl}/{_route}/{id}"; //pravi se ruta.. u setingsu je definisan api
        else
            url = $"{_apiUrl}/{_route}/{method}/{id}"; //pravi se ruta.. u setingsu je definisan api

        try
        {
            var result = url.WithBasicAuth(_username, _password).GetJsonAsync<T>();
            return await result;
        }
        catch (FlurlHttpException ex)
        {
            if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Niste autentificirani", "Ok");
            }
            throw;
        }
    }
    public async Task<T> Insert<T>(object obj)
    {
        var url = $"{_apiUrl}/{_route}"; //pravi se ruta.. u setingsu je definisan api

        try
        {
            var result = await url.WithBasicAuth(_username, _password).PostJsonAsync(obj).ReceiveJson<T>();
            return result;
        }
        catch (FlurlHttpException ex)
        {
            if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Niste autentificirani", "Ok");
            }
            throw;
        }
    }
    public async Task<T> Update<T>(object id, object obj)
    {
        var url = $"{_apiUrl}/{_route}/{id}"; //pravi se ruta.. u setingsu je definisan api
        try
        {
            var result = await url.WithBasicAuth(_username, _password).PutJsonAsync(obj).ReceiveJson<T>();
            return result;
        }
        catch (FlurlHttpException ex)
        {
            if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Niste autentificirani", "Ok");
            }
            throw;
        }
    }
}

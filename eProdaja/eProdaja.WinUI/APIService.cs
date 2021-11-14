using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using eProdaja.Models;

namespace eProdaja.WinUI
{
    public class APIService
    {
        private string _route { get; set; }

        public APIService(string route) // prima naziv kontrolera
        {
            _route = route;
        }
          
        public async Task<T> Get<T>(object request = null)
        {
            var url =  $"{Properties.Settings.Default.APIUrl}/{_route}";
            if(request != null)
            {
                url += "?";
                url += await request.ToQueryString();
            }
             
            var result = await url.GetJsonAsync<T>();

            return result;
        }

        public async Task<T> GetById<T>(object id)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

            var result = await url.GetJsonAsync<T>();
            return result;
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";
            var result = await url.PostJsonAsync(request).ReceiveJson<T>();
            return result;
        }

        public async Task<T> Update<T>(object id, object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";
            var result = await url.PutJsonAsync(request).ReceiveJson<T>();
            return result;
        }
    }
}

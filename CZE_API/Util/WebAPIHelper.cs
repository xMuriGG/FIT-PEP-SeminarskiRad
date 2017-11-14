using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web;

namespace CZE_API.Util
{
    public class WebAPIHelper
    {
        private HttpClient client { get; set; }
        private string route { get; set; }

        public WebAPIHelper(string uri, string route)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            this.route = route;
        }
        public HttpResponseMessage GetResponse()
        {
            return client.GetAsync(route).Result;
        }
        public HttpResponseMessage GetResponse<T>(T parametar)
        {
            return client.GetAsync(route + "/" + parametar).Result;
        }
        public HttpResponseMessage GetResponse<P,P1,P2,P3>(P parametar,P1 parametar1, P2 parametar2, P3 parametar3)
        {
            return client.GetAsync(route + "/" + parametar + "/" + parametar1 + "/" + parametar2 + "/" + parametar3).Result;
        }
        public HttpResponseMessage PostResponse<T>(T content)
        {
            return client.PostAsJsonAsync(route, content).Result;
        }
        public HttpResponseMessage DeleteResponse<T>(T content)
        {
            return client.DeleteAsync(route +"/"+content).Result;
        }
        public HttpResponseMessage PutResponse<T>(T content)
        {
            return client.PutAsJsonAsync(route, content).Result;
        }
        public HttpResponseMessage PostActionResponse(string action, Object newObject)
        {
            return client.PostAsJsonAsync(route + "/" + action, newObject).Result;
        }
        public HttpResponseMessage GetActionResponse(string action, string parameter = "")
        {
            return client.GetAsync(route + "/" + action + "/" + parameter).Result;
        }
    }
}
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace CZE_API.Util
{
    public class InfoBipSMS
    {
        public static IRestResponse SingleTextualMessageToOneDestination(string broj, string poruka)
        {
            var client = new RestClient("https://api.infobip.com/sms/1/text/single");

            var request = new RestRequest(Method.POST);
            request.AddHeader("accept", "application/json");
            request.AddHeader("content-type", "application/json");

            request.AddHeader("authorization", "Basic TXVyaXNGSVQ6NDMyMVRlc3Q=");

            //string parametar = "{\"from\":\"InfoSMS\", \"to\":\" " + broj + "\",\"text\":\"" + poruka + "\"}";

            //JavaScriptSerializer j = new JavaScriptSerializer();
            //object a = j.Deserialize(parametar, typeof(object));

            request.AddParameter("application/json", "{\"from\":\"FIT-CZE\", \"to\":\" " + broj + "\",\"text\":\"" + poruka + "\"}", ParameterType.RequestBody);

            return client.Execute(request);
        }
    }
}
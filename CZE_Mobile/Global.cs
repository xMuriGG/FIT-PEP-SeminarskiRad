using CZE_PCL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Resources;

namespace CZE_Mobile
{
    class Global
    {
        public static LogiraniKorisnik logiraniKorisnik { get; set; }
        public static bool IsKorisnikLogovan { get { return logiraniKorisnik != null; } }
        public static string GetMessage(string key)
        {
            //var rm = new Windows.ApplicationModel.Resources.ResourceLoader("Messages");
            //ResourceManager rm = new ResourceManager("CZE_Mobile.Messages", typeof(App).GetTypeInfo().Assembly);
            var rm = ResourceLoader.GetForCurrentView("Messages");
            return rm.GetString(key);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CZE_API.Models;
using System.Resources;
using System.Reflection;

namespace CZE_Desktop
{
    class Global
    {
        public static LogiraniKorisnik logiraniKorisnik { get; set; }
        public static bool IsKorisnikLogovan { get { return logiraniKorisnik != null; } }

        public static string GetMessage(string key)
        {
            ResourceManager rm = new ResourceManager("CZE_Desktop.Messages", Assembly.GetExecutingAssembly());
            return rm.GetString(key);
        }
    }
}

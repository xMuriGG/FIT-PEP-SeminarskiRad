using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CZE_PCL.Models
{
    [JsonObjectAttribute]
    public class KursKategorija
    {
        public int KursKategorijaID { get; set; }
        public string Naziv { get; set; }
    }
}

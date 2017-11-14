using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CZE_API.Models
{
    [JsonObjectAttribute]
    public class GrupaDisplayListVM
    {
        public int GrupaID { get; set; }
        public string Naziv { get; set; }
        public DateTime Pocetak { get; set; }
        public DateTime? Kraj { get; set; }
        public bool Aktivna { get; set; }
        public bool Utoku{ get; set; }
        public string ImePrezimeZaposlenika { get; set; }
    }
}
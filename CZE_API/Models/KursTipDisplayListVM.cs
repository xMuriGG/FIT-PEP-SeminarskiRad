using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CZE_API.Models
{
    [JsonObjectAttribute]
    public class KursTipDisplayListVM
    {
        public int KursTipID { get; set; }
        public string Naziv { get; set; }
        public int Trajanje { get; set; }//u casovima
        public decimal Cijena { get; set; }
        public string Opis { get; set; }
        public int KursKategorijaID { get; set; }
        public string KursKategorijaNaziv { get; set; }
    }
}
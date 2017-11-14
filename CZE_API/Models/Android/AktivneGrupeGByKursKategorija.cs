using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CZE_API.Models.Android
{
    public class AktivneGrupeGByKursKategorija
    {
        public int KursKategorijaID { get; set; }
        public string Naziv { get; set; }
        public List<AktivnaGrupaListVM> AktivnaGrupaListVM { get; set; }
    }
}
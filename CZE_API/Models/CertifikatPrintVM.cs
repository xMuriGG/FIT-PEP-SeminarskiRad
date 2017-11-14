using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CZE_API.Models
{
    public class CertifikatPrintVM
    {
        public int KandidatId { get; set; }
        public int GrupaKandidatiId { get; set; }
        public string ImePrezime { get; set; }
        public DateTime DatumRojeja { get; set; }
        public string Grad { get; set; }
        public string Modul { get; set; }
    }
}
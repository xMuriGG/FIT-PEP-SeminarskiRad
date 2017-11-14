using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CZE_PCL.Models
{
    public class CertifikatKandidataTableVM
    {
        public int GrupaKandidatiID { get; set; }
        public string GrupaNaziv { get; set; }
        public string KursNaziv { get; set; }
        public string TipNaziv { get; set; }
        public string Predavac { get; set; }
        public string Uplaceno { get; set; }
        public bool Otplaceno { get; set; }

        public bool CertifikatOdobren { get; set; }

        public DateTime? DatumOdobrenja { get; set; }
        public bool? Uruceno { get; set; }
        public string Biljeske { get; set; }
        public int? ZaposlenikID { get; set; }
    }
}
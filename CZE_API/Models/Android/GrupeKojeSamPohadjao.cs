using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CZE_API.Models.Android
{
    public class GrupeKojeSamPohadjao //old CertifikatKandidataTableVM
    {
        public int GrupaKandidatiID { get; set; }
        public string GrupaNaziv { get; set; }
        public string KursNaziv { get; set; }
        public string TipNaziv { get; set; }
        public string Predavac { get; set; }
        public string Uplaceno { get; set; }
        public bool Otplaceno { get; set; }
        public int Ocjena { get; set; }
        public string Opis { get; set; }

        public bool CertifikatOdobren { get; set; }
    }
}
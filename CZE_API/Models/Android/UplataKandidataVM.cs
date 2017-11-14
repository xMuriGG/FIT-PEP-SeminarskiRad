using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CZE_API.Models.Android
{
    public class UplataKandidataVM
    {
        public int UplataKandidataID { get; set; }
        public decimal Kolicina { get; set; }
        public bool RacunIzdat { get; set; }
        public DateTime DatumUplate { get; set; }
        public string Biljeske { get; set; }
    }
}
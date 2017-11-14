using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CZE_API.Models
{
    public class KursDisplayListVM
    {
        public int KursID { get; set; }

        public int KursTipID { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public double Ocjena { get; set; }

    }
}
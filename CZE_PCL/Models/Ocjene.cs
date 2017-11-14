using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CZE_PCL.Models
{
    public class Ocjene
    {
        public int OcjeneID { get; set; }

        public int KandidatID { get; set; }
        public int KursID { get; set; }
        public DateTime Datum { get; set; }
        public int Ocjena { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CZE_PCL.Models
{
    public class GrupaKandidati
    {
        public int GrupaKandidatiID { get; set; }
        public int KandidatID { get; set; }
        public int GrupaID { get; set; }
        public bool Otplaceno { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZE_DAL.Models
{
    [Table("Ocjene")]
    public class Ocjene
    {
        public int OcjeneID { get; set; }

        public int GrupaKandidatiID { get; set; }
        public virtual GrupaKandidati GrupaKandidati { get; set; }
        public DateTime Datum { get; set; }
        public int Ocjena { get; set; }
        public string Opis { get; set; }

    }

}

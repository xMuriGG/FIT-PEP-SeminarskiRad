using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZE_DAL.Models
{
    [Table("UplateKandidata")]
    public class UplataKandidata
    {
        public int UplataKandidataID { get; set; }
        public decimal Kolicina { get; set; }
        public bool RacunIzdat { get; set; }
        public string Biljeske { get; set; }
        public DateTime DatumUplate { get; set; }

        public int GrupaKandidatiID { get; set; }
        public virtual GrupaKandidati GrupaKandidati { get; set; }
        public int ZaposlenikID { get; set; }
        public virtual Zaposlenik Zaposlenik { get; set; }


    }
}

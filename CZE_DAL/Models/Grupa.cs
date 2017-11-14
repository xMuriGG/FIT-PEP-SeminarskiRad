using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZE_DAL.Models
{
    [Table("Grupe")]
    public class Grupa
    {
        public int GrupaID { get; set; }
        public string Naziv { get; set; }
        public DateTime Pocetak { get; set; }
        public DateTime? Kraj { get; set; }
        public bool Aktivna { get; set; }
        public bool UToku { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public int KursID { get; set; }
        public virtual Kurs Kurs { get; set; }
        public int ZaposlenikID { get; set; }
        public virtual Zaposlenik Zaposlenik { get; set; }

    }
}

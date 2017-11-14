using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZE_DAL.Models
{
    [Table("Certifikati")]
    public class Certifikat
    {
        [Key()]
        [ForeignKey("GrupaKandidati")]
        public int CertifikatID { get; set; }
        public DateTime DatumOdobrenja { get; set; }
        public bool Uruceno { get; set; }
        public string Biljeske { get; set; }

        public int ZaposlenikID { get; set; }
        public virtual Zaposlenik Zaposlenik { get; set; }
        public virtual GrupaKandidati GrupaKandidati { get; set; }
    }
}

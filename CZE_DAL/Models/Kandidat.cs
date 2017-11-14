using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZE_DAL.Models
{
    [Table("Kandidati")]
    public class Kandidat
    {
        [Key()]
        [ForeignKey("Osoba")]
        public int KandidatID { get; set; }
        public Osoba Osoba { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DatumUpisa { get; set; }
        [DataType(DataType.MultilineText)]
        public string Biljeske { get; set; }


    }
}

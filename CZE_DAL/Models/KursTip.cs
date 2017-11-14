using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZE_DAL.Models
{
    [Table("KursTipovi")]
   public class KursTip
    {
        public int KursTipID { get; set; }
        public string Naziv { get; set; }
        public int Trajanje { get; set; }//u casovima
        public decimal Cijena { get; set; }
        public string Opis { get; set; }
        public int KursKategorijaID { get; set; }
        public virtual KursKategorija KursKategorija { get; set; }
    }
}

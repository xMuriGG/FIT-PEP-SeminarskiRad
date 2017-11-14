using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZE_DAL.Models
{
    public class Kurs
    {
        public int KursID { get; set; }

        public int KursTipID { get; set; }
        public virtual KursTip KursTip { get; set; }
        public string Naziv { get; set; }    
        public string Opis { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CZE_PCL.Models
{
    public class Osoba
    {
        public int OsobaID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public Spol Spol { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }
        public int GradID { get; set; }
        public virtual List<BrojTelefona> BrojTelefona { get; set; }
    }
    public enum Spol { M, Z };

}

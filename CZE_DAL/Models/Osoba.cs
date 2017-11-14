using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CZE_DAL.Models
{
    [Table("Osobe")]

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

        #region Virtual
        public virtual KorisnickiNalog KorisnickiNalog { get; set; }
        public virtual Grad MjestoRodjenja { get; set; }
        public virtual Kandidat Kandidat { get; set; }
        public virtual Zaposlenik Zaposlenik { get; set; }
        public virtual List<BrojTelefona> BrojTelefona { get; set; }

        #endregion
      

    }
    public enum Spol { M,Z};
}

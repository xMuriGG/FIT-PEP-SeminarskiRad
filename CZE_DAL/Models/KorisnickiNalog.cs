using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CZE_DAL.Models
{
    [Table("KorisnickiNalozi")]
    public class KorisnickiNalog
    {
        [Key()]
        [ForeignKey("Osoba")]
        public int KorisnickiNalogID { get; set; }
        public virtual Osoba Osoba { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public bool Aktivan { get; set; }
        public UlogaKorisnika UlogaKorisnika { get; set; }

    }

    public enum UlogaKorisnika { Administrator, Direktor, Administrativni_Radnik, Predavac, Kandidat }
   
}

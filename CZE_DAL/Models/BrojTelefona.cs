using System.ComponentModel.DataAnnotations.Schema;
namespace CZE_DAL.Models
{
    [Table("BrojeviTelefona")]
    public class BrojTelefona
    {
        public int BrojTelefonaID { get; set; }
        public string Broj { get; set; }
        public TipoviTelefona TipTelefona { get; set; }

        public int OsobaID { get; set; }
        public virtual Osoba Osoba { get; set; }

    }
    public enum TipoviTelefona { Mobilni, Poslovni, Kucni, Fax }
   
}

namespace CZE_PCL.Models
{

    public class BrojTelefona
    {
        public int OsobaID { get; set; }
        public int BrojTelefonaID { get; set; }
        public string Broj { get; set; }
        public TipoviTelefona TipTelefona { get; set; }
    }
    public enum TipoviTelefona { Mobilni, Poslovni, Kucni, Fax }
   
}

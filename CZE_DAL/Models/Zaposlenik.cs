using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CZE_DAL.Models
{
    [Table("Zaposlenici")]
    public class Zaposlenik
    {
        [Key()]
        [ForeignKey("Osoba")]
        public int ZaposlenikID { get; set; }
        public Osoba Osoba { get; set; }
        [Display(Name = "Stepen obrazovanja")]
        public StepeniObrazovanja StepenObrazovanja { get; set; }
        [Required()]
        [Display(Name = "Broj radne knjižice")]
        [StringLength(50, ErrorMessage = "Maximalno 50 karaktera")]
        public string BrojRadneKnjizice { get; set; }      

    }
    public enum StepeniObrazovanja { SSS, VKV, VŠS, VSS, Bachelor, Magistratura, Doktorat }
}

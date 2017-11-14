using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CZE_DAL.Models;

namespace CZE_API.Models.Android
{
    public class GrupeKojePohadjam // old AktivnaGrupaListVM
    {
        public int Prijava { get; set; }
        public int GrupaKandidatiID { get; set; }
        //Grupa
        public int GrupaID { get; set; }
        public string GrupaNaziv { get; set; }
        public DateTime Pocetak { get; set; }
        public DateTime? Kraj { get; set; }
        public bool Aktivna { get; set; }
        public bool UToku { get; set; }
        //Kurs
        public int KursID { get; set; }
        public string KursNaziv { get; set; }
        public string KursOpis { get; set; }
        //KursTip
        public int KursTipID { get; set; }
        public string KursTipNaziv { get; set; }
        public int KursTipTrajanje { get; set; }//u casovima
        public string KursTipCijena { get; set; }
        public string KursTipOpis { get; set; }
        //Kategorija
        public int KursKategorijaID { get; set; }
        public string KursKategorijaNaziv { get; set; }
        //Zaposlenik
        public string ImePrezimeZaposlenika { get; set; }

        public List<UplataKandidataVM> UplateKandidata { get; set; }

    }
}
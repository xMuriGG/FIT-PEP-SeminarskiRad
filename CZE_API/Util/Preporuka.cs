using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using CZE_API.Models;
using CZE_DAL.Models;
using CZE_DAL;

namespace CZE_API.Util
{
    public class Preporuka
    {
        Dictionary<int?, List<Ocjene>> mainKursevi = new Dictionary<int?, List<Ocjene>>();
        CZEContext db = new CZEContext();

        public List<AktivnaGrupaListVM> GetSlicneGrupe(int kursId)
        {
            UcitajGrupe(kursId);

            List<Ocjene> ocjenePosmatranog = db.Ocjene.Where(x => x.GrupaKandidati.Grupa.KursID == kursId).OrderBy(x => x.GrupaKandidati.KandidatID).ToList();

            List<Ocjene> zajednickeOcjene1 = new List<Ocjene>();
            List<Ocjene> zajednickeOcjene2 = new List<Ocjene>();

            List<Kurs> kursPreporuceno = new List<Kurs>();
            List<AktivnaGrupaListVM> grupaPreporuceno = new List<AktivnaGrupaListVM>();

            foreach (var item in mainKursevi)
            {
                foreach (Ocjene o in ocjenePosmatranog)
                {
                    if (item.Value.Any(x => x.GrupaKandidati.KandidatID == o.GrupaKandidati.KandidatID))
                    {
                        zajednickeOcjene1.Add(o);
                        zajednickeOcjene2.Add(item.Value.First(x => x.GrupaKandidati.KandidatID == o.GrupaKandidati.KandidatID));
                    }
                }
                double slicnost = GetSlicnost(zajednickeOcjene1, zajednickeOcjene2);
                if (slicnost > 0.6)
                    kursPreporuceno.Add(db.Kursevi.FirstOrDefault(x => x.KursID == item.Key));
                zajednickeOcjene1.Clear();
                zajednickeOcjene2.Clear();
            }

            foreach (Kurs kurs in kursPreporuceno)
            {
                grupaPreporuceno.AddRange(
                    db.Grupe
                    .Where(x => x.KursID == kurs.KursID && x.Aktivna)
                    .Select(x => new AktivnaGrupaListVM()
                    {
                        Prijava = db.GrupeKandidati.Count(c => c.GrupaID == x.GrupaID),
                            //Grupa
                            GrupaID = x.GrupaID,
                        GrupaNaziv = x.Naziv,
                        Pocetak = x.Pocetak,
                        Kraj = x.Kraj,
                        Aktivna = x.Aktivna,
                        UToku = x.UToku,
                            //Kurs
                            KursID = x.Kurs.KursID,
                        KursNaziv = x.Kurs.Naziv,
                        KursOpis = x.Kurs.Opis,
                            //KursTip
                            KursTipID = x.Kurs.KursTip.KursTipID,
                        KursTipNaziv = x.Kurs.KursTip.Naziv,
                        KursTipTrajanje = x.Kurs.KursTip.Trajanje,
                        KursTipCijena = x.Kurs.KursTip.Cijena.ToString() + "KM",
                        KursTipOpis = x.Kurs.KursTip.Opis,
                            //Kategorija
                            KursKategorijaID = x.Kurs.KursTip.KursKategorija.KursKategorijaID,
                        KursKategorijaNaziv = x.Kurs.KursTip.KursKategorija.Naziv,

                        ImePrezimeZaposlenika = x.Zaposlenik.Osoba.Ime + " " + x.Zaposlenik.Osoba.Prezime
                    }
                    ));
            }

            return grupaPreporuceno.Take(5).ToList();


        }

        private double GetSlicnost(List<Ocjene> ocjene1, List<Ocjene> ocjene2)
        {
            if (ocjene1.Count != ocjene2.Count)
                return 0;
            int brojnik = 0;

            double int1 = 0, int2 = 0;

            for (int i = 0; i < ocjene1.Count; i++)
            {
                brojnik += ocjene1[i].Ocjena * ocjene2[i].Ocjena;

                int1 += ocjene1[i].Ocjena * ocjene1[i].Ocjena;
                int2 += ocjene2[i].Ocjena * ocjene2[i].Ocjena;
            }

            int1 = Math.Sqrt(int1);
            int2 = Math.Sqrt(int2);

            double nazivnik = int1 * int2;

            if (nazivnik != 0)
                return brojnik / nazivnik;

            return 0;
        }

        private void UcitajGrupe(int kursId)
        {
            List<Kurs> kursevi = db.Kursevi.Where(x => x.KursID != kursId).ToList();
            List<Ocjene> ocjene;

            foreach (Kurs k in kursevi)
            {
                ocjene = db.Ocjene.Where(x => x.GrupaKandidati.Grupa.KursID == k.KursID)
                    .Include(x=>x.GrupaKandidati).
                    OrderBy(x => x.GrupaKandidati.KandidatID)
                    .ToList();
                if (ocjene.Count > 0)
                {
                    mainKursevi.Add(k.KursID, ocjene);
                }
            }
        }
    }
}
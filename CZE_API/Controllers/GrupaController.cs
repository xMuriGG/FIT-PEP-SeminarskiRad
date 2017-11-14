using CZE_API.Models;
using CZE_DAL;
using CZE_DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CZE_API.Models.Android;
using CZE_API.Util;

namespace CZE_API.Controllers
{
    public class GrupaController : ApiController
    {
        CZEContext db = new CZEContext();

        [HttpGet,Route("Api/Grupa/GetGrupaById/{id}")]
        public IHttpActionResult GetGrupaById(int id)
        {
            Grupa g = db.Grupe.Find(id);
            if (g!=null)
            {
                return Ok(g);
            }
            return NotFound();
        }

        public IHttpActionResult Get(int id = 0)
        {
            List<GrupaDisplayListVM> list = db.Grupe
                .Where(x => id == 0 || x.KursID == id)
                .Select(x => new GrupaDisplayListVM
                {
                    GrupaID = x.GrupaID,
                    Naziv = x.Naziv,
                    Pocetak = x.Pocetak,
                    Kraj = x.Kraj,
                    Aktivna = x.Aktivna,
                    Utoku = x.UToku,
                    ImePrezimeZaposlenika = x.Zaposlenik.Osoba.Ime + " " + x.Zaposlenik.Osoba.Prezime
                })
                .ToList();
            return Ok(list);
        }

        [Route("Api/Grupa/VM/{id?}"), HttpGet]
        public IHttpActionResult GetVM(int id = 0)
        {
            List<AktivnaGrupaListVM> list = db.Grupe
                .Where(x => id == 0 || x.Kurs.KursTipID == id)
                .Select(x => new AktivnaGrupaListVM
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
                })
                .ToList();
            return Ok(list);
        }

        [Route("Api/Grupa/VMGByKursKategorija"), HttpGet]//android
        public IHttpActionResult GetVMGByKursKategorija()
        {
            List<AktivneGrupeGByKursKategorija> list = db.Grupe
                .Where(w=>w.Aktivna)
                .GroupBy(g => g.Kurs.KursTip.KursKategorija)
                .OrderBy(o => o.Key.Naziv)
                .Select(s => new AktivneGrupeGByKursKategorija()
                {
                    KursKategorijaID = s.Key.KursKategorijaID,
                    Naziv = s.Key.Naziv,
                    AktivnaGrupaListVM = s.Select(x => new AktivnaGrupaListVM()
                    {
                        Prijava = db.GrupeKandidati.Count(c => c.GrupaID == x.GrupaID),
                        //Grupa
                        GrupaID = x.GrupaID,
                        GrupaNaziv = x.Naziv,
                        Pocetak = x.Pocetak,
                        Kraj = x.Kraj,
                        Aktivna = x.Aktivna,
                        UToku = x.UToku,
                        Slika = x.Slika,
                        SlikaThumb = x.SlikaThumb,
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
                    }).ToList()
                })
                .ToList();




            return Ok(list);
        }


        [Route("Api/Grupa/MostRated"), HttpGet]
        public IHttpActionResult MostRated()
        {
            var avegaeList = db.Ocjene
                .GroupBy(x => x.GrupaKandidati.Grupa.KursID)
                .Select(s => new { kursId = s.Key, avg = s.Average(a => a.Ocjena) })
                .OrderBy(o => o.avg)
                .ToList()
                .Take(10);

            if (!avegaeList.Any())
                return NotFound();

            List<AktivnaGrupaListVM> list = new List<AktivnaGrupaListVM>();

            foreach (var i in avegaeList)
            {
                list.AddRange(
                    db.Grupe.Where(w => w.KursID == i.kursId)
                    .Select(x => new AktivnaGrupaListVM
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
                    })
                    .ToList()
                    );
            }
            return Ok(list.Take(10));
        }

        [Route("Api/Grupa/PreporuceneGrupe/{kursId}")]
        [HttpGet]
        public IHttpActionResult PreporuceneGrupe(int kursId)
        {
            Preporuka p = new Preporuka();
            return Ok(p.GetSlicneGrupe(kursId));

        }

        public IHttpActionResult Post(Grupa g)
        {
            
            if (g.GrupaID!=0)
            {
                try
                {
                    db.Grupe.Attach(g);
                    db.Entry(g).State = EntityState.Modified;
                    db.SaveChanges();
                    return Ok();
                }
                catch (Exception ex)
                {
                    HttpResponseMessage msg = new HttpResponseMessage(HttpStatusCode.Conflict)
                    {
                        ReasonPhrase = ex.Message
                    };
                    return ResponseMessage(msg);
                }
               
            }

            try
            {
                db.Grupe.Add(g);
                db.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                HttpResponseMessage msg = new HttpResponseMessage(HttpStatusCode.Conflict)
                {
                    ReasonPhrase = ex.Message
                };
                return ResponseMessage(msg);
            }
        }

        [HttpGet,Route("Api/Grupa/StatusToUtoku/{grupaId}")]
        public IHttpActionResult StatusToUtoku(int grupaId)
        {
            Grupa g = db.Grupe.Find(grupaId);
            if (g == null)
            {
                return NotFound();
            }
            g.Aktivna = false;
            g.UToku = true;
            db.SaveChanges();
            return StatusCode(HttpStatusCode.NoContent);
        }

        [HttpGet,Route("Api/Grupa/StatusToZavrsena/{grupaId}")]
        public IHttpActionResult StatusToZavrsena(int grupaId)
        {
            Grupa g = db.Grupe.Find(grupaId);
            if (g == null)
            {
                return NotFound();
            }
            g.Aktivna = false;
            g.UToku = false;
            db.SaveChanges();
            return StatusCode(HttpStatusCode.NoContent);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

using CZE_API.Models;
using CZE_DAL;
using CZE_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CZE_API.Models.Android;

namespace CZE_API.Controllers
{
    public class GrupaKandidatiController : ApiController
    {
        CZEContext db = new CZEContext();

        [Route("Api/GrupaKandidati/MojeGrupe/{id}/{aktivne?}")]

        public IHttpActionResult GetMojeGrupe(int id, bool aktivne = true)
        {
            List<AktivnaGrupaListVM> list;
            if (aktivne)
            {
                list = db.GrupeKandidati
                    .Where(x => x.KandidatID == id && (x.Grupa.Aktivna == aktivne || x.Grupa.UToku == aktivne))
                   .Select(x => new AktivnaGrupaListVM
                   {
                       Prijava = db.GrupeKandidati.Count(c => c.GrupaID == x.Grupa.GrupaID),
                       //Grupa
                       GrupaID = x.Grupa.GrupaID,
                       GrupaNaziv = x.Grupa.Naziv,
                       Pocetak = x.Grupa.Pocetak,
                       Kraj = x.Grupa.Kraj,
                       Aktivna = x.Grupa.Aktivna,
                       UToku = x.Grupa.UToku,
                       //Kurs
                       KursID = x.Grupa.Kurs.KursID,
                       KursNaziv = x.Grupa.Kurs.Naziv,
                       KursOpis = x.Grupa.Kurs.Opis,
                       //KursTip
                       KursTipID = x.Grupa.Kurs.KursTip.KursTipID,
                       KursTipNaziv = x.Grupa.Kurs.KursTip.Naziv,
                       KursTipTrajanje = x.Grupa.Kurs.KursTip.Trajanje,
                       KursTipCijena = x.Grupa.Kurs.KursTip.Cijena.ToString() + "KM",
                       KursTipOpis = x.Grupa.Kurs.KursTip.Opis,
                       //Kategorija
                       KursKategorijaID = x.Grupa.Kurs.KursTip.KursKategorija.KursKategorijaID,
                       KursKategorijaNaziv = x.Grupa.Kurs.KursTip.KursKategorija.Naziv,

                       ImePrezimeZaposlenika = x.Grupa.Zaposlenik.Osoba.Ime + " " + x.Grupa.Zaposlenik.Osoba.Prezime
                   })
                    .ToList();
            }
            else
            {
                list = db.GrupeKandidati
                   .Where(x => x.KandidatID == id && (x.Grupa.Aktivna == aktivne && x.Grupa.UToku == aktivne))
                  .Select(x => new AktivnaGrupaListVM
                  {
                      Prijava = db.GrupeKandidati.Count(c => c.GrupaID == x.Grupa.GrupaID),
                      //Grupa
                      GrupaID = x.Grupa.GrupaID,
                      GrupaNaziv = x.Grupa.Naziv,
                      Pocetak = x.Grupa.Pocetak,
                      Kraj = x.Grupa.Kraj,
                      Aktivna = x.Grupa.Aktivna,
                      UToku = x.Grupa.UToku,
                      //Kurs
                      KursID = x.Grupa.Kurs.KursID,
                      KursNaziv = x.Grupa.Kurs.Naziv,
                      KursOpis = x.Grupa.Kurs.Opis,
                      //KursTip
                      KursTipID = x.Grupa.Kurs.KursTip.KursTipID,
                      KursTipNaziv = x.Grupa.Kurs.KursTip.Naziv,
                      KursTipTrajanje = x.Grupa.Kurs.KursTip.Trajanje,
                      KursTipCijena = x.Grupa.Kurs.KursTip.Cijena.ToString() + "KM",
                      KursTipOpis = x.Grupa.Kurs.KursTip.Opis,
                      //Kategorija
                      KursKategorijaID = x.Grupa.Kurs.KursTip.KursKategorija.KursKategorijaID,
                      KursKategorijaNaziv = x.Grupa.Kurs.KursTip.KursKategorija.Naziv,

                      ImePrezimeZaposlenika = x.Grupa.Zaposlenik.Osoba.Ime + " " + x.Grupa.Zaposlenik.Osoba.Prezime
                  })
                   .ToList();
            }
            return Ok(list);
        }

        [HttpGet,Route("Api/GrupaKandidati/TableVM/{kandidatId}")]
        public IHttpActionResult TableVM(int kandidatId)
        {
            var list = db.GrupeKandidati.Where(x => x.KandidatID == kandidatId)
                .Select(s => new GrupeKandidatiTableVM()
                {
                    GrupaKandidatiID = s.GrupaKandidatiID,
                    GrupaNaziv = s.Grupa.Naziv,
                    KursNaziv = s.Grupa.Kurs.Naziv,
                    TipNaziv = s.Grupa.Kurs.KursTip.Naziv,
                    Predavac = s.Grupa.Zaposlenik.Osoba.Ime + " " + s.Grupa.Zaposlenik.Osoba.Prezime,
                    Uplaceno = (
                                   db.UplateKandidata.Any(x => x.GrupaKandidatiID == s.GrupaKandidatiID)
                                       ? db.UplateKandidata.Where(x => x.GrupaKandidatiID == s.GrupaKandidatiID)
                                       .Sum(x => x.Kolicina)
                                       : 0m
                               ) + "\\" + s.Grupa.Kurs.KursTip.Cijena + " KM",
                    Otplaceno = s.Otplaceno
                })
                .ToList();
            return Ok(list);
        }
        [HttpGet,Route("Api/GrupaKandidati/OtplacenoStatusChange/{grupaKandidatiId}")]
        public IHttpActionResult OtplacenoStatusChange(int grupaKandidatiId)
        {
            var gK = db.GrupeKandidati.Find(grupaKandidatiId);
            if (gK == null)
            {
                return NotFound();
            }
            gK.Otplaceno = !gK.Otplaceno;
            db.SaveChanges();

            return ResponseMessage(new HttpResponseMessage(HttpStatusCode.NoContent));

        }


        [HttpGet,Route("Api/GrupaKandidati/GrupeKojePohadjam/{korisnickiNalogId}")] //Android
        public IHttpActionResult GrupeKojePohadjam(int korisnickiNalogId)
        {
            List<GrupeKojePohadjam> list = db.GrupeKandidati
                .Where(x => x.KandidatID == korisnickiNalogId && (x.Grupa.Aktivna || x.Grupa.UToku))
                .Select(x => new GrupeKojePohadjam()
                {
                    Prijava = db.GrupeKandidati.Count(cc => cc.GrupaID == x.Grupa.GrupaID),
                    GrupaKandidatiID = x.GrupaKandidatiID,
                    //Grupa
                    GrupaID = x.Grupa.GrupaID,
                    GrupaNaziv = x.Grupa.Naziv,
                    Pocetak = x.Grupa.Pocetak,
                    Kraj = x.Grupa.Kraj,
                    Aktivna = x.Grupa.Aktivna,
                    UToku = x.Grupa.UToku,
                    //Kurs
                    KursID = x.Grupa.Kurs.KursID,
                    KursNaziv = x.Grupa.Kurs.Naziv,
                    KursOpis = x.Grupa.Kurs.Opis,
                    //KursTip
                    KursTipID = x.Grupa.Kurs.KursTip.KursTipID,
                    KursTipNaziv = x.Grupa.Kurs.KursTip.Naziv,
                    KursTipTrajanje = x.Grupa.Kurs.KursTip.Trajanje,
                    KursTipCijena = x.Grupa.Kurs.KursTip.Cijena.ToString() + "KM",
                    KursTipOpis = x.Grupa.Kurs.KursTip.Opis,
                    //Kategorija
                    KursKategorijaID = x.Grupa.Kurs.KursTip.KursKategorija.KursKategorijaID,
                    KursKategorijaNaziv = x.Grupa.Kurs.KursTip.KursKategorija.Naziv,

                    ImePrezimeZaposlenika = x.Grupa.Zaposlenik.Osoba.Ime + " " + x.Grupa.Zaposlenik.Osoba.Prezime,

                    UplateKandidata = db.UplateKandidata
                        .Where(w => w.GrupaKandidatiID == x.GrupaKandidatiID)
                        .Select(y => new UplataKandidataVM()
                        {
                            UplataKandidataID = y.UplataKandidataID,
                            Kolicina = y.Kolicina,
                            RacunIzdat = y.RacunIzdat,
                            DatumUplate = y.DatumUplate,
                            Biljeske = y.Biljeske
                        }).ToList()
                })
                .ToList();

            return Ok(list);
        }

        [HttpGet, Route("Api/GrupaKandidati/GrupeKojeSamPohadjao/{korisnickiNalogId}")] //Android
        public IHttpActionResult GrupeKojeSamPohadjao(int korisnickiNalogId)
        {
            List<GrupeKojeSamPohadjao> list = db.GrupeKandidati
                .Where(w => w.KandidatID == korisnickiNalogId && (!w.Grupa.Aktivna && !w.Grupa.UToku))
                .Select(y => new GrupeKojeSamPohadjao()
                {
                    GrupaKandidatiID = y.GrupaKandidatiID,
                    GrupaNaziv = y.Grupa.Naziv,
                    KursNaziv = y.Grupa.Kurs.Naziv,
                    TipNaziv = y.Grupa.Kurs.KursTip.Naziv,
                    Predavac = y.Grupa.Zaposlenik.Osoba.Ime + " " + y.Grupa.Zaposlenik.Osoba.Prezime,
                    Uplaceno = (
                                   db.UplateKandidata.Any(x => x.GrupaKandidatiID == y.GrupaKandidatiID)
                                       ? db.UplateKandidata.Where(x => x.GrupaKandidatiID == y.GrupaKandidatiID)
                                           .Sum(x => x.Kolicina)
                                       : 0m
                               ) + "\\" + y.Grupa.Kurs.KursTip.Cijena + " KM",
                    Otplaceno = y.Otplaceno,
                    Ocjena = db.Ocjene.Where(w => w.GrupaKandidatiID == y.GrupaKandidatiID).Select(z => z.Ocjena)
                        .FirstOrDefault(),
                    Opis = db.Ocjene.Where(w => w.GrupaKandidatiID == y.GrupaKandidatiID).Select(z => z.Opis)
                        .FirstOrDefault(),
                    CertifikatOdobren = y.Certifikat != null,

                }).ToList();


            return Ok(list);
        }


        public IHttpActionResult Post(GrupaKandidati gK)
        {
            HttpResponseMessage msg = new HttpResponseMessage();
            if (db.GrupeKandidati.Any(x => x.GrupaID == gK.GrupaID && x.KandidatID == gK.KandidatID))
            {
                msg.StatusCode = HttpStatusCode.Conflict;
                msg.ReasonPhrase = "Korisnik vec prijavljen u grupu.";
            }
            else
            {
                try
                {
                    db.GrupeKandidati.Add(gK);
                    db.SaveChanges();
                    return Ok();
                }
                catch (Exception ex)
                {
                    msg.StatusCode = HttpStatusCode.InternalServerError;
                    msg.ReasonPhrase = ex.Message;
                }
            }
            return ResponseMessage(msg);
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

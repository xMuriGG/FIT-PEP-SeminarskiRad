using CZE_API.Models;
using CZE_DAL;
using CZE_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Web.Http;
using CZE_API.Models.Android;
using CZE_API.Util;

namespace CZE_API.Controllers
{
    public class KorisnickiNalogController : ApiController
    {
        CZEContext db = new CZEContext();
        [Route("Api/KorisnickiNalog/{korisnickoIme}")]
        public IHttpActionResult GetKorisnikByUserName(string korisnickoIme)
        {
           
           LogiraniKorisnik l= db.KorisnickiNalozi
                .Where(x => x.Aktivan && (x.KorisnickoIme == korisnickoIme || x.Osoba.Email == korisnickoIme))
                .Select(s=> new LogiraniKorisnik
                {
                    KorisnickiNalogID = s.KorisnickiNalogID,
                    KorisnickoIme = s.KorisnickoIme,
                    Ime = s.Osoba.Ime,
                    Prezime = s.Osoba.Prezime,
                    DatumRodjenja = s.Osoba.DatumRodjenja,
                    Spol = s.Osoba.Spol,
                    Email = s.Osoba.Email,
                    Adresa = s.Osoba.Adresa,
                    LozinkaHash = s.LozinkaHash,
                    LozinkaSalt=s.LozinkaSalt,
                    Aktivan = s.Aktivan,
                    UlogaKorisnika = s.UlogaKorisnika,
                    IsKandidat=s.Osoba.Kandidat!=null,
                    IsZaposlenik=s.Osoba.Zaposlenik!=null
                })
                 .FirstOrDefault();
            if (l==null)
            {
                return NotFound();
            }
            return Ok(l);
        }

        [HttpGet,Route("Api/KorisnickiNalog/GetKorisnikByLogInData/{korisnickoIme}/{lozinka}")]//android
        public IHttpActionResult GetKorisnikByLogInData(string korisnickoIme, string lozinka)
        {
            var c = new GrupaKandidatiController();
            LogiraniKorisnikAndroid lk=db.KorisnickiNalozi
                .Where(x => x.Aktivan && (x.KorisnickoIme == korisnickoIme || x.Osoba.Email == korisnickoIme))
                .Select(s => new LogiraniKorisnikAndroid()
                {
                    KorisnickiNalogID = s.KorisnickiNalogID,
                    KorisnickoIme = s.KorisnickoIme,
                    Ime = s.Osoba.Ime,
                    Prezime = s.Osoba.Prezime,
                    DatumRodjenja = s.Osoba.DatumRodjenja,
                    Spol = s.Osoba.Spol,
                    Email = s.Osoba.Email,
                    Adresa = s.Osoba.Adresa,
                    LozinkaHash = s.LozinkaHash,
                    LozinkaSalt = s.LozinkaSalt,
                    Aktivan = s.Aktivan,
                    UlogaKorisnika = s.UlogaKorisnika,
                    IsKandidat = s.Osoba.Kandidat != null,
                    IsZaposlenik = s.Osoba.Zaposlenik != null,

                    //#region GrupeKojePohadjam
                    //GrupeKojePohadjam = db.GrupeKandidati
                    //    .Where(x => x.KandidatID == s.KorisnickiNalogID && (x.Grupa.Aktivna || x.Grupa.UToku))
                    //    .Select(x => new GrupeKojePohadjam()
                    //    {
                    //        Prijava = db.GrupeKandidati.Count(cc => cc.GrupaID == x.Grupa.GrupaID),
                    //        GrupaKandidatiID = x.GrupaKandidatiID,
                    //        //Grupa
                    //        GrupaID = x.Grupa.GrupaID,
                    //        GrupaNaziv = x.Grupa.Naziv,
                    //        Pocetak = x.Grupa.Pocetak,
                    //        Kraj = x.Grupa.Kraj,
                    //        Aktivna = x.Grupa.Aktivna,
                    //        UToku = x.Grupa.UToku,
                    //        //Kurs
                    //        KursID = x.Grupa.Kurs.KursID,
                    //        KursNaziv = x.Grupa.Kurs.Naziv,
                    //        KursOpis = x.Grupa.Kurs.Opis,
                    //        //KursTip
                    //        KursTipID = x.Grupa.Kurs.KursTip.KursTipID,
                    //        KursTipNaziv = x.Grupa.Kurs.KursTip.Naziv,
                    //        KursTipTrajanje = x.Grupa.Kurs.KursTip.Trajanje,
                    //        KursTipCijena = x.Grupa.Kurs.KursTip.Cijena.ToString() + "KM",
                    //        KursTipOpis = x.Grupa.Kurs.KursTip.Opis,
                    //        //Kategorija
                    //        KursKategorijaID = x.Grupa.Kurs.KursTip.KursKategorija.KursKategorijaID,
                    //        KursKategorijaNaziv = x.Grupa.Kurs.KursTip.KursKategorija.Naziv,

                    //        ImePrezimeZaposlenika = x.Grupa.Zaposlenik.Osoba.Ime + " " + x.Grupa.Zaposlenik.Osoba.Prezime,

                    //        UplateKandidata = db.UplateKandidata
                    //            .Where(w => w.GrupaKandidatiID == x.GrupaKandidatiID)
                    //            .Select(y => new UplataKandidataVM()
                    //            {
                    //                UplataKandidataID = y.UplataKandidataID,
                    //                Kolicina = y.Kolicina,
                    //                RacunIzdat = y.RacunIzdat,
                    //                DatumUplate = y.DatumUplate,
                    //                Biljeske = y.Biljeske
                    //            }).ToList()
                    //    })
                    //    .ToList(),
                    //#endregion

                    //#region GrupeKojeSamPohadjao
                    //GrupeKojeSamPohadjao = db.GrupeKandidati.Where(w => w.KandidatID ==s.KorisnickiNalogID  && (!w.Grupa.Aktivna && !w.Grupa.UToku))
                    //    .Select(y => new GrupeKojeSamPohadjao()
                    //    {
                    //        GrupaKandidatiID = y.GrupaKandidatiID,
                    //        GrupaNaziv = y.Grupa.Naziv,
                    //        KursNaziv = y.Grupa.Kurs.Naziv,
                    //        TipNaziv = y.Grupa.Kurs.KursTip.Naziv,
                    //        Predavac = y.Grupa.Zaposlenik.Osoba.Ime + " " + y.Grupa.Zaposlenik.Osoba.Prezime,
                    //        Uplaceno = (
                    //                       db.UplateKandidata.Any(x => x.GrupaKandidatiID == y.GrupaKandidatiID)
                    //                           ? db.UplateKandidata.Where(x => x.GrupaKandidatiID == y.GrupaKandidatiID).Sum(x => x.Kolicina)
                    //                           : 0m
                    //                   ) + "\\" + y.Grupa.Kurs.KursTip.Cijena + " KM",
                    //        Otplaceno = y.Otplaceno,
                    //        Ocjena = db.Ocjene.Where(w=>w.GrupaKandidatiID==y.GrupaKandidatiID).Select(z=>z.Ocjena).FirstOrDefault(),

                    //        CertifikatOdobren = y.Certifikat != null,                          

                    //    }).ToList()


                    //#endregion

                })
                .FirstOrDefault();
        
            string hash = UIHelper.GenerateHash(lozinka, lk.LozinkaSalt);
                if (string.Compare(hash, lk.LozinkaHash) == 0)
                {
                    return Ok(lk);
                }

            
            return NotFound();
        }
        public IHttpActionResult Post(KorisnickiNalog kN)
        {
            try
            {
                db.KorisnickiNalozi.Add(kN);
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
    }
}

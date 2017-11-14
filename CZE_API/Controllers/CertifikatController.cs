using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CZE_API.Models;
using CZE_DAL;
using CZE_DAL.Models;

namespace CZE_API.Controllers
{
    public class CertifikatController : ApiController
    {
        CZEContext db = new CZEContext();
        [Route("Api/Certifikat/{kandidatId}")]
        public IHttpActionResult Get(int kandidatId)
        {
            var l = db.GrupeKandidati.Where(x => x.KandidatID == kandidatId && (!x.Grupa.Aktivna && !x.Grupa.UToku) )
                .Select(s => new CertifikatKandidataTableVM()
                {
                    GrupaKandidatiID = s.GrupaKandidatiID,
                    GrupaNaziv = s.Grupa.Naziv,
                    KursNaziv = s.Grupa.Kurs.Naziv,
                    TipNaziv = s.Grupa.Kurs.KursTip.Naziv,
                    Predavac = s.Grupa.Zaposlenik.Osoba.Ime + " " + s.Grupa.Zaposlenik.Osoba.Prezime,
                    Uplaceno = (
                                 db.UplateKandidata.Any(x => x.GrupaKandidatiID == s.GrupaKandidatiID)
                                     ? db.UplateKandidata.Where(x => x.GrupaKandidatiID == s.GrupaKandidatiID).Sum(x => x.Kolicina)
                                     : 0m
                             ) + "\\" + s.Grupa.Kurs.KursTip.Cijena + " KM",
                    Otplaceno = s.Otplaceno,


                    CertifikatOdobren = s.Certifikat != null,

                    DatumOdobrenja = s.Certifikat != null ? (DateTime?)s.Certifikat.DatumOdobrenja : null,
                    Uruceno = s.Certifikat != null ? (bool?)s.Certifikat.Uruceno : null,
                    Biljeske = s.Certifikat != null ? s.Certifikat.Biljeske : null,
                    ZaposlenikID = s.Certifikat != null ? (int?)s.Certifikat.ZaposlenikID : null

                }).ToList();
            return Ok(l);
        }

        [Route("Api/Certifikat/UruciStatusChange/{grupaKandidatiId}")]
        [HttpGet]
        public IHttpActionResult UruciStatusChange(int grupaKandidatiId)
        {
            var c = db.Certifikati.Find(grupaKandidatiId);
            if (c == null)
            {
                return NotFound();
            }
            c.Uruceno = !c.Uruceno;
            db.SaveChanges();

            return ResponseMessage(new HttpResponseMessage(HttpStatusCode.NoContent));

        }

        [Route("Api/Certifikat/Print/{grupaKandidatiId}")]
        [HttpGet]
        public IHttpActionResult Print(int grupaKandidatiId)
        {
            var p= db.Certifikati.Where(x => x.CertifikatID == grupaKandidatiId)
                .Select(s => new CertifikatPrintVM()
                {
                    KandidatId = s.GrupaKandidati.KandidatID,
                    GrupaKandidatiId = s.GrupaKandidati.GrupaKandidatiID,
                    ImePrezime = s.GrupaKandidati.Kandidat.Osoba.Ime+" "+ s.GrupaKandidati.Kandidat.Osoba.Prezime,
                    DatumRojeja = s.GrupaKandidati.Kandidat.Osoba.DatumRodjenja,
                    Grad = s.GrupaKandidati.Kandidat.Osoba.MjestoRodjenja.Naziv,
                    Modul = s.GrupaKandidati.Grupa.Kurs.Naziv
                }).First();


            return p == null ? (IHttpActionResult) NotFound() : Ok(p);
        }
        public IHttpActionResult Post(Certifikat c)
        {
            try
            {
                db.Certifikati.Add(c);
                db.SaveChanges();
                return ResponseMessage(new HttpResponseMessage(HttpStatusCode.NoContent));
            }
            catch (Exception e)
            {
                return InternalServerError();
            }
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

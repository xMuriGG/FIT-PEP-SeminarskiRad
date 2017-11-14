using CZE_DAL;
using CZE_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using CZE_API.Models;
using System.Net.Http;
using System.Net;

namespace CZE_API.Controllers
{
    public class OsobaController : ApiController
    {
        CZEContext db = new CZEContext();
        [HttpGet]
        [Route("Api/OsobaPromoteGetAll/{kandidat}/{zaposlenik}/{kRacun}/{searchTerm?}")]
        public IHttpActionResult OsobaGet(bool kandidat,bool zaposlenik,bool kRacun, string searchTerm="")
        {
            return Ok(db.Osobe
                        .AsNoTracking()
                        .Where(x => (string.IsNullOrEmpty(searchTerm) || (x.Ime +" "+ x.Prezime).ToLower().Contains(searchTerm.ToLower()))
                        && (!kandidat || x.Kandidat!=null)
                        && (!zaposlenik || x.Zaposlenik != null)
                        && (!kRacun || x.KorisnickiNalog != null)
                )
                .Select(o=>new OsobaPromoteVM()
                {
                    OsobaID = o.OsobaID,
                    Ime = o.Ime,
                    Prezime = o.Prezime,
                    DatumRodjenja = o.DatumRodjenja,
                    Spol = o.Spol,
                    Email = o.Email,
                    Adresa = o.Adresa,
                    GradID = o.GradID,
                    Kandidat = o.Kandidat,
                    Zaposlenik = o.Zaposlenik,
                    KorisnickiNalog=o.KorisnickiNalog
                })
                .ToList());
        }
        [HttpGet]
        public IHttpActionResult OsobaGet(int id)
        {
            Osoba o = db.Osobe.Find(id);
            if (o == null)
            {
                return NotFound();
            }
            return Ok(o);
        }
        [HttpPost]
        public IHttpActionResult OsobaPost(Osoba o)
        {
            #region FiddlerRequest
            //            User - Agent: Fiddler
            //            Host: localhost: 33930
            //            Content - Type: application / json
            //            Content - Length: 115

            //            {'Ime':'API','Prezime':'Test','DatumRodjenja':'1/1/2015','Spol':'M','Email':'em@em.ba','Adresa':'API','GradID':'1'}


            //{
            //    "Ime":"FIDDLER",
            //    "Prezime":"FIDDLER",
            //    "DatumRodjenja":"1/1/2017",
            //    "Spol":"0",
            //    "Email":"em@em.com",
            //    "Adresa":"FIDDLER",
            //    "GradID":"4",
            //    "BrojTelefona":
            //            [
            //                {"Broj":"38761564952","TipTelefona":"0"},
            //                {"Broj":"38764444444","TipTelefona":"1"}
            //            ]
            //}
            #endregion

            if (ModelState.IsValid)
            {
                try
                {
                    db.Osobe.Add(o);                   
                    db.SaveChanges();
                    return CreatedAtRoute("DefaultApi", new { id = o.OsobaID }, o);
                }
                catch (Exception)
                {
                    return BadRequest();
                }
            }

            return BadRequest();
        }
        [HttpPut]
        public IHttpActionResult Put(Osoba o)
        {

            if (ModelState.IsValid)
            {
                try
                {                 
                    db.BrojeviTelefona.RemoveRange(db.BrojeviTelefona.Where(w => w.OsobaID == o.OsobaID).ToList());
                    foreach (BrojTelefona broj in o.BrojTelefona)
                    {
                        broj.OsobaID = o.OsobaID;
                    }
                    db.BrojeviTelefona.AddRange(o.BrojTelefona);
                    o.BrojTelefona = null;
                    db.Entry(o).State = System.Data.Entity.EntityState.Modified;
                   
                    db.SaveChanges();
                    return Ok();
                }
                catch (Exception ex)
                {
                    HttpResponseMessage message = new HttpResponseMessage(HttpStatusCode.Conflict);
                    message.ReasonPhrase = ex.Message;
                    return ResponseMessage(message);
                }
            }

            return BadRequest();
        }
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            Osoba o = new Osoba() { OsobaID = id };
            HttpResponseMessage message = new HttpResponseMessage();
            try
            {
                db.Osobe.Attach(o);
                db.Osobe.Remove(o);
                db.SaveChanges();
                message.StatusCode = HttpStatusCode.OK;
                return ResponseMessage(message);
            }
            catch (Exception ex)
            {
                message.ReasonPhrase = ex.Message;
                message.StatusCode = HttpStatusCode.Conflict;
                return ResponseMessage(message);
               
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

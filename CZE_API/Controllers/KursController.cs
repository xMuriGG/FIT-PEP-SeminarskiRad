using CZE_DAL;
using CZE_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CZE_API.Models;

namespace CZE_API.Controllers
{
    public class KursController : ApiController
    {
        CZEContext db = new CZEContext();
        public IHttpActionResult Get(int id=0)
        {
            return Ok(db.Kursevi.Where(x => id == 0 || x.KursTipID == id).ToList());
        }
        [Route("Api/Kurs/VM/{kursTipId}")]
        public IHttpActionResult GetVM(int kursTipId)
        {
            List<KursDisplayListVM> l = db.Kursevi.Where(x=>x.KursTipID==kursTipId).Select(x => new KursDisplayListVM
            {
               KursID = x.KursID,
               KursTipID = x.KursTipID,
               Naziv = x.Naziv,
               Opis = x.Opis,
               Ocjena = db.Ocjene.Any(a=> a.GrupaKandidati.Grupa.KursID==x.KursID)?
               db.Ocjene.Where(w=>w.GrupaKandidati.Grupa.KursID==x.KursID).Average(a=>a.Ocjena):0d
            }).ToList();
            return Ok(l);
        }
        public IHttpActionResult Post(Kurs k)
        {
            try
            {
                db.Kursevi.Add(k);
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

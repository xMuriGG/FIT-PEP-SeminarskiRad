using CZE_DAL;
using CZE_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CZE_API.Controllers
{
    public class OcjenaController : ApiController
    {
        CZEContext db = new CZEContext();
        [Route("Api/Ocjena/{kandidatID}/{kursID}")]
        public IHttpActionResult Get(int kandidatID, int kursID)
        {
            if (db.Ocjene.Any(x => x.GrupaKandidati.KandidatID == kandidatID && x.GrupaKandidati.Grupa.KursID == kursID))
                return Ok(db.Ocjene.FirstOrDefault(x => x.GrupaKandidati.KandidatID == kandidatID && x.GrupaKandidati.Grupa.KursID == kursID));
            else
                return NotFound();
        }
        public IHttpActionResult Post(Ocjene o)
        {
            HttpResponseMessage msg = new HttpResponseMessage();
            if (db.Ocjene.Any(x => x.GrupaKandidatiID == o.GrupaKandidatiID))
            {
                Ocjene real = db.Ocjene.FirstOrDefault(x => x.GrupaKandidatiID == o.GrupaKandidatiID);
                try
                {
                    real.Ocjena = o.Ocjena;
                    real.Datum = o.Datum;
                    real.Opis = o.Opis;
                    db.SaveChanges();
                    return Ok();
                }
                catch (Exception ex)
                {
                    msg.StatusCode = HttpStatusCode.Conflict;
                    msg.ReasonPhrase = ex.Message;
                    return ResponseMessage(msg);
                }
            }
            try
            {
                db.Ocjene.Add(o);
                db.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                msg = new HttpResponseMessage(HttpStatusCode.Conflict)
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

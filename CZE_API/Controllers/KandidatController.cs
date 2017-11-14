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
    public class KandidatController : ApiController
    {
        CZEContext db = new CZEContext();
        public IHttpActionResult Post(Kandidat k)
        {
            HttpResponseMessage msg = new HttpResponseMessage();
            try
            {
                db.Osobe.Attach(k.Osoba);
                db.Kandidati.Add(k);
                db.SaveChanges();
                msg.StatusCode = HttpStatusCode.Created;
                return ResponseMessage(msg);
            }
            catch (Exception ex)
            {
                msg.StatusCode = HttpStatusCode.Conflict;
                msg.ReasonPhrase = ex.Message;
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

using CZE_DAL;
using CZE_DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CZE_API.Controllers
{
    public class ZaposlenikController : ApiController
    {
        CZEContext db = new CZEContext();
        public IHttpActionResult Get()
        {
            return Ok(db.Zaposlenici.Include(x => x.Osoba).ToList());
        }

        public IHttpActionResult Post(Zaposlenik z)
        {
            HttpResponseMessage message = new HttpResponseMessage();
            try
            {
                db.Osobe.Attach(z.Osoba);
                db.Zaposlenici.Add(z);
                db.SaveChanges();
                message.StatusCode = HttpStatusCode.Created;
                return ResponseMessage(message);
            }
            catch (Exception ex)
            {
                message.StatusCode = HttpStatusCode.Conflict;
                message.ReasonPhrase = ex.Message;
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

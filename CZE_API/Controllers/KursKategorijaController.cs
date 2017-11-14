using CZE_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace CZE_API.Controllers
{
    public class KursKategorijaController : ApiController
    {
        CZEContext db = new CZEContext();
        public IHttpActionResult Get()
        {
            return Ok(db.KursKategorije.ToList());
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

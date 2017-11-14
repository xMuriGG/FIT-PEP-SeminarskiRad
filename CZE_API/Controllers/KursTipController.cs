using CZE_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CZE_API.Models;
using CZE_DAL.Models;

namespace CZE_API.Controllers
{
    public class KursTipController : ApiController
    {
        CZEContext db = new CZEContext();
        //[Route("Api/KursTip/{id?}")]
        public IHttpActionResult GetRaw(int id=0)
        {
            return Ok(db.KursTipovi.Where(x=>id==0 || x.KursKategorijaID==id).ToList());
        }
        [Route("Api/KursTip/VM")]
        public IHttpActionResult Get()
        {
            List<KursTipDisplayListVM> l = db.KursTipovi.Select(x => new KursTipDisplayListVM
            {
                KursTipID = x.KursTipID,
                Naziv = x.Naziv,
                Trajanje = x.Trajanje,
                Cijena = x.Cijena,
                Opis = x.Opis,
                KursKategorijaID = x.KursKategorijaID,
                KursKategorijaNaziv = x.KursKategorija.Naziv,
                
            }).ToList();
            return Ok(l);
        }
        
        public IHttpActionResult Post(KursTip k)
        {
            try
            {
                db.KursTipovi.Add(k);
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

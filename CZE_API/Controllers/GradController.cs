using CZE_DAL;
using CZE_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace CZE_API.Controllers
{
    public class GradController : ApiController
    {
        CZEContext db = new CZEContext();
        
        public IEnumerable<Grad> GetAll()
        {
            return db.Gradovi.ToList();
        }
        public IHttpActionResult GetAll(int id)
        {
            Grad g= db.Gradovi.Find(id);
            if (g!=null)
            {
                return Ok(g);
            }
            return NotFound();
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

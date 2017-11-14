using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using CZE_DAL;
using CZE_DAL.Models;

namespace CZE_API.Controllers
{
    public class UplataKandidataController : ApiController
    {
        CZEContext db = new CZEContext();
        [Route("Api/UplataKandidata/{grupaKandidatiId}")]
        public IHttpActionResult Get(int grupaKandidatiId)
        {
            return Ok(db.UplateKandidata.Where(x => x.GrupaKandidatiID == grupaKandidatiId).ToList());
        }

        public IHttpActionResult Post(UplataKandidata u)
        {
            try
            {
                db.UplateKandidata.Add(u);
                db.SaveChanges();
                return ResponseMessage(new HttpResponseMessage(HttpStatusCode.NoContent));
            }
            catch (Exception ex)
            {
                return InternalServerError();
            }
        }
        [HttpDelete]
        [Route("Api/UplataKandidata/{uplataKandidataId}")]
        public IHttpActionResult Delete(int uplataKandidataId)
        {
            UplataKandidata u=new  UplataKandidata() {UplataKandidataID = uplataKandidataId};
            try
            {
                db.UplateKandidata.Attach(u);
                db.UplateKandidata.Remove(u);
                db.SaveChanges();
                return ResponseMessage(new HttpResponseMessage(HttpStatusCode.NoContent));
            }
            catch (Exception)
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

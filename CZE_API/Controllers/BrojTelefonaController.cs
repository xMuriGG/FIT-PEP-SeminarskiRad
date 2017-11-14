using CZE_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using CZE_DAL.Models;
namespace CZE_API.Controllers
{
    public class BrojTelefonaController : ApiController
    {
        CZEContext db = new CZEContext();
        [Route("Api/BrojTelefona/{osobaId}")]
        public IHttpActionResult Get(int osobaId)
        {
            if (db.Osobe.Any(x => x.OsobaID == osobaId) && db.BrojeviTelefona.Any(x=>x.OsobaID==osobaId))
            {
                return Ok(db.BrojeviTelefona.Where(x => x.OsobaID == osobaId).ToList());
            }
            else
            {
                return NotFound();
            }
        }
    }
}

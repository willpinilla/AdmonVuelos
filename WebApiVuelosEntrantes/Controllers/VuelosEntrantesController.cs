using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiVuelosEntrantes.Models;

namespace WebApiVuelosEntrantes.Controllers
{
    public class VuelosEntrantesController : ApiController
    {
        private VuelosEntities db = new VuelosEntities();

        // GET: api/VuelosEntrantes
        public IQueryable<tblVuelos> GettblVuelos()
        {
            return db.tblVuelos.Where(x => x.CondicionVuelo == "E");
        }

        // GET: api/VuelosEntrantes/5
        [ResponseType(typeof(tblVuelos))]
        public IHttpActionResult GettblVuelos(int id)
        {
            tblVuelos tblVuelos = db.tblVuelos.Find(id);
            if (tblVuelos == null)
            {
                return NotFound();
            }

            return Ok(tblVuelos);
        }

        // PUT: api/VuelosEntrantes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblVuelos(int id, tblVuelos tblVuelos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblVuelos.id)
            {
                return BadRequest();
            }

            db.Entry(tblVuelos).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblVuelosExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/VuelosEntrantes
        [ResponseType(typeof(tblVuelos))]
        public IHttpActionResult PosttblVuelos(tblVuelos tblVuelos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblVuelos.Add(tblVuelos);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblVuelos.id }, tblVuelos);
        }

        // DELETE: api/VuelosEntrantes/5
        [ResponseType(typeof(tblVuelos))]
        public IHttpActionResult DeletetblVuelos(int id)
        {
            tblVuelos tblVuelos = db.tblVuelos.Find(id);
            if (tblVuelos == null)
            {
                return NotFound();
            }

            db.tblVuelos.Remove(tblVuelos);
            db.SaveChanges();

            return Ok(tblVuelos);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblVuelosExists(int id)
        {
            return db.tblVuelos.Count(e => e.id == id) > 0;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AdmonVuelos.Models;

namespace AdmonVuelos.Controllers
{
    public class VuelosSalientesController : Controller
    {
        private VuelosEntities db = new VuelosEntities();

        // GET: Vuelos
        public ActionResult Index()
        {
            var tblVuelos = db.tblVuelos.Include(t => t.tblAerolineas).Include(t => t.tblCiudades).Include(t => t.tblCiudades1).Include(t => t.tblEstadoVuelo).Include(t => t.tblNumeroVuelo).Where(E => E.CondicionVuelo=="S");
            return View(tblVuelos.ToList());
        }

        // GET: Vuelos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblVuelos tblVuelos = db.tblVuelos.Find(id);
            if (tblVuelos == null)
            {
                return HttpNotFound();
            }
            return View(tblVuelos);
        }

        // GET: Vuelos/Create
        public ActionResult Create()
        {
            ViewBag.AerolineaId = new SelectList(db.tblAerolineas, "id", "Aerolinea");
            ViewBag.CiudadOrigenId = new SelectList(db.tblCiudades, "id", "Ciudad");
            ViewBag.CiudadDestinoId = new SelectList(db.tblCiudades, "id", "Ciudad");
            ViewBag.EstadoId = new SelectList(db.tblEstadoVuelo, "id", "EstadoVuelo");
            ViewBag.NroVueloId = new SelectList(db.tblNumeroVuelo, "id", "id");
            return View();
        }

        // POST: Vuelos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,CiudadOrigenId,CiudadDestinoId,Fecha,HoraSalida,Horallegada,NroVueloId,AerolineaId,EstadoId,CondicionVuelo")] tblVuelos tblVuelos)
        {
            if (ModelState.IsValid)
            {
                db.tblVuelos.Add(tblVuelos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AerolineaId = new SelectList(db.tblAerolineas, "id", "Aerolinea", tblVuelos.AerolineaId);
            ViewBag.CiudadOrigenId = new SelectList(db.tblCiudades, "id", "Ciudad", tblVuelos.CiudadOrigenId);
            ViewBag.CiudadDestinoId = new SelectList(db.tblCiudades, "id", "Ciudad", tblVuelos.CiudadDestinoId);
            ViewBag.EstadoId = new SelectList(db.tblEstadoVuelo, "id", "EstadoVuelo", tblVuelos.EstadoId);
            ViewBag.NroVueloId = new SelectList(db.tblNumeroVuelo, "id", "id", tblVuelos.NroVueloId);
            return View(tblVuelos);
        }

        // GET: Vuelos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblVuelos tblVuelos = db.tblVuelos.Find(id);
            if (tblVuelos == null)
            {
                return HttpNotFound();
            }
            ViewBag.AerolineaId = new SelectList(db.tblAerolineas, "id", "Aerolinea", tblVuelos.AerolineaId);
            ViewBag.CiudadOrigenId = new SelectList(db.tblCiudades, "id", "Ciudad", tblVuelos.CiudadOrigenId);
            ViewBag.CiudadDestinoId = new SelectList(db.tblCiudades, "id", "Ciudad", tblVuelos.CiudadDestinoId);
            ViewBag.EstadoId = new SelectList(db.tblEstadoVuelo, "id", "EstadoVuelo", tblVuelos.EstadoId);
            ViewBag.NroVueloId = new SelectList(db.tblNumeroVuelo, "id", "id", tblVuelos.NroVueloId);
            return View(tblVuelos);
        }

        // POST: Vuelos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,CiudadOrigenId,CiudadDestinoId,Fecha,HoraSalida,Horallegada,NroVueloId,AerolineaId,EstadoId,CondicionVuelo")] tblVuelos tblVuelos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblVuelos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AerolineaId = new SelectList(db.tblAerolineas, "id", "Aerolinea", tblVuelos.AerolineaId);
            ViewBag.CiudadOrigenId = new SelectList(db.tblCiudades, "id", "Ciudad", tblVuelos.CiudadOrigenId);
            ViewBag.CiudadDestinoId = new SelectList(db.tblCiudades, "id", "Ciudad", tblVuelos.CiudadDestinoId);
            ViewBag.EstadoId = new SelectList(db.tblEstadoVuelo, "id", "EstadoVuelo", tblVuelos.EstadoId);
            ViewBag.NroVueloId = new SelectList(db.tblNumeroVuelo, "id", "id", tblVuelos.NroVueloId);
            return View(tblVuelos);
        }

        // GET: Vuelos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblVuelos tblVuelos = db.tblVuelos.Find(id);
            if (tblVuelos == null)
            {
                return HttpNotFound();
            }
            return View(tblVuelos);
        }

        // POST: Vuelos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblVuelos tblVuelos = db.tblVuelos.Find(id);
            db.tblVuelos.Remove(tblVuelos);
            db.SaveChanges();
            return RedirectToAction("Index");
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

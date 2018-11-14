using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Net.Http.Headers;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using AdmonVuelos.Models;

namespace AdmonVuelos.Controllers
{
    public class VuelosEntrantesController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var httpClient = new HttpClient();
            var vuelosentrantes = await httpClient.GetStringAsync("http://localhost:55102//api/vuelosentrantes");
            var vuelosentrantesList = JsonConvert.DeserializeObject<List<tblVuelos>>(vuelosentrantes);
            return View(vuelosentrantesList);
        }

        // GET: VuelosEntrantes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VuelosEntrantes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VuelosEntrantes/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: VuelosEntrantes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VuelosEntrantes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: VuelosEntrantes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VuelosEntrantes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

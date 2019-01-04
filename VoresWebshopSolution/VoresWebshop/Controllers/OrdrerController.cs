using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VoresWebshop.Models;

namespace VoresWebshop.Controllers
{
    public class OrdrerController : Controller
    {
        private VoresWebshopDb _context = new VoresWebshopDb();

        // GET: Ordrer
        public ActionResult Index()
        {
            var ordrer = new List<Ordre>();
            ordrer = _context.Ordrer.ToList();
            return View("Index", ordrer);
        }

        //[HttpGet]
        //public ActionResult Kurv() {
        //    return RedirectToAction("Kurv", new { id = 1 });
        //    //return HttpNotFound();
        //}

        [HttpGet]
        public ActionResult Kurv(int? id) {
            if (id == null)
                id = 1;

            Ordre ordre = _context.Ordrer.Find(id);
            return View("Kurv", ordre.OrdreLinier.ToList());
        }


    }
}
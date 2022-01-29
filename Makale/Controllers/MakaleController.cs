using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Makale.Models.Siniflar;

namespace Makale.Controllers
{
    public class MakaleController : Controller
    {
        // GET: Makale
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Makales.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult MakaleEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MakaleEkle( MakaleData k)
        {
            c.Makales.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult MakaleSil(int id)
        {
            var mkl = c.Makales.Find(id);
            c.Makales.Remove(mkl);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult MakaleGüncelle(int id)
        {
            var makale = c.Makales.Find(id);
            return View("MakaleGüncelle",makale);
        }
        public ActionResult MakaleGüncelleKaydet( MakaleData k)
        {
            var mkle = c.Makales.Find(k.MakaleID);
            mkle.MakaleAd = k.MakaleAd;
            mkle.MakaleTür = k.MakaleTür;
            mkle.MakaleText = k.MakaleText;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
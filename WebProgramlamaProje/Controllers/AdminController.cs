using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProgramlamaProje.Models.Classes;

namespace WebProgramlamaProje.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context ctx = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var deger = ctx.Anasayfalar.ToList();
            return View(deger);
        }
        public ActionResult Guncelle(int id)
        {
            var gnclle = ctx.Anasayfalar.Find(id);
            return View("Guncelle", gnclle);
        }

        public ActionResult PostGuncelle(Anasayfa value)
        {
            var post = ctx.Anasayfalar.Find(value.id);
            post.postBaslik = value.postBaslik;
            post.postIcerik = value.postIcerik;
            post.postResim = value.postResim;
            post.postTarih = value.postTarih;
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult YeniPost()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniPost(Anasayfa value)
        {
            ctx.Anasayfalar.Add(value);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult PostSil(int id)
        {
            var sil = ctx.Anasayfalar.Find(id);
            ctx.Anasayfalar.Remove(sil);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
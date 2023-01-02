using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProgramlamaProje.Models.Classes;

namespace WebProgramlamaProje.Controllers
{
    public class AnasayfaController : Controller
    {
        // GET: Anasayfa
        Context ctx = new Context();
        public ActionResult Index()
        {
            dynamic dy = new ExpandoObject();
            dy.anasayfalist = getAnasayfa();
            dy.kullanicilist = getKullanici();
            dy.yorumlist = getYorum();
            return View(dy);
        }

        public List<Anasayfas> getAnasayfa()
        {
            WebProgramlamaProjeDBEntities sample = new WebProgramlamaProjeDBEntities();
            List<Anasayfas> lsAnasayfa = sample.Anasayfas.ToList();
            return lsAnasayfa;
        }
        public List<Yorums> getYorum()
        {
            WebProgramlamaProjeDBEntities sample = new WebProgramlamaProjeDBEntities();
            List<Yorums> lsYorum = sample.Yorums.ToList();
            return lsYorum;
        }
        public List<Kullanicis> getKullanici()
        {
            WebProgramlamaProjeDBEntities sample = new WebProgramlamaProjeDBEntities();
            List<Kullanicis> lsKullanici = sample.Kullanicis.ToList();
            return lsKullanici;
        }
    }
}
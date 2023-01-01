using System;
using System.Collections.Generic;
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
            var deger = ctx.Anasayfalar.ToList();
            return View(deger);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProgramlamaProje.Models.Classes;

namespace WebProgramlamaProje.Controllers
{
    public class YorumController : Controller
    {
        // GET: Yorum
        Context ctx = new Context();
        public ActionResult Index()
        {
            var deger = ctx.Yorumlar.ToList();
            return View(deger);
        }
    }
}
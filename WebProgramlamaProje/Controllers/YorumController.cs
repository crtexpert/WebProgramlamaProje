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

       
        [HttpPost]
        public ActionResult YorumAt(string yorumText,int postid)
        {
            int userID = Convert.ToInt32(Session["Id"]);
            if(userID == 0)
            {
                return RedirectToAction("Giris", "Hesap");
            }
            Yorum yrm = new Yorum();
            yrm.Mesaj = yorumText;
            yrm.UserID = userID;
            yrm.PostID = postid;
            ctx.Yorumlar.Add(yrm);
            ctx.SaveChanges();
            return RedirectToAction("Index", "Anasayfa");
        }
    }
}
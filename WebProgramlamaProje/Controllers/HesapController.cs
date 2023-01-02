using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebProgramlamaProje.Models.Classes;

namespace WebProgramlamaProje.Controllers
{
    public class HesapController : Controller
    {
        // GET: Hesap
        public ActionResult Index()
        {
            using(Context ctx = new Context())
            {
                return View(ctx.Kullanicilar.ToList());
            }
        }

        public ActionResult Uyelik()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Uyelik(Kullanici value)
        {
            if(ModelState.IsValid)
            {
                using (Context ctx = new Context())
                {
                    ctx.Kullanicilar.Add(value);
                    ctx.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = value.FirstName + " " + value.LastName + " Başarılı şekilde kayıt oldu.";
            }
            return View();
        }

        public ActionResult Giris()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Giris(Kullanici value)
        {
            using(Context ctx = new Context())
            {
                var info = ctx.Kullanicilar.FirstOrDefault(x => x.KullaniciAdi == value.KullaniciAdi && x.Password == value.Password);

                if (info != null)
                {
                    FormsAuthentication.SetAuthCookie(info.KullaniciAdi, false);
                    Session["Id"] = info.Id.ToString();
                    Session["KullaniciAdi"] = info.KullaniciAdi.ToString();
                    return RedirectToAction("GirisYapildi");
                }
                else
                {
                    ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı.");
                    return View();
                }

            }
            return View();
        }

        public ActionResult GirisYapildi()
        {
            if(Session["Id"] != null)
            {
                return Redirect("../Anasayfa/Index");
            }
            else
            {
                return RedirectToAction("Giris"); 
            }
        }

        public ActionResult Cikis()
        {
            FormsAuthentication.SignOut();
            Session.Clear();
            Session.RemoveAll();
            Session.Abandon();
            return RedirectToAction("Index", "Anasayfa");
        }
    }
}
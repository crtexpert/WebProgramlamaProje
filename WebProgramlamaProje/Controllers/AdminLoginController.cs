using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Windows.Forms;
using WebProgramlamaProje.Models.Classes;

namespace WebProgramlamaProje.Controllers
{
    public class AdminLoginController : Controller
    {
        // GET: AdminLogin
        Context ctx = new Context();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin value)
        {
            var info = ctx.Admins.FirstOrDefault(x => x.kullaniciAdi == value.kullaniciAdi && x.sifre == value.sifre);

            if(info != null)
            {
                FormsAuthentication.SetAuthCookie(info.kullaniciAdi, false);
                Session["kullaniciAdi"] = info.kullaniciAdi.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }

        }

        public ActionResult Cikis()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "AdminLogin");
        }
    }
}
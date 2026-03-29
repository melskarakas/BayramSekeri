using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BayramSekeri.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult RegisterLogin()
        {
            ArrayList register = new ArrayList();
            register.Add("Isim");
            register.Add("Şifre");
            register.Add("ŞifreOnay");
            register.Add("dsfasdf");

            return View(register);
        }
    }
}
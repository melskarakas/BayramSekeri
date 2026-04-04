using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BayramSekeri.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            string[] isim = new string
            {
                "aposdaşd","apsodmadms","asmdlamdas"
            }

            //Naber(Alperen)
            return View(isim);
        }
    }
}
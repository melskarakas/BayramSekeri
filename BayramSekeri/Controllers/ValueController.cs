using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BayramSekeri.Controllers
{
    public class ValueController : Controller
    {
        // GET: Value
        public ActionResult Index()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movietoon.Controllers
{
    public class PopularController : Controller
    {
        // GET: Popular
        public ActionResult Index()
        {
            return View();
        }
    }
}
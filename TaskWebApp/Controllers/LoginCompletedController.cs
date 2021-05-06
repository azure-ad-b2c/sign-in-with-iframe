using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TaskWebApp.Controllers
{
    public class LoginCompletedController : Controller
    {


        [HttpGet]
        public ActionResult Index()
        {
            // your code
            return View();
        }

    }
}
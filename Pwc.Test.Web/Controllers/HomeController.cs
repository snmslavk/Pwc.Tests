using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pwc.Test.Lib;
using Pwc.Test.Lib.Models;

namespace Pwc.Test.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(
                new CoreFuncs().GetIndexModel()
                );
        }

        [HttpGet]
        public ActionResult ReloadModel()
        {
            return Json(
                new CoreFuncs().GetIndexModel(),
                JsonRequestBehavior.AllowGet
                );
        }

        [HttpPost]
        public string PostData(KisaErdModel model)
        {
            return new CoreFuncs().PostData(model);
        }

    }
}
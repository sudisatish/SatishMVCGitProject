using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace SatishMVCGitProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var mvcName = typeof(Controller).Assembly.GetName();
            var isMono = Type.GetType("Mono.Runtime") != null;

            ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
            ViewData["Runtime"] = isMono ? "Mono" : ".NET";
<<<<<<< HEAD
            ViewData["Author"] = Environment.UserName;

=======
            ViewData["Author"] = Environment.UserDomainName + "/" + Environment.UserName;
>>>>>>> 3f5737d... Added author to view data
            return View();
        }
    }
}

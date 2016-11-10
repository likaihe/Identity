using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Identity.Controllers
{
    public class RoleController : Controller
    {
        // GET: Role
        public ActionResult Index()
        {
            if (User.IsInRole("Manager"))
            {
                return View("Manager");
            }
            else { return View("NomalUser");
            }
        }
        
        public ActionResult NomalUser()
        {
            return View();
        }

        public ActionResult Manager()
        {
            return View();
        }
    }
}
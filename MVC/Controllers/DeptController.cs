using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace MVC.Controllers
{
    public class DeptController : Controller
    {
        // GET: Dept
        public ActionResult Dept()
        {

            Empcontext empContext = new Empcontext();
            List<Dept> Dept = empContext.Dept.ToList();
            return View(Dept);

        }
    }
}
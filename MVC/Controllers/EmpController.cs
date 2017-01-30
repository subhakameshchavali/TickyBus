using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;
namespace MVC.Controllers
{
    public class EmpController : Controller
    {
        
        public ActionResult Index(int id)
        {

            Empcontext empContext = new Empcontext();
            List<Emp> Emp = empContext.Emp.Where(emp => emp.DeptId == id).ToList();
            return View(Emp);
        }
        // GET: Emp
        public ActionResult Details(int id)
        {

            Empcontext empContext = new Empcontext();
            Emp Emp = empContext.Emp.Single(emp => emp.id == id);
            return View(Emp);
        }
    }
}
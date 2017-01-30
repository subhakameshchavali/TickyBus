using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;
namespace MVC.Controllers
{
    public class EmployeeRegController : Controller
    {
        // GET: EmployeeReg
        public ActionResult Index()
        {

            EmployeeBusinessLyr EmployeeBusinessLyr = new EmployeeBusinessLyr();
            List<Employee> employees = EmployeeBusinessLyr.Employee.ToList();
            return View(employees);

        }
        [HttpGet]
        [ActionName("Create")]
        public ActionResult Create_get()
        {

            return View();

        }

         [HttpPost]
         [ActionName("Create")]
        public ActionResult Create_post() //Or we can use  FormCollections now we have used Model Binders we are haveing 2 way's to bind Data
        {

            Employee employee = new Employee();
            TryUpdateModel(employee);    //update model with we will get all the HTTP req data cookies server varibles data so simply we can send data to model 
            if (ModelState.IsValid)
            {
                

                EmployeeBusinessLyr empinfo = new EmployeeBusinessLyr();
                empinfo.AddEmployee(employee);
                return RedirectToAction("Index");

                  }
            return View();
              }
        [HttpGet]
        [ActionName("Edit")]
        public ActionResult Edit_get(int Id)
        {

             EmployeeBusinessLyr employeeBusinessLyr = new EmployeeBusinessLyr();

             Employee employee =  employeeBusinessLyr.Employee.Single(emp => emp.ID == Id);

             return View(employee);
             
        }

        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit_post(int Id)
        {

            Employee employee = new Employee();
            TryUpdateModel(employee);    //update model with we will get all the HTTP req data cookies server varibles data so simply we can send data to model 
            if (ModelState.IsValid)
            {


                EmployeeBusinessLyr empinfo = new EmployeeBusinessLyr();
                empinfo.SaveEmployee(employee);
                return RedirectToAction("Index");

            }
            return View();
        }


        public ActionResult Delete(int id)
        {


            EmployeeBusinessLyr empinfo = new EmployeeBusinessLyr();
            empinfo.DeleteEmployee(id);
            return RedirectToAction("Index");


        }

    }

    }
     
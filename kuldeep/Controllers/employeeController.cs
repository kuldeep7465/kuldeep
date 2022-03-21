using kuldeep.db_content;
using kuldeep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace kuldeep.Controllers
{
    public class employeeController : Controller
    {



      
        // GET: employee
        public ActionResult Index()
        {


            kuldeepEntities obj = new kuldeepEntities();
            var res = obj.my_table.ToList();
            return View(res);
        }
        public ActionResult kuldeep(Class1 obj2)
        {
            kuldeepEntities obj = new kuldeepEntities();
            my_table obj3 = new my_table();
            obj3.name = obj2.name;
            obj3.email = obj2.email;
            obj.my_table.Add(obj3);
            obj.SaveChanges();
            return View();
        }
        public ActionResult delete(int id)
        {


            kuldeepEntities obj = new kuldeepEntities();
            var delete = obj.my_table.Where(m => m.id == id).First();
            obj.my_table.Remove(delete);
            obj.SaveChanges();

            return RedirectToAction("index");
        }
        public ActionResult edit(int id)
        {


            kuldeepEntities obj = new kuldeepEntities();
            my_table obj3 = new my_table();
            var edit= obj.my_table.Where(m => m.id == id).First();
            obj3.name = edit.name;
            obj3.email = edit.email;
            obj.SaveChanges();

            return RedirectToAction("kuldeep",obj3);
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using AjaxJsonResponse.Data;
using AjaxJsonResponse.Models;
using Microsoft.AspNetCore.Mvc;

namespace AjaxJsonResponse.Controllers
{
    public class StudentController : Microsoft.AspNetCore.Mvc.Controller
    {
        ApplicationDbContext context;

        public StudentController(ApplicationDbContext _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Microsoft.AspNetCore.Mvc.HttpPost]
        public Microsoft.AspNetCore.Mvc.ActionResult createStudent(Student std)
        {
           
            context.Students.Add(std);
            context.SaveChanges();
            string message = "SUCCESS";
            return Json(new { Message = message, JsonRequestBehavior.AllowGet });
        }
        [Microsoft.AspNetCore.Mvc.HttpPost]
        public Microsoft.AspNetCore.Mvc.JsonResult getStudent(string id)
        {
            List<Student> students = new List<Student>();
            students = context.Students.ToList();
            return Json(students);
        }
    }
}

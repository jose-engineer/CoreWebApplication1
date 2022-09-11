using CoreWebApp1.Application;
using CoreWebApp1.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApp1.Presentation.Controllers
{
    public class EntityController : Controller
    {
        private readonly IStudentService service;

        public EntityController(IStudentService service)
        {
            this.service = service;
        }
        // GET: EntityController
        public ActionResult Index()
        {
            var model = service.GetStudents();
            return View(model);
        }

        // GET: EntityController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EntityController/Create
        public ActionResult Create()
        {
            ViewBag.GenderId = new SelectList(service.Gender, "Id", "Sex");
            ViewBag.NationalityId = new SelectList(service.Nationality, "Id", "Country");      

            return View();
        }

        // POST: EntityController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student student)
        {
            try
            {
                service.AddStudent(student);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return Content("Fallo todo ALV");
            }
        }

        // GET: EntityController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.GenderId = new SelectList(service.Gender, "Id", "Sex");
            ViewBag.NationalityId = new SelectList(service.Nationality, "Id", "Country");
            
            Student model = service.GetStudent(id);

            return View(model);
        }

        // POST: EntityController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Student student)
        {
            try
            {
                service.EditStudent(student);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EntityController/Delete/5
        public ActionResult Delete(int id)
        {
            Student model = service.GetStudent(id);
            return View(model);
        }

        // POST: EntityController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Student student)
        {
            try
            {
                var model = service.RemoveStudent(student.StudentId);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

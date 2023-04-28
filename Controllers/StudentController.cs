using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EfCore.Interfaces;
using EfCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EfCore.Controllers
{
    public class StudentController : Controller
    {
        private readonly ILogger<StudentController> _logger;
        private readonly IStudentRepository _repo;

        public StudentController(ILogger<StudentController> logger, IStudentRepository repo)
        {
            _logger = logger;
            _repo = repo;
        }

        public IActionResult Index()
        {
            var students = _repo.GetAll();
            return View(students);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Student student)
        {
            _repo.Add(student);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            var student = _repo.Get(id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Update(Student student)
        {
            _repo.Update(student);
            return RedirectToAction("Index");
        }

         public IActionResult Get(int id)
        {
            var student = _repo.Get(id);
            return View(student);
        }

        public IActionResult Delete(int id)
        {
            _repo.Delete(id);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
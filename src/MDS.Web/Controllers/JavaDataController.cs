using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MDS.Web.Services;
using MDS.Web.ViewModels;
using MDS.Web.Entities;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MDS.Web.Controllers
{
    public class JavaDataController : Controller
    {
        private IJavaData _java;
        private ITestService _testService;

        public JavaDataController(IJavaData iJavaData, ITestService testService)
        {
            _java = iJavaData;
            _testService = testService;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = new JavaViewModel();
            model.Javas = _java.GetAll();
            model.CurrentVersion = _testService.Test();
            return View(model);
        }

        public string DisplayInputInt(int id = 3333)
        {
            return id.ToString();
        }

        public IActionResult Details(int id)
        {
            var model = _java.Get(id);
            if(model == null)
            {
                //return HttpNotFound();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(JavaEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var java = new Java();
                java.Name = model.Name;
                java.Type = model.Type;
                _java.Add(java);
                return RedirectToAction("Details", new { id = java.Id });
            } else
            {
                return View();
            }
        }
    }
}

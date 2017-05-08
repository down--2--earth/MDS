using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MDS.Web.Services;
using MDS.Web.ViewModels;

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
    }
}

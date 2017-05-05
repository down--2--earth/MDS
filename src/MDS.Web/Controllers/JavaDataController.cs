using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MDS.Web.Services;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MDS.Web.Controllers
{
    public class JavaDataController : Controller
    {
        private IJavaData _java;

        public JavaDataController(IJavaData iJavaData)
        {
            _java = iJavaData;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(_java.GetAll());
        }
    }
}

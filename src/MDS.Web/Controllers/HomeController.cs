using MDS.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MDS.Web.Controllers
{
    public class HomeController : Controller
    {
        public ContentResult Index()
        {
            return Content("HomeController");
        }

        public ObjectResult GetObjectResult()
        {
            var java = new Java { Id = 8, Name = "Java" };
            return new ObjectResult(java);
        }

        public ViewResult TestView() {
            var java = new Java { Id = 8, Name = "Java" };
            return View(java);
        }


    }
}

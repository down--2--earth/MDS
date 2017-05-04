using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MDS.Web.Controllers
{
    //[Route("About")]
    //[Route("abc/[controller]/[action]")]
    [Route("abc/[controller]")]
    public class AboutController
    {
        // GET: /<controller>/
        [Route("")]
        public string Phone()
        {
            return "1-555-555-555";
        }

        [Route("country")]
        //[Route("action")]
        public string Country()
        {
            return "SL";
        }
    }
}

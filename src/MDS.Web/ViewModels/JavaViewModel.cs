using MDS.Web.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MDS.Web.ViewModels
{
    public class JavaViewModel
    {
        public IEnumerable<Java> Javas { get; set; }
        public string CurrentVersion { get; set; }
    }
}

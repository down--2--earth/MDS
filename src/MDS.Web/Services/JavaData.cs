using MDS.Web.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MDS.Web.Services
{
    public interface IJavaData
    {
        IEnumerable<Java> GetAll();
    }

    public class JavaData : IJavaData
    {
        public JavaData()
        {
            _java = new List<Java>
            {
                new Java { Id = 3, Name = "Java 3" },
                new Java { Id = 4, Name = "Java 4" }
            };
        }

        List<Java> _java;

        public IEnumerable<Java> GetAll()
        {
            return _java;
        }
    }
}

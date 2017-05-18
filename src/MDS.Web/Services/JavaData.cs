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
        Java Get(int id);
        void Add(Java java);
    }

    public class JavaData : IJavaData
    {
        static JavaData()
        {
            _java = new List<Java>
            {
                new Java { Id = 3, Name = "Java 3" },
                new Java { Id = 4, Name = "Java 4" }
            };
        }

        static List<Java> _java;

        public IEnumerable<Java> GetAll()
        {
            return _java;
        }

        public Java Get(int id)
        {
            var x = _java.FirstOrDefault(j => j.Id == id);
            return x;
        }

        public void Add(Java java)
        {
            java.Id = _java.Max(r => r.Id) + 1;
            _java.Add(java);
        }
    }
}

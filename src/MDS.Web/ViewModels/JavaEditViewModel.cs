using MDS.Web.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MDS.Web.ViewModels
{
    public class JavaEditViewModel
    {
        [Required, MaxLength(5)]
        public string Name { get; set; }
        public JavaType Type { get; set; }
    }
}

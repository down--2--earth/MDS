using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MDS.Web.Entities
{

    public enum JavaType
    {
        None,
        Mob,
        Std,
        Ent
    }
    public class Java
    {
        public int Id { get; set; }

        [Required, MaxLength(5)]
        [Display(Name = "Java Edition Name")]
        public string Name { get; set; }
        public JavaType Type { get; set; }
    }
}

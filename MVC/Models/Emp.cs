using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    [Table("emp")]
    public class Emp
    {

        public int id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public int DeptId { get; set;}


    }
}
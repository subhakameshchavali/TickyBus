using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;   
namespace MVC.Models
{

    [Table("Dept")]
    public class Dept
    {

        public int id { get; set; }
        public string department { get; set; }
        public List<Emp> Employee { get; set; }
}
}
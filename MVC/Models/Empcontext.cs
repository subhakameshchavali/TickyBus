using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Empcontext : DbContext
    {

        public DbSet<Emp> Emp { get; set; }
        public DbSet<Dept> Dept { get; set; }


    }
}
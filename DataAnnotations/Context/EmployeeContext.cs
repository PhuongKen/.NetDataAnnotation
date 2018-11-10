using DataAnnotations.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DataAnnotations.Context
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }
    }
}
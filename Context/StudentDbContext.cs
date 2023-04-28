using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EfCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCore.Context
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
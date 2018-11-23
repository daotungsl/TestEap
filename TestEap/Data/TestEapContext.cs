using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestEap.Controllers;

namespace TestEap.Models
{
    public class TestEapContext : DbContext
    {
        public TestEapContext (DbContextOptions<TestEapContext> options)
            : base(options)
        {
        }

        public DbSet<TestEap.Controllers.Employee> Employee { get; set; }
    }
}

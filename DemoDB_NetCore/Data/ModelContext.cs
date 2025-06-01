using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDB_NetCore.Data
{
    public class ModelContext : DbContext
    {

        public DbSet<Employee> EmployeeList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=netcoreDemoDB;Trusted_Connection=True;Encrypt=False");
        }
    }
}

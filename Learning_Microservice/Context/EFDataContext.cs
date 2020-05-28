using Learning_Microservice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Microservice.Context
{
    public class EFDataContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=charlestest123.database.windows.net; initial catalog=test123;persist security info=True;user id=ac49189;password=System@123ctli;");
        }
    }
}

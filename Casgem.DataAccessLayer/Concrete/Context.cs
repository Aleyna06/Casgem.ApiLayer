using Casgem.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem.DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-4FNRCPJ\\SQLEXPRESS;initial catalog=CasgemApiDb;integrated security=true;");
        }
        public DbSet<Customer> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Category> Customers { get; set; }
    }
}

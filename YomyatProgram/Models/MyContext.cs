using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YomyatProgram.Models
{
    internal class MyContext :DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Agency> Agencies { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Receipt> Receipts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conStr = ConfigurationManager.ConnectionStrings["myDB"].ToString();
            optionsBuilder.UseSqlServer(conStr);
          //  optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=yomyat;Integrated Security=True;");
        }
    }
}

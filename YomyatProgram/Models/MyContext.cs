using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace YomyatProgram.Models
{
    class MyContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Agency> Agencies { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=yomyatDB.db", options =>
            {
                options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Map table names
            modelBuilder.Entity<Blog>().ToTable("Blogs", "yomyat");
            modelBuilder.Entity<Blog>(entity =>
            {
                entity.HasKey(e => e.BlogId);
                entity.HasIndex(e => e.Title).IsUnique();
                entity.Property(e => e.DateTimeAdd).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}

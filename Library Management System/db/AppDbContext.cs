using Library_Management_System.Model;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;


namespace Library_Management_System.db
{
    internal class AppDbContext: DbContext
    {
        public DbSet<Member> Members { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;database=Library_Managemnt_System;user=root;password=mysql1234",
                new MySqlServerVersion(new Version(8, 0, 27))  
            );


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>()
                .HasKey(m => m.Id); // Specify the primary key if needed

            
        }
    }
}

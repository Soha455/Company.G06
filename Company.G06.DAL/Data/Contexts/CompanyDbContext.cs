using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Company.G06.DAL.Modules;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Company.G06.DAL.Data.Contexts
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext(DbContextOptions<CompanyDbContext> options) : base() 
        {
                
        }

        //Apply Congiguration Classes
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }


        //Set Connection string of DB
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(" Server =. ; Database = CompanyG06 ; Trust_Connection =True ; TrustServerCertificate = True  ");
        //}
        /// <summary>
        /// / in PL main program 
        /// </summary>

        //Mapping Entites to tables in DB 
        public DbSet<Department> Departments { get; set; }
        
    }
}

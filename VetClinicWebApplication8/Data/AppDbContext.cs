using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VetClinicWebApplication8.Models;
using VetClinicWebApplication8.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace VetClinicWebApplication8.Data
{
    public class AppDbContext : IdentityDbContext<Users>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
      

        public DbSet<Owner_Pet> Owners { get; set; }
  
    }
}
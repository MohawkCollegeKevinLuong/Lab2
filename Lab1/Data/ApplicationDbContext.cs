using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Lab1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lab1.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Team> Teams {
            get;
            set; 
        
        }

        public void AddTeams()
        {

        }




        
       
    }
}

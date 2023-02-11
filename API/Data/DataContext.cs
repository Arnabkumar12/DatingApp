using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext   //It will act as a service because we will inject in other classes.
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
       public DbSet<AppUser> Users { get; set; }
        
    }
}
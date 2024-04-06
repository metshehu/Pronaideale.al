using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDBContext : DbContext
    {
    public ApplicationDBContext(DbContextOptions dbContextOptions)
    :base(dbContextOptions)
    {
        
    }
    public DbSet<Users> Users{get; set;}
    public DbSet<Propertys> Propertys{get; set;}

    public DbSet<test> test{get; set;}
    
    }
}
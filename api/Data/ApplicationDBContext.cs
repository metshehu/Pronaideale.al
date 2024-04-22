using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDBContext : IdentityDbContext<AppUser>
    {
    public ApplicationDBContext(DbContextOptions dbContextOptions)
    :base(dbContextOptions)
    {
    }
    public DbSet<Propertys> Propertys{get; set;}

    public DbSet<Agends> Agends{get; set;}
     
    public DbSet<Companys> Companys{get; set;}
    public DbSet<UsersAgends> UsersAgends{get; set;}
    public DbSet<AgendsPropertys> MyProperty { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<UsersAgends>(x=> x.HasKey(p=> new {p.AppUsersId,p.AgendsId}));

            builder.Entity<UsersAgends>()
                .HasOne(u => u.AppUser)
                .WithMany(u => u.Agends)
                .HasForeignKey(p => p.AppUsersId);
            builder.Entity<UsersAgends>()
                .HasOne(u => u.Agends)
                .WithMany(u => u.AppUsers)
                .HasForeignKey(p => p.AgendsId);

            builder.Entity<AgendsPropertys>(x=> x.HasKey(p=> new {p.AgendId,p.Propertyid}));

            builder.Entity<AgendsPropertys>()
                .HasOne(u => u.Agends)
                .WithMany(u => u.Propertys)
                .HasForeignKey(p => p.AgendId);

            builder.Entity<AgendsPropertys>()
                .HasOne(u => u.Propertys)
                .WithMany(u => u.Agends)
                .HasForeignKey(p => p.Propertyid);


         
             List<IdentityRole> roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Name = "User",
                    NormalizedName = "USER"
                },
            };
            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}
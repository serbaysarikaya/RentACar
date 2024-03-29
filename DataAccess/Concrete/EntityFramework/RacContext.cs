﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{//Data access baslangıç noktası Burası.
    public class RacContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=RentACar;Trusted_Connection=True;");
            //optionsBuilder.UseSqlServer(@"Server=DESKTOP-UTMJ6C8\SQLEXPRESS;Database=RentACar;Trusted_Connection=True;");
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarDetail> CarDetails { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
    }
}

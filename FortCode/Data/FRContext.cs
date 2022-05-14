using FortCode.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FortCode.Data
{
    public class FRContext : IdentityDbContext<UserModel>
    {
        public FRContext(DbContextOptions<FRContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FavoriteUserCityModel>().HasKey(usercity => new { usercity.Id, usercity.IdCity });

            modelBuilder.Entity<FavoriteUserCityModel>()
                .HasOne<UserModel>(usercity => usercity.UserModel)
                .WithMany(user => user.favoriteUserCities)
                .HasForeignKey(usercity => usercity.Id);


            modelBuilder.Entity<FavoriteUserCityModel>()
                .HasOne<CityModel>(usercity => usercity.CityModel)
                .WithMany(city => city.favoriteUserCities)
                .HasForeignKey(usercity => usercity.IdCity);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<CityModel> CityModel { get; set; }
        public DbSet<FavoriteUserCityModel> FavoriteUserCities { get; set; }
    }
}

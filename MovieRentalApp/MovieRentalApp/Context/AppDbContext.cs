using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieRentalApp.Configuration;
using MovieRentalApp.Models;

namespace MovieRentalApp.Context
{
    public class AppDbContext:IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> context):base(context)
        {
            
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
            builder.Entity<User>().HasIndex(b=>b.userId).IsUnique();
           // builder.Entity<Register>().HasNoKey();
        }



        public DbSet<User> users { get; set; }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Bookiing> bookiings { get; set; }
        public DbSet<MovieRentalApp.Models.LoginModel>? LoginModel { get; set; }
        public DbSet<MovieRentalApp.Models.Register>? Register { get; set; }
        
    }
}

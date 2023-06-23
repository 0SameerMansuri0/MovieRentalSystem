using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace MovieRentalApp.Configuration
{
    internal class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "eec94afe - 1fb4 - 4666 - 92df - 6ea1a5256d8b",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                },
                 new IdentityRole
                 {
                     Id = "eec94abfe - 1fb4 - 4332 - 92df - 6ea1a5256d8b",
                     Name = "User",
                     NormalizedName = "USER"
                 }
                );
        }
    }
}

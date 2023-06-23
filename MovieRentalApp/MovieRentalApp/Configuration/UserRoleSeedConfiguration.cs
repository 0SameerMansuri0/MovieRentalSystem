using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace MovieRentalApp.Configuration
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "eec94afe - 1fb4 - 4666 - 92df - 6ea1a5256d8b",
                    UserId = "ebc94afe - 1fb4 - 4666 - 91df - 6ea1a5256d7b"

                }
                );
        }
    }
}

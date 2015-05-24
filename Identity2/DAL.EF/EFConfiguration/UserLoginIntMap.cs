using System.Data.Entity.ModelConfiguration;
using Domain.IdentityModels;

namespace DAL.EF.EFConfiguration
{
    public class UserLoginIntMap : EntityTypeConfiguration<UserLoginInt>
    {
        public UserLoginIntMap()
        {
            // Primary Key
            HasKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId });

            // Properties
            Property(t => t.LoginProvider)
                .IsRequired()
                .HasMaxLength(128);

            Property(t => t.ProviderKey)
                .IsRequired()
                .HasMaxLength(128);

            Property(t => t.UserId)
                .IsRequired();

        }
    }
}
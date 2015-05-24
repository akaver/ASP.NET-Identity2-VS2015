using System.Data.Entity.ModelConfiguration;
using Domain.IdentityModels;

namespace DAL.EF.EFConfiguration
{
    public class UserClaimMap : EntityTypeConfiguration<UserClaim>
    {
        public UserClaimMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.UserId)
                .IsRequired()
                .HasMaxLength(128);
        }
    }
}

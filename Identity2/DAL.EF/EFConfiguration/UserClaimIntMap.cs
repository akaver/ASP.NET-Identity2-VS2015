using System.Data.Entity.ModelConfiguration;
using Domain.IdentityModels;

namespace DAL.EF.EFConfiguration
{
    public class UserClaimIntMap : EntityTypeConfiguration<UserClaimInt>
    {
        public UserClaimIntMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.UserId)
                .IsRequired();
        }
    }
}
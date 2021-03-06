using System.Data.Entity.ModelConfiguration;
using Domain.IdentityModels;

namespace DAL.WebApi.EFConfiguration
{
    public class UserRoleMap : EntityTypeConfiguration<UserRole>
    {
        public UserRoleMap()
        {
            // Primary Key
            HasKey(t => new { t.UserId, t.RoleId });

        }
    }
}

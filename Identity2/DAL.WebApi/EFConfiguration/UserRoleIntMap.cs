using System.Data.Entity.ModelConfiguration;
using Domain.IdentityModels;

namespace DAL.WebApi.EFConfiguration
{
    public class UserRoleIntMap : EntityTypeConfiguration<UserRoleInt>
    {
        public UserRoleIntMap()
        {
            // Primary Key
            HasKey(t => new { t.UserId, t.RoleId });

        }
    }
}
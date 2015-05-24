using DAL.EF.Interfaces;
using Domain.IdentityModels;

namespace DAL.EF.Repositories
{
    public class UserRoleIntRepository : UserRoleRepository<int, RoleInt, UserInt, UserClaimInt, UserLoginInt, UserRoleInt>, IUserRoleIntRepository
    {
        public UserRoleIntRepository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}
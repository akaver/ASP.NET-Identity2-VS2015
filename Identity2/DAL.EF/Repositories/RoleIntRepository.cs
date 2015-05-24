using DAL.EF.Interfaces;
using Domain.IdentityModels;

namespace DAL.EF.Repositories
{
    public class RoleIntRepository : RoleRepository<int, RoleInt, UserInt, UserClaimInt, UserLoginInt, UserRoleInt>, IRoleIntRepository
    {
        public RoleIntRepository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}
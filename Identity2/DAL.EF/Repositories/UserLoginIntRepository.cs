using DAL.EF.Interfaces;
using Domain.IdentityModels;

namespace DAL.EF.Repositories
{
    public class UserLoginIntRepository : UserLoginRepository<int, RoleInt, UserInt, UserClaimInt, UserLoginInt, UserRoleInt>, IUserLoginIntRepository
    {
        public UserLoginIntRepository(IDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
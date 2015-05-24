using DAL.EF.Interfaces;
using Domain.IdentityModels;

namespace DAL.EF.Repositories
{
    public class UserIntRepository : UserRepository<int, RoleInt, UserInt, UserClaimInt, UserLoginInt, UserRoleInt>, IUserIntRepository
    {
        public UserIntRepository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}
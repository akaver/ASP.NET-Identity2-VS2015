using DAL.EF.Interfaces;
using Domain.IdentityModels;

namespace DAL.EF.Repositories
{
    public class UserClaimIntRepository :
        UserClaimRepository<int, RoleInt, UserInt, UserClaimInt, UserLoginInt, UserRoleInt>, IUserClaimIntRepository
    {
        public UserClaimIntRepository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}
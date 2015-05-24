using DAL.WebApi.Interfaces;
using Domain.IdentityModels;

namespace DAL.WebApi.Repositories
{
    public class UserIntRepository : UserRepository<int, RoleInt, UserInt, UserClaimInt, UserLoginInt, UserRoleInt>, IUserIntRepository
    {
        public UserIntRepository(string baseUrl, string securityToken) : base(baseUrl, securityToken)
        {
        }
    }
}
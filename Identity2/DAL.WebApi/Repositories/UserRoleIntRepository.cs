using DAL.WebApi.Interfaces;
using Domain.IdentityModels;

namespace DAL.WebApi.Repositories
{
    public class UserRoleIntRepository : UserRoleRepository<int, RoleInt, UserInt, UserClaimInt, UserLoginInt, UserRoleInt>, IUserRoleIntRepository
    {
        public UserRoleIntRepository(string baseUrl, string securityToken) : base(baseUrl, securityToken)
        {
        }
    }
}
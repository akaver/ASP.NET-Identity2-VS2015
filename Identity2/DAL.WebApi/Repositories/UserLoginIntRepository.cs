using DAL.WebApi.Interfaces;
using Domain.IdentityModels;

namespace DAL.WebApi.Repositories
{
    public class UserLoginIntRepository : UserLoginRepository<int, RoleInt, UserInt, UserClaimInt, UserLoginInt, UserRoleInt>, IUserLoginIntRepository
    {
        public UserLoginIntRepository(string baseUrl, string securityToken) : base(baseUrl, securityToken)
        {
        }
    }
}
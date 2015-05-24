using DAL.WebApi.Interfaces;
using Domain.IdentityModels;

namespace DAL.WebApi.Repositories
{
    public class RoleIntRepository : RoleRepository<int, RoleInt, UserInt, UserClaimInt, UserLoginInt, UserRoleInt>, IRoleIntRepository
    {
        public RoleIntRepository(string baseUrl, string securityToken) : base(baseUrl, securityToken)
        {
        }
    }
}
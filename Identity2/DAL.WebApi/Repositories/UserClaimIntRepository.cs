using DAL.WebApi.Interfaces;
using Domain.IdentityModels;

namespace DAL.WebApi.Repositories
{
    public class UserClaimIntRepository :
        UserClaimRepository<int, RoleInt, UserInt, UserClaimInt, UserLoginInt, UserRoleInt>, IUserClaimIntRepository
    {
        public UserClaimIntRepository(string baseUrl, string securityToken) : base(baseUrl, securityToken)
        {
        }
    }
}
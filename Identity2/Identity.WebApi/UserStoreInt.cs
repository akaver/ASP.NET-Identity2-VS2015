using DAL.WebApi.Interfaces;
using Domain.IdentityModels;

namespace Identity.WebApi
{
    /// <summary>
    ///     EntityFramework based user store implementation that supports IUserStore, IUserLoginStore, IUserClaimStore and
    ///     IUserRoleStore. PK - int
    /// </summary>
    public class UserStoreInt : UserStore<int, RoleInt, UserInt, UserClaimInt, UserLoginInt, UserRoleInt,
        IRoleIntRepository, IUserClaimIntRepository, IUserLoginIntRepository, IUserIntRepository, IUserRoleIntRepository>
    {
        public UserStoreInt(IWebApiUOW uow)
            : base(uow)
        {
        }
    }
}
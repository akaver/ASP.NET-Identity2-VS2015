using DAL.EF.Interfaces;
using Domain.IdentityModels;

namespace Identity.EF
{
    /// <summary>
    ///     EntityFramework based user store implementation that supports IUserStore, IUserLoginStore, IUserClaimStore and
    ///     IUserRoleStore. PK - int
    /// </summary>
    public class UserStoreInt : UserStore<int, RoleInt, UserInt, UserClaimInt, UserLoginInt, UserRoleInt,
        IRoleIntRepository, IUserClaimIntRepository, IUserLoginIntRepository, IUserIntRepository, IUserRoleIntRepository>
    {
        public UserStoreInt(IUOW uow)
            : base(uow)
        {
        }
    }
}
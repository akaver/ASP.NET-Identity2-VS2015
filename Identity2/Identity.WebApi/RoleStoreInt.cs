using DAL.WebApi.Interfaces;
using Domain.IdentityModels;

namespace Identity.WebApi
{
    /// <summary>
    ///     RoleStore implementation, PK - int
    /// </summary>
    public class RoleStoreInt : RoleStore<int, RoleInt, UserInt, UserClaimInt, UserLoginInt, UserRoleInt, IRoleIntRepository>
    {
        public RoleStoreInt(IWebApiUOW uow, NLog.Logger logger)
            : base(uow, logger)
        {
        }
    }
}
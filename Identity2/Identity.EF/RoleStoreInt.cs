using DAL.EF.Interfaces;
using Domain.IdentityModels;

namespace Identity.EF
{
    /// <summary>
    ///     RoleStore implementation, PK - int
    /// </summary>
    public class RoleStoreInt : RoleStore<int, RoleInt, UserInt, UserClaimInt, UserLoginInt, UserRoleInt, IRoleIntRepository>
    {
        public RoleStoreInt(IUOW uow, NLog.Logger logger)
            : base(uow, logger)
        {
        }
    }
}
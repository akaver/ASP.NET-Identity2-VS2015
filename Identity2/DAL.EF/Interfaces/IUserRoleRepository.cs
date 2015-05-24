using Domain.IdentityModels;

namespace DAL.EF.Interfaces
{
    public interface IUserRoleRepository : IUserRoleRepository<string, UserRole>
    {

    }
    public interface IUserRoleRepository<in TKey, TUserRole> : IEFRepository<TUserRole>
        where TUserRole : class
    {
        TUserRole GetByUserIdAndRoleId(TKey roleId, TKey userId);

    }
}

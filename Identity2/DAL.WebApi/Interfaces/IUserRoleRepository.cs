using Domain.IdentityModels;

namespace DAL.WebApi.Interfaces
{
    public interface IUserRoleRepository : IUserRoleRepository<string, UserRole>
    {

    }
    public interface IUserRoleRepository<in TKey, TUserRole> : IWebApiRepository<TUserRole>
        where TUserRole : class
    {
        TUserRole GetByUserIdAndRoleId(TKey roleId, TKey userId);
        void DeleteByUserIdAndRoleId(TKey roleId, TKey userId);
    }
}

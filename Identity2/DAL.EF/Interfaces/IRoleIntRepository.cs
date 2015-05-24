using Domain.IdentityModels;

namespace DAL.EF.Interfaces
{
    public interface IRoleIntRepository :  IRoleRepository<int, RoleInt>
    {
    }
}
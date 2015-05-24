using Domain.IdentityModels;

namespace DAL.WebApi.Interfaces
{
    public interface IRoleIntRepository :  IRoleRepository<int, RoleInt>
    {
    }
}
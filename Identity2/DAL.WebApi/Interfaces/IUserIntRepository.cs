using Domain.IdentityModels;

namespace DAL.WebApi.Interfaces
{
    public interface IUserIntRepository : IUserRepository<int, UserInt>
    {
    }
}
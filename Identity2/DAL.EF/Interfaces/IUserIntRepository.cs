using Domain.IdentityModels;

namespace DAL.EF.Interfaces
{
    public interface IUserIntRepository : IUserRepository<int, UserInt>
    {
    }
}
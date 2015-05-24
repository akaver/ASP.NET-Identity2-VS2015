namespace DAL.WebApi.Interfaces
{
    public interface IDbContextFactory
    {
         IDbContext DbContext { get; }
    }
}

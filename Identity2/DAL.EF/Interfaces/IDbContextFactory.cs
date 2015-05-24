namespace DAL.EF.Interfaces
{
    public interface IDbContextFactory
    {
         IDbContext DbContext { get; }
    }
}

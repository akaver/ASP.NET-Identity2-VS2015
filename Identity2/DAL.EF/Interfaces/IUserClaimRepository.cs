using System.Collections.Generic;
using Domain.IdentityModels;

namespace DAL.EF.Interfaces
{
    public interface IUserClaimRepository : IUserClaimRepository<UserClaim>
    {
    }
    public interface IUserClaimRepository<TUserClaim> : IEFRepository<TUserClaim>
        where TUserClaim : class
    {
        List<TUserClaim> AllIncludeUser();
    }
}

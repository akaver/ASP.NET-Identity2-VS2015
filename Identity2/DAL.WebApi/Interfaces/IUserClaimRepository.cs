using System.Collections.Generic;
using Domain.IdentityModels;

namespace DAL.WebApi.Interfaces
{
    public interface IUserClaimRepository : IUserClaimRepository<UserClaim>
    {
    }

    public interface IUserClaimRepository<TUserClaim> : IWebApiRepository<TUserClaim>
        where TUserClaim : class
    {
        List<TUserClaim> AllIncludeUser();
    }

    
    //public interface IUserClaimRepository<TUserClaim> : IEFRepository<TUserClaim>
    //    where TUserClaim : class
    //{
    //    List<TUserClaim> AllIncludeUser();
    //}
}

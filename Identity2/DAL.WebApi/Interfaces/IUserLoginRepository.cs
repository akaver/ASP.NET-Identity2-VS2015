using System.Collections.Generic;
using Domain.IdentityModels;

namespace DAL.WebApi.Interfaces
{
    public interface IUserLoginRepository : IUserLoginRepository<UserLogin>
    {
    }
    public interface IUserLoginRepository<TUserLogin> : IWebApiRepository<TUserLogin>
        where TUserLogin : class 
    {
        List<TUserLogin> GetAllIncludeUser();
        TUserLogin GetUserLoginByProviderAndProviderKey(string loginProvider, string providerKey);
    }
}

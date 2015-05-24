using System.Collections.Generic;
using Domain.IdentityModels;
using Microsoft.AspNet.Identity;

namespace DAL.WebApi.Interfaces
{
    public interface IRoleRepository : IRoleRepository<string, Role>
	{
	}

    public interface IRoleRepository<in TKey, TRole> : IWebApiRepository<TRole>
        where TRole : class, IRole<TKey>
    {
        TRole GetByRoleName(string roleName);
        List<TRole> GetRolesForUser(TKey userId);
    }

}

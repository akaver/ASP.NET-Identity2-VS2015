﻿using System;
using System.Data.Entity;
using DAL.EF.Interfaces;

namespace DAL.EF
{
    public class UOW : IUOW, IDisposable
    {
        private readonly NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();
        private readonly string _instanceId = Guid.NewGuid().ToString();

		private IDbContext DbContext { get; set; }
        protected IEFRepositoryProvider RepositoryProvider { get; set; }

        public UOW(IEFRepositoryProvider repositoryProvider, IDbContext dbContext)
        {
			_logger.Info("_instanceId: " + _instanceId);

            DbContext = dbContext;

            repositoryProvider.DbContext = dbContext;
            RepositoryProvider = repositoryProvider;
        }

        // UoW main feature - atomic commit at the end of work
        public void Commit()
        {
            ((DbContext)DbContext).SaveChanges();
        }

	    //standard repos
		//public IEFRepository<User> Users { get { return GetStandardRepo<User>(); } }
		//public IEFRepository<Role> Roles { get { return GetStandardRepo<Role>(); } }
		//public IEFRepository<UserClaim> UserClaims { get { return GetStandardRepo<UserClaim>(); } }
		//public IEFRepository<UserLogin> UserLogins { get { return GetStandardRepo<UserLogin>(); } }

        // repo with custom methods
        // add it also in EFRepositoryFactories.cs, in method GetCustomFactories
        public IUserRepository Users { get { return GetRepo<IUserRepository>(); } }
        public IUserRoleRepository UserRoles { get { return GetRepo<IUserRoleRepository>(); } }
        public IRoleRepository Roles { get { return GetRepo<IRoleRepository>(); } }
		public IUserClaimRepository UserClaims { get { return GetRepo<IUserClaimRepository>(); } }
		public IUserLoginRepository UserLogins { get { return GetRepo<IUserLoginRepository>(); } }

        public IUserIntRepository UsersInt { get { return GetRepo<IUserIntRepository>(); } }
        public IUserRoleIntRepository UserRolesInt { get { return GetRepo<IUserRoleIntRepository>(); } }
        public IRoleIntRepository RolesInt { get { return GetRepo<IRoleIntRepository>(); } }
        public IUserClaimIntRepository UserClaimsInt { get { return GetRepo<IUserClaimIntRepository>(); } }
        public IUserLoginIntRepository UserLoginsInt { get { return GetRepo<IUserLoginIntRepository>(); } }

        // calling standard EF repo provider
        private IEFRepository<T> GetStandardRepo<T>() where T : class
        {
            return RepositoryProvider.GetRepositoryForEntityType<T>();
        }

        // calling custom repo provier
        private T GetRepo<T>() where T: class
        {
            return RepositoryProvider.GetRepository<T>();
        }

        // try to find repository
        public T GetRepository<T>() where T: class
        {
            var res = GetRepo<T>() ?? GetStandardRepo<T>() as T;
            if (res == null)
            {
                throw new NotImplementedException("No repository for type, " + typeof(T).FullName);
            }
            return res;
        }
        
        #region IDisposable
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
			_logger.Info("Disposing: " + disposing + " _instanceId: " + _instanceId);
        }

        #endregion

    }
}

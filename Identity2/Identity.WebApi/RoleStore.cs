﻿using System;
using System.Threading.Tasks;
using DAL.WebApi.Interfaces;
using Domain.IdentityModels;
using Microsoft.AspNet.Identity;

namespace Identity.WebApi
{
    /// <summary>
    ///     RoleStore implementation, PK - string
    /// </summary>
    public class RoleStore : RoleStore<string, Role, User, UserClaim, UserLogin, UserRole, IRoleRepository>, IRoleStore<Role>
    {
        public RoleStore(IWebApiUOW uow, NLog.Logger logger)
            : base(uow, logger)
        {
        }
    }

    /// <summary>
    ///     Generic RoleStore implementation
    /// </summary>
    public class RoleStore<TKey, TRole, TUser, TUserClaim, TUserLogin, TUserRole, TRepo> : IRoleStore<TRole, TKey>
        where TKey : IEquatable<TKey>
        where TRole : Role<TKey, TRole, TUser, TUserClaim, TUserLogin, TUserRole>
        where TUser : User<TKey, TRole, TUser, TUserClaim, TUserLogin, TUserRole>
        where TUserClaim : UserClaim<TKey, TRole, TUser, TUserClaim, TUserLogin, TUserRole>
        where TUserLogin : UserLogin<TKey, TRole, TUser, TUserClaim, TUserLogin, TUserRole>
        where TUserRole : UserRole<TKey, TRole, TUser, TUserClaim, TUserLogin, TUserRole>
        where TRepo : class, IRoleRepository<TKey, TRole>   
    {
        private readonly IWebApiUOW _uow;
    private readonly NLog.Logger _logger;

    private bool _disposed;
    private readonly string _instanceId = Guid.NewGuid().ToString();

    public RoleStore(IWebApiUOW uow, NLog.Logger logger)
    {
        _logger = logger;
        _logger.Info("_instanceId: " + _instanceId);
        _uow = uow;
    }

    public void Dispose()
    {
        _logger.Info("_instanceId: " + _instanceId);
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    /// <summary>
    ///     If disposing, calls dispose on dependent classes (if any).
    ///     DI should take care of most of disposing!
    /// </summary>
    /// <param name="disposing"></param>
    protected virtual void Dispose(bool disposing)
    {
        _logger.Info("_instanceId: " + _instanceId + " disposing:" + disposing);
        _disposed = true;
    }

    private void ThrowIfDisposed()
    {
        if (_disposed)
        {
            throw new ObjectDisposedException(GetType().Name);
        }
    }

    #region IRoleStore

    public Task CreateAsync(TRole role)
    {
        _logger.Info("_instanceId: " + _instanceId);

        ThrowIfDisposed();
        if (role == null)
        {
            throw new ArgumentNullException("role");
        }
        _uow.GetRepository<TRepo>().Add(role);
        _uow.Commit();

        return Task.FromResult<Object>(null);
    }

    public Task UpdateAsync(TRole role)
    {
        _logger.Info("_instanceId: " + _instanceId);

        ThrowIfDisposed();
        if (role == null)
        {
            throw new ArgumentNullException("role");
        }

        _uow.GetRepository<TRepo>().Update(role.Id, role);

        _uow.Commit();

        return Task.FromResult<Object>(null);
    }

    public Task DeleteAsync(TRole role)
    {
        _logger.Info("_instanceId: " + _instanceId);

        ThrowIfDisposed();
        if (role == null)
        {
            throw new ArgumentNullException("role");
        }
        _uow.GetRepository<TRepo>().Delete(role);
        _uow.Commit();
        return Task.FromResult<Object>(null);

    }

    public Task<TRole> FindByIdAsync(TKey roleId)
    {
        _logger.Info("_instanceId: " + _instanceId);

        ThrowIfDisposed();
        return Task.FromResult(_uow.GetRepository<TRepo>().GetById(roleId));
    }

    public Task<TRole> FindByNameAsync(string roleName)
    {
        _logger.Info("_instanceId: " + _instanceId);

        ThrowIfDisposed();
        return Task.FromResult(_uow.GetRepository<TRepo>().GetByRoleName(roleName));
    }


    #endregion

}
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IdentityModels
{
    /// <summary>
    ///     EntityType that represents a user belonging to a role, PK - string
    /// </summary>
    public class UserRole : UserRole<string, Role, User, UserClaim, UserLogin, UserRole>
    {
    }

    /// <summary>
    ///     EntityType that represents a user belonging to a role, generic
    ///     TKey - type for Id (string, int)
    /// </summary>
    public class UserRole<TKey, TRole, TUser, TUserClaim, TUserLogin, TUserRole>
        where TRole : Role<TKey, TRole, TUser, TUserClaim, TUserLogin, TUserRole>
        where TUser : User<TKey, TRole, TUser, TUserClaim, TUserLogin, TUserRole>
        where TUserClaim : UserClaim<TKey, TRole, TUser, TUserClaim, TUserLogin, TUserRole>
        where TUserLogin : UserLogin<TKey, TRole, TUser, TUserClaim, TUserLogin, TUserRole>
        where TUserRole : UserRole<TKey, TRole, TUser, TUserClaim, TUserLogin, TUserRole>
    {
        public TKey UserId { get; set; }
        public virtual TUser User { get; set; }

        public TKey RoleId { get; set; }
        public virtual TRole Role { get; set; }
    }
}

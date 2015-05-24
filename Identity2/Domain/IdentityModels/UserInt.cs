using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace Domain.IdentityModels
{
    /// <summary>
    ///     IUser implementation, PK - int
    /// </summary>
    public class UserInt : User<int, RoleInt, UserInt, UserClaimInt, UserLoginInt, UserRoleInt>
    {
        /// <summary>
        ///     Constructor which creates a new Guid for the Id
        /// </summary>
        public UserInt()
        {
            //nothing to do, PK is initialized by DB

        }

        /// <summary>
        ///     Constructor that takes a userName
        /// </summary>
        /// <param name="userName"></param>
        public UserInt(string userName)
            : this()
        {
            UserName = userName;
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<UserInt, int> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<UserInt, int> manager, string authType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authType);
            // Add custom user claims here
            return userIdentity;
        }



    }
}
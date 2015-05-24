namespace Domain.IdentityModels
{
    /// <summary>
    ///     Entity type for a user's login (i.e. facebook, google), PK - int
    /// </summary>
    public class UserLoginInt : UserLogin<int, RoleInt, UserInt, UserClaimInt, UserLoginInt, UserRoleInt>
    {
    }
}
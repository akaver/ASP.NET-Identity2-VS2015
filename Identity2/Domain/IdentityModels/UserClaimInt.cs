namespace Domain.IdentityModels
{
    /// <summary>
    ///     EntityType that represents one specific user claim, PK - int
    /// </summary>
    public class UserClaimInt : UserClaim<int, RoleInt, UserInt, UserClaimInt, UserLoginInt, UserRoleInt>
    {
    }
}
namespace Domain.IdentityModels
{
    /// <summary>
    ///     EntityType that represents a user belonging to a role, PK - int
    /// </summary>
    public class UserRoleInt : UserRole<int, RoleInt, UserInt, UserClaimInt, UserLoginInt, UserRoleInt>
    {
    }
}
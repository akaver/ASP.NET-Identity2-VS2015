namespace Domain.IdentityModels
{
    /// <summary>
    ///     Represents a Role entity, PK - int
    /// </summary>
    public class RoleInt : Role<int, RoleInt, UserInt, UserClaimInt, UserLoginInt, UserRoleInt>
    {
        public RoleInt()
        {
            
        }

        public RoleInt(string roleName) : this()
        {
            Name = roleName;
        }
    }
}
using System;
using System.Data.Entity;
using DAL.EF.EFConfiguration;
using DAL.EF.Interfaces;
using Domain.IdentityModels;

namespace DAL.EF
{
    public class DataBaseContext : DbContext, IDbContext, IDisposable
    {
        private readonly NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();
        private readonly string _instanceId = Guid.NewGuid().ToString();

        public DataBaseContext()
			: base("Name=DBConnectionString")
        {
			_logger.Debug("_instanceId: " + _instanceId);
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DataBaseContext>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<WebAppEFContext>());
        }


        // Identity tables, PK - string
        public IDbSet<Role> Roles { get; set; }
        public IDbSet<UserClaim> UserClaims { get; set; }
        public IDbSet<UserLogin> UserLogins { get; set; }
        public IDbSet<User> Users { get; set; }
        public IDbSet<UserRole> UserRoles { get; set; }

        // Identity tables, PK - int
        public IDbSet<RoleInt> RolesInt { get; set; }
        public IDbSet<UserClaimInt> UserClaimsInt { get; set; }
        public IDbSet<UserLoginInt> UserLoginsInt { get; set; }
        public IDbSet<UserInt> UsersInt { get; set; }
        public IDbSet<UserRoleInt> UserRolesInt { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Identity, PK - string 
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new UserClaimMap());
            modelBuilder.Configurations.Add(new UserLoginMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new UserRoleMap());

            // Identity, PK - int 
            modelBuilder.Configurations.Add(new RoleIntMap());
            modelBuilder.Configurations.Add(new UserClaimIntMap());
            modelBuilder.Configurations.Add(new UserLoginIntMap());
            modelBuilder.Configurations.Add(new UserIntMap());
            modelBuilder.Configurations.Add(new UserRoleIntMap());
        }

	    protected override void Dispose(bool disposing)
	    {
			_logger.Debug("Disposing: " + disposing + " _instanceId: " + _instanceId);
		    base.Dispose(disposing);
	    }

    }
}

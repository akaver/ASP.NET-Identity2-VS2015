using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using Domain.IdentityModels;

namespace DAL.WebApi.EFConfiguration
{
    public class UserIntMap : EntityTypeConfiguration<UserInt>
    {
        public UserIntMap()
        {

            HasMany(u => u.Roles).WithRequired().HasForeignKey(ur => ur.UserId);
            HasMany(u => u.Claims).WithRequired().HasForeignKey(uc => uc.UserId);
            HasMany(u => u.Logins).WithRequired().HasForeignKey(ul => ul.UserId);
            Property(u => u.UserName)
                .IsRequired()
                .HasMaxLength(256)
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("UserNameIndex") { IsUnique = true }));
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id)
                .IsRequired();

            Property(t => t.Email)
                .HasMaxLength(256);

            Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(256);

        }
    }
}
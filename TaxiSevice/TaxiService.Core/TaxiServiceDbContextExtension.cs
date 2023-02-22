using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace TaxiService.Core
{
    public static class TaxiServiceDbContextExtension
    {
        public static void Seed(this ModelBuilder builder)
        {
            string ADMIN_ROLE_ID = Guid.NewGuid().ToString();
            string USER_ROLE_ID = Guid.NewGuid().ToString();
            string DRIVER_ROLE_ID = Guid.NewGuid().ToString();

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = ADMIN_ROLE_ID,
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Id = USER_ROLE_ID,
                    Name = "User",
                    NormalizedName = "USER"
                },
                new IdentityRole
                {
                    Id = DRIVER_ROLE_ID,
                    Name = "Driver",
                    NormalizedName = "DRIVER"
                });

            string ADMIN_ID = Guid.NewGuid().ToString();
            string USER_ID = Guid.NewGuid().ToString();
            string DRIVER_ID= Guid.NewGuid().ToString();

            var admin = new User
            {
                Id = ADMIN_ID,
                UserName = "admin@taxiseervice.com",
                Email = "admin@taxiseervice.com",
                EmailConfirmed = true,
                NormalizedEmail = "admin@taxiseervice.com".ToUpper(),
                NormalizedUserName = "admin@taxiseervice.com".ToUpper()
            };
            var user = new User
            {
                Id = USER_ID,
                UserName = "user@taxiseervice.com",
                Email = "user@taxiseervice.com",
                EmailConfirmed = true,
                NormalizedEmail = "user@taxiseervice.com".ToUpper(),
                NormalizedUserName = "user@taxiseervice.com".ToUpper()
            };
            var driver = new User
            {
                Id = DRIVER_ID,
                UserName = "driver@taxiseervice.com",
                Email = "driver@taxiseervice.com",
                EmailConfirmed = true,
                NormalizedEmail = "driver@taxiseervice.com".ToUpper(),
                NormalizedUserName = "driver@taxiseervice.com".ToUpper()
            };
            PasswordHasher<User> hasher = new PasswordHasher<User>();

            admin.PasswordHash = hasher.HashPassword(admin, "AdminPass0");
            user.PasswordHash = hasher.HashPassword(user, "UserPass1");
            driver.PasswordHash = hasher.HashPassword(driver, "DriverPass2");

            builder.Entity<User>().HasData(admin, user, driver);

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = ADMIN_ROLE_ID,
                    UserId = ADMIN_ID,
                },
                new IdentityUserRole<string>
                {
                    RoleId = DRIVER_ROLE_ID,
                    UserId = DRIVER_ID,
                },
                new IdentityUserRole<string>
                {
                    RoleId = USER_ROLE_ID,
                    UserId = USER_ID,
                },
                new IdentityUserRole<string>
                {
                    RoleId = ADMIN_ROLE_ID,
                    UserId = USER_ID,
                },
                new IdentityUserRole<string>
                {
                    RoleId = ADMIN_ROLE_ID,
                    UserId = DRIVER_ID,
                }
                );
        }
    }
}

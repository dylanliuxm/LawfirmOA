using Abp.Authorization.Users;
using Abp.Extensions;
using EasyFast.Core.Entities;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyFast.Core.Entities
{
    public class User: AbpUser<User>
    {
        public const string DefaultPassword = "123qwe";
        public string RealName { get; set; }
        public string IDNumber { get; set; }

        public DateTime ContractBeginTime { get; set; }
        public DateTime ContractEndTime { get; set; }

        public long? UserTypeId { get; set; }

        public virtual UserType UserType { get; set; }

        public static string CreateRandomPassword()
        {
            return Guid.NewGuid().ToString("N").Truncate(16);
        }

        public static User CreateTenantAdminUser(int tenantId, string emailAddress, string password)
        {
            return new User
            {
                TenantId = tenantId,
                UserName = AdminUserName,
                Name = AdminUserName,
                Surname = AdminUserName,
                EmailAddress = emailAddress,
                Password = new PasswordHasher().HashPassword(password)
            };
        }

        
    }
}

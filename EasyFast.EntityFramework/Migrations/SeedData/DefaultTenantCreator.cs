using System.Linq;
using EasyFast.Core.MultiTenancy;
using EasyFast.EntityFramework.EntityFramework;
using System;

namespace EasyFast.EntityFramework.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly EasyFastDbContext _context;

        public DefaultTenantCreator(EasyFastDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName });
                _context.SaveChanges();
            }
        }
    }
}

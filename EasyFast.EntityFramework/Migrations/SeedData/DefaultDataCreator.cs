using EasyFast.Core.Entities;
using EasyFast.EntityFramework.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyFast.EntityFramework.Migrations.SeedData
{
    public class DefaultDataCreator
    {
        private readonly EasyFastDbContext _context;

        public DefaultDataCreator(EasyFastDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            InitOrganization();
        }

        private void InitOrganization()
        {
            _context.OrganizationUnits.Add(new Organization { TenantId = 1, DisplayName = "京师律师事务所" });

            _context.OrganizationUnits.Add(new Organization { TenantId = 1, DisplayName = "北京", ParentId = 1 });

            _context.OrganizationUnits.Add(new Organization { TenantId = 1, DisplayName = "人力资源部", ParentId = 2 });
            _context.OrganizationUnits.Add(new Organization { TenantId = 1, DisplayName = "行政支持部", ParentId = 2 });
            _context.OrganizationUnits.Add(new Organization { TenantId = 1, DisplayName = "客户服务部", ParentId = 2 });
            _context.OrganizationUnits.Add(new Organization { TenantId = 1, DisplayName = "风险控制部", ParentId = 2 });
            _context.OrganizationUnits.Add(new Organization { TenantId = 1, DisplayName = "文化品牌部", ParentId = 2 });
            _context.OrganizationUnits.Add(new Organization { TenantId = 1, DisplayName = "信息网络部", ParentId = 2 });
            _context.OrganizationUnits.Add(new Organization { TenantId = 1, DisplayName = "财务部", ParentId = 2 });
            _context.OrganizationUnits.Add(new Organization { TenantId = 1, DisplayName = "业务部门", ParentId = 2 });

            _context.OrganizationUnits.Add(new Organization { TenantId = 1, DisplayName = "主管", ParentId = 3 });
            _context.OrganizationUnits.Add(new Organization { TenantId = 1, DisplayName = "职员", ParentId = 3 });
            _context.OrganizationUnits.Add(new Organization { TenantId = 1, DisplayName = "主管", ParentId = 4 });
            _context.OrganizationUnits.Add(new Organization { TenantId = 1, DisplayName = "职员", ParentId = 4 });
            _context.OrganizationUnits.Add(new Organization { TenantId = 1, DisplayName = "主管", ParentId = 5 });
            _context.OrganizationUnits.Add(new Organization { TenantId = 1, DisplayName = "职员", ParentId = 5 });
            _context.OrganizationUnits.Add(new Organization { TenantId = 1, DisplayName = "主管", ParentId = 6 });
            _context.OrganizationUnits.Add(new Organization { TenantId = 1, DisplayName = "风险控制专员", ParentId = 6 });
            _context.OrganizationUnits.Add(new Organization { TenantId = 1, DisplayName = "业务盖章专员", ParentId = 6 });
            _context.OrganizationUnits.Add(new Organization { TenantId = 1, DisplayName = "主管", ParentId = 7 });
            _context.OrganizationUnits.Add(new Organization { TenantId = 1, DisplayName = "职员", ParentId = 7 });
            _context.OrganizationUnits.Add(new Organization { TenantId = 1, DisplayName = "主管", ParentId = 8 });
            _context.OrganizationUnits.Add(new Organization { TenantId = 1, DisplayName = "职员", ParentId = 8 });
            _context.OrganizationUnits.Add(new Organization { TenantId = 1, DisplayName = "主管", ParentId = 9 });
            _context.OrganizationUnits.Add(new Organization { TenantId = 1, DisplayName = "出纳", ParentId = 9 });
            _context.OrganizationUnits.Add(new Organization { TenantId = 1, DisplayName = "会计", ParentId = 9 });
            _context.OrganizationUnits.Add(new Organization { TenantId = 1, DisplayName = "律师", ParentId = 10 });
            _context.OrganizationUnits.Add(new Organization { TenantId = 1, DisplayName = "律师助理", ParentId = 10 });
        }
    }
}

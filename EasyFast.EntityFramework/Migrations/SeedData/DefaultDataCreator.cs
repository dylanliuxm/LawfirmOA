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
            _context.OrganizationUnits.Add(new Abp.Organizations.OrganizationUnit { DisplayName = "北京市京师律师事务所" });
        }
    }
}

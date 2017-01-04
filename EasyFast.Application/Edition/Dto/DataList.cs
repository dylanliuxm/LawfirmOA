using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyFast.Application.Edition.Dto
{
    public class DataList : FullAuditedEntity<long>
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
    }
}

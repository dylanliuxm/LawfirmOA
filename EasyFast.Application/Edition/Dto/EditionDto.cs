using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyFast.Application.Edition.Dto
{
    [AutoMapFrom(typeof(Abp.Application.Editions.Edition))]
    public class EditionDto : EntityDto<int>
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
    }
}

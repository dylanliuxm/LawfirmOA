using Abp.Domain.Repositories;
using AutoMapper;
using EasyFast.Application.EasyUIHelper;
using EasyFast.Application.UserType.Dto;
using EasyFast.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Text;
using System.Threading.Tasks;

namespace EasyFast.Application.Organization
{
    public class OrganizationAppService : EasyFastAppServiceBase, IOrganizationAppService
    {
        #region 依赖注入
        private readonly IRepository<Core.Entities.Organization, long> _organizationRepository;
        private readonly IUserTypeService _userTypeService;

        public OrganizationAppService(IRepository<Core.Entities.Organization, long> organizationRepository, 
            IUserTypeService userTypeService)
        {
            _organizationRepository = organizationRepository;
            _userTypeService = userTypeService;
        }
        #endregion



    }
}

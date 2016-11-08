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

namespace EasyFast.Application.UserType
{
    public class UserTypeAppService : EasyFastAppServiceBase, IUserTypeAppService
    {
        private readonly IRepository<Core.Entities.UserType, long> _userTypeRepository;
        private readonly IUserTypeService _userTypeService;


        public UserTypeAppService(IRepository<Core.Entities.UserType, long> userTypeRepository, IUserTypeService userTypeService)
        {
            _userTypeRepository = userTypeRepository;
            _userTypeService = userTypeService;
        }

        public UserTypeInput Find(long id)
        {
            var data = _userTypeRepository.FirstOrDefault(id);
            return Mapper.Map<UserTypeInput>(data);
        }

        public long Add(UserTypeInput model)
        {
            var data = Mapper.Map<Core.Entities.UserType>(model);
            return _userTypeService.Add(data);
        }

        public long Update(UserTypeInput model)
        {
            var data = Mapper.Map<Core.Entities.UserType>(model);
            return _userTypeService.Update(data);
        }

        public EasyUIDataGrid<UserTypeDataGridDto> GetDataGrid(UserTypeSearch search)
        {
            var data = _userTypeRepository.GetAll()
                .Where(o => o.Name.Contains(search.Name), !string.IsNullOrEmpty(search.Name));
            var total = data.Count();
            var list = Mapper.Map<List<UserTypeDataGridDto>>(data);
            var rows = list.OrderBy(String.Format("{0} {1}", search.Sort, search.Order))
                .Skip((search.Page - 1) * search.Rows).Take(search.Rows).ToList();
            return new EasyUIDataGrid<UserTypeDataGridDto> { total = total, rows = rows };
        }
    }
}

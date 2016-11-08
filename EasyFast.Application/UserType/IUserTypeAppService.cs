using Abp.Application.Services;
using EasyFast.Application.EasyUIHelper;
using EasyFast.Application.UserType.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyFast.Application.UserType
{
    public interface IUserTypeAppService : IApplicationService
    {
        UserTypeInput Find(long id);
        long Add(UserTypeInput model);
        long Update(UserTypeInput model);
        EasyUIDataGrid<UserTypeDataGridDto> GetDataGrid(UserTypeSearch search);
    }
}

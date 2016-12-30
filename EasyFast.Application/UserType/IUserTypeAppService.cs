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
        /// <summary>
        /// 检测传入的全部用户类别是否含有用户，用于判断直接删除or转移用户后再删除
        /// </summary>
        /// <param name="ids">long[] Model.UserType.Id</param>
        /// <returns>true:含有用户 false:不含用户</returns>
        bool CheckIsHaveUser(long[] ids);
        void Delete(DeleteInput model);
    }
}

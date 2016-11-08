using Abp.Domain.Services;
using EasyFast.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyFast.Core.Service
{
    public interface IUserTypeService : IDomainService
    {
        /// <summary>
        /// 新增一条不重名的数据
        /// </summary>
        /// <param name="model">Model.UserType</param>
        /// <returns>0:重名。>0:自增Id</returns>
        long Add(UserType model);

        /// <summary>
        /// 更新一条不重名的数据
        /// </summary>
        /// <param name="model">Model.UserType</param>
        /// <returns>0:重名。>0:Model.UserType.Id</returns>
        long Update(UserType model);
        /// <summary>
        /// 检测是否重名
        /// </summary>
        /// <param name="id">Model.UserType.Id.Add时取0</param>
        /// <param name="name">Model.UserType.Name</param>
        /// <returns>true:存在重名数据。false:不存在重名数据</returns>
        bool CheckName(long id, string name);
    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using EasyFast.Core.Entities.Dtos;

namespace EasyFast.Core.Entities
{
	/// <summary>
    /// 人员类别管理服务接口
    /// </summary>
    public interface IUserTypeAppService : IApplicationService
    {
        #region 人员类别管理管理

        /// <summary>
        /// 根据查询条件获取人员类别管理分页列表
        /// </summary>
        Task<PagedResultOutput<UserTypeListDto>> GetPagedUserTypesAsync(GetUserTypeInput input);

        /// <summary>
        /// 通过Id获取人员类别管理信息进行编辑或修改 
        /// </summary>
        Task<GetUserTypeForEditOutput> GetUserTypeForEditAsync(NullableIdInput<long> input);

		  /// <summary>
        /// 通过指定id获取人员类别管理ListDto信息
        /// </summary>
		Task<UserTypeListDto> GetUserTypeByIdAsync(IdInput<long> input);



        /// <summary>
        /// 新增或更改人员类别管理
        /// </summary>
        Task CreateOrUpdateUserTypeAsync(CreateOrUpdateUserTypeInput input);


        /// <summary>
        /// 新增人员类别管理
        /// </summary>
        Task<UserTypeEditDto> CreateUserTypeAsync(UserTypeEditDto input);

        /// <summary>
        /// 更新人员类别管理
        /// </summary>
        Task UpdateUserTypeAsync(UserTypeEditDto input);

        /// <summary>
        /// 删除人员类别管理
        /// </summary>
        Task DeleteUserTypeAsync(IdInput<long> input);

        /// <summary>
        /// 批量删除人员类别管理
        /// </summary>
        Task BatchDeleteUserTypeAsync(List<long> input);

        #endregion

    }
}

                                                                         
        
// 项目展示地址:"http://www.ddxc.org/"
 // 如果你有什么好的建议或者觉得可以加什么功能，请加QQ群：104390185大家交流沟通
// 项目展示地址:"http://www.yoyocms.com/"
//博客地址：http://www.cnblogs.com/wer-ltm/
//代码生成器帮助文档：http://www.cnblogs.com/wer-ltm/p/5777190.html
// <Author-作者>角落的白板笔</Author-作者>
// Copyright © YoYoCms@中国.2016-10-29T13:43:21. All Rights Reserved.
//<生成时间>2016-10-29T13:43:21</生成时间>
	using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Linq.Dynamic;
    using System.Text;
    using System.Threading.Tasks;
    using Abp;
    using Abp.Application.Services.Dto;
    using Abp.Authorization;
    using Abp.AutoMapper;
    using Abp.Configuration;
    using Abp.Domain.Repositories;
    using Abp.Extensions;
    using Abp.Linq.Extensions;
    using EasyFast.Core.Entities.Authorization;
    using EasyFast.Core.Entities.Dtos;
 
    namespace EasyFast.Core.Entities
{
    /// <summary>
    /// 人员类别管理服务实现
    /// </summary>
    [AbpAuthorize(UserTypeAppPermissions.UserType)]
    public class UserTypeAppService : CoreAppServiceBase, IUserTypeAppService
    {
        private readonly IRepository<UserType,long> _userTypeRepository;
		private readonly UserTypeManage _userTypeManage;
        /// <summary>
        /// 构造方法
        /// </summary>
        public UserTypeAppService( IRepository<UserType,long> userTypeRepository	,UserTypeManage userTypeManage  )
        {
            _userTypeRepository = userTypeRepository;
			 _userTypeManage = userTypeManage;

        }

    #region 人员类别管理管理

    /// <summary>
    /// 根据查询条件获取人员类别管理分页列表
    /// </summary>
    public async Task<PagedResultOutput<UserTypeListDto>> GetPagedUserTypesAsync(GetUserTypeInput input)
{
			
    var query = _userTypeRepository.GetAll();
    //TODO:根据传入的参数添加过滤条件

    var userTypeCount = await query.CountAsync();

    var userTypes = await query
    .OrderBy(input.Sorting)
    .PageBy(input)
    .ToListAsync();

    var userTypeListDtos = userTypes.MapTo<List<UserTypeListDto>>();
    return new PagedResultOutput<UserTypeListDto>(
    userTypeCount,
    userTypeListDtos
    );
    }

        /// <summary>
    /// 通过Id获取人员类别管理信息进行编辑或修改 
    /// </summary>
    public async Task<GetUserTypeForEditOutput> GetUserTypeForEditAsync(NullableIdInput<long> input)
{
    var output=new GetUserTypeForEditOutput();

    UserTypeEditDto userTypeEditDto;

    if(input.Id.HasValue)
	{
    var entity=await _userTypeRepository.GetAsync(input.Id.Value);
    userTypeEditDto=entity.MapTo<UserTypeEditDto>();
    }
	else 
	{
	userTypeEditDto=new UserTypeEditDto();	
	}

	output.UserType=userTypeEditDto;
	return output;
    }


    /// <summary>
    /// 通过指定id获取人员类别管理ListDto信息
    /// </summary>
    public async Task<UserTypeListDto> GetUserTypeByIdAsync(IdInput<long> input)
{
    var entity = await _userTypeRepository.GetAsync(input.Id);

    return entity.MapTo<UserTypeListDto>();
    }







    /// <summary>
    /// 新增或更改人员类别管理
    /// </summary>
    public async Task CreateOrUpdateUserTypeAsync(CreateOrUpdateUserTypeInput input)
{
    if (input.UserTypeEditDto.Id.HasValue)
{
    await UpdateUserTypeAsync(input.UserTypeEditDto);
    }
    else
{
    await CreateUserTypeAsync(input.UserTypeEditDto);
    }
    }

    /// <summary>
    /// 新增人员类别管理
    /// </summary>
    [AbpAuthorize(UserTypeAppPermissions.UserType_CreateUserType)]
    public virtual async Task<UserTypeEditDto> CreateUserTypeAsync(UserTypeEditDto input)
{
    //TODO:新增前的逻辑判断，是否允许新增

	var entity = input.MapTo<UserType>();
	
    entity = await _userTypeRepository.InsertAsync(entity);
    return entity.MapTo<UserTypeEditDto>();
    }

    /// <summary>
    /// 编辑人员类别管理
    /// </summary>
    [AbpAuthorize(UserTypeAppPermissions.UserType_EditUserType)]
    public virtual async Task UpdateUserTypeAsync(UserTypeEditDto input)
{
    //TODO:更新前的逻辑判断，是否允许更新

    var entity = await _userTypeRepository.GetAsync(input.Id.Value);
	input.MapTo(entity);

    await _userTypeRepository.UpdateAsync(entity);
    }

    /// <summary>
    /// 删除人员类别管理
    /// </summary>
    [AbpAuthorize(UserTypeAppPermissions.UserType_DeleteUserType)]
    public async Task DeleteUserTypeAsync(IdInput<long> input)
{
    //TODO:删除前的逻辑判断，是否允许删除
    await _userTypeRepository.DeleteAsync(input.Id);
    }

        /// <summary>
    /// 批量删除人员类别管理
    /// </summary>
    [AbpAuthorize(UserTypeAppPermissions.UserType_DeleteUserType)]
    public async Task BatchDeleteUserTypeAsync(List<long> input)
{
    //TODO:批量删除前的逻辑判断，是否允许删除
    await _userTypeRepository.DeleteAsync(s=>input.Contains(s.Id));
    }

            #endregion

    }
    }

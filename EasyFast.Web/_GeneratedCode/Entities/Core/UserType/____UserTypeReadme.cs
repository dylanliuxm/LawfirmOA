
// 项目展示地址:"http://www.ddxc.org/"
 // 如果你有什么好的建议或者觉得可以加什么功能，请加QQ群：104390185大家交流沟通
// 项目展示地址:"http://www.yoyocms.com/"
//博客地址：http://www.cnblogs.com/wer-ltm/
//代码生成器帮助文档：http://www.cnblogs.com/wer-ltm/p/5777190.html
// <Author-作者>角落的白板笔</Author-作者>
// Copyright © YoYoCms@中国.2016-10-29T13:43:21. All Rights Reserved.
//<生成时间>2016-10-29T13:43:21</生成时间>
namespace EasyFast.Core.Entities
{
	
	

		//TODO:多页面后端的导航栏目设计

	/*
	//无次级导航属性
	   var userType=new MenuItemDefinition(
                UserTypeAppPermissions.UserType,
                L("UserType"),
				url:"Admin/UserTypeManage",
				icon:"icon-grid",
				 requiredPermissionName: UserTypeAppPermissions.UserType
				);

*/
				//有下级菜单
            /*

			   var userType=new MenuItemDefinition(
                UserTypeAppPermissions.UserType,
                L("UserType"),			
				icon:"icon-grid"				
				);

				userType.AddItem(
			new MenuItemDefinition(
			UserTypeAppPermissions.UserType,
			L("UserType"),
			"icon-star",
			"userType",
			requiredPermissionName: UserTypeAppPermissions.UserType));
	

			
			*/

	
			
	
	
	
	//配置权限模块初始化
 //TODO:★需要到请将以下内容剪切到CoreApplicationModule
 //   Configuration.Authorization.Providers.Add<UserTypeAppAuthorizationProvider>();


 

//TODO:★请将以下内容剪切到CORE类库的Localization/Source/Corezh-cn.xml
/*
    <!-- 人员类别管理管理 -->
	    <text name="UserType" value="人员类别管理" />
	    <text name="UserTypeHeaderInfo" value="人员类别管理信息列表" />
		    <text name="CreateUserType" value="新增人员类别管理" />
    <text name="EditUserType" value="编辑人员类别管理" />
    <text name="DeleteUserType" value="删除人员类别管理" />
		    <text name="UserTypeDeleteWarningMessage" value="人员类别管理名称: {0} 将被删除,是否确定删除它。" />
<!--//用于表格展示的数据信息的标题-->
					<text name="Name" value="人员类别名称" />
				 	<text name="Remarks" value="备注信息" />
				 	<text name="AppUser" value="AppUser" />
				 	<text name="OrderId" value="排序Id，默认倒序排列" />
				 	<text name="RowVersion" value="行号，用于乐观并发控制" />
				 	<text name="LastModificationTime" value="最后编辑时间" />
				 	<text name="CreationTime" value="创建时间" />
				 
*/


//TODO:★请将以下内容剪切到CORE类库的Localization/Source/Core.xml
/*
    <!-- 人员类别管理english管理 -->
		    <text name="	UserTypeHeaderInfo" value="人员类别管理List" />
			<!--//用于表格展示的数据信息的标题-->
					<text name="Name" value="人员类别名称" />
				 	<text name="Remarks" value="备注信息" />
				 	<text name="AppUser" value="AppUser" />
				 	<text name="OrderId" value="排序Id，默认倒序排列" />
				 	<text name="RowVersion" value="行号，用于乐观并发控制" />
				 	<text name="LastModificationTime" value="最后编辑时间" />
				 	<text name="CreationTime" value="创建时间" />
				 
    <text name="UserType" value="ManagementUserType" />
    <text name="CreateUserType" value="CreateUserType" />
    <text name="EditUserType" value="EditUserType" />
    <text name="DeleteUserType" value="DeleteUserType" />
*/




}
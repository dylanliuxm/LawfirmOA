 // 项目展示地址:"http://www.ddxc.org/"
 // 如果你有什么好的建议或者觉得可以加什么功能，请加QQ群：104390185大家交流沟通
// 项目展示地址:"http://www.yoyocms.com/"
//博客地址：http://www.cnblogs.com/wer-ltm/
//代码生成器帮助文档：http://www.cnblogs.com/wer-ltm/p/5777190.html
// <Author-作者>角落的白板笔</Author-作者>
// Copyright © YoYoCms@中国.2016-10-29T13:43:22. All Rights Reserved.
//<生成时间>2016-10-29T13:43:22</生成时间>
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using Abp.Application.Services.Dto;
using Abp.Extensions;
using EasyFast.Core.Entities;

namespace EasyFast.Core.Entities.EntityMapper.Entities
{

	/// <summary>
    /// 人员类别管理的数据配置文件
    /// </summary>
    public class UserTypeCfg : EntityTypeConfiguration<UserType>
    {
		/// <summary>
        ///  构造方法[默认链接字符串< see cref = "CoreDbContext" /> ]
        /// </summary>
		public UserTypeCfg ()
		{
		            ToTable("UserType", CoreConsts.SchemaName.Basic);
 
      //todo: 需要将以下文件注入到CoreDbContext中

  //    public IDbSet<UserType> UserTypes { get; set; }
   //   modelBuilder.Configurations.Add(new UserTypeCfg());




		    // 人员类别名称
			Property(a => a.Name).HasMaxLength(50);
		    // 备注信息
			Property(a => a.Remarks).HasMaxLength(4000);
		    // 行号，用于乐观并发控制 - 关系映射
			HasRequired(a => a.RowVersion).WithMany().HasForeignKey(c => c.RowVersionId).WillCascadeOnDelete(true);


		}
    }
}
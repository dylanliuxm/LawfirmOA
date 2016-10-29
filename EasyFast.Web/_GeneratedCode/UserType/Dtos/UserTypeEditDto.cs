
// 项目展示地址:"http://www.ddxc.org/"
 // 如果你有什么好的建议或者觉得可以加什么功能，请加QQ群：104390185大家交流沟通
// 项目展示地址:"http://www.yoyocms.com/"
//博客地址：http://www.cnblogs.com/wer-ltm/
//代码生成器帮助文档：http://www.cnblogs.com/wer-ltm/p/5777190.html
// <Author-作者>角落的白板笔</Author-作者>
// Copyright © YoYoCms@中国.2016-10-29T13:43:20. All Rights Reserved.
//<生成时间>2016-10-29T13:43:20</生成时间>
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;
using Abp.Runtime.Validation;
using Abp.Extensions;
using EasyFast.Core.Entities;

namespace EasyFast.Core.Entities.Dtos
{
    /// <summary>
    /// 人员类别管理编辑用Dto
    /// </summary>
    [AutoMap(typeof(UserType))]
    public class UserTypeEditDto 
    {

	/// <summary>
    ///   主键Id
    /// </summary>
    [DisplayName("主键Id")]
	public long? Id{get;set;}

        /// <summary>
        /// 人员类别名称
        /// </summary>
        [DisplayName("人员类别名称")]
        [Required]
        [MaxLength(50)]
        public   string  Name { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [DisplayName("备注信息")]
        public   string  Remarks { get; set; }

        /// <summary>
        /// 排序Id，默认倒序排列
        /// </summary>
        [DisplayName("排序Id，默认倒序排列")]
        public   int  OrderId { get; set; }

    }
}

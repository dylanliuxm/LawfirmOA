using Abp.Organizations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyFast.Core.Entities
{
    public class Organization : OrganizationUnit
    {
        /// <summary>
        /// 负责人
        /// </summary>
        [StringLength(50)]
        public string Manager { get; set; }

        /// <summary>
        /// 负责人联系电话
        /// </summary>
        [StringLength(50)]
        public string Tel { get; set; }

        /// <summary>
        /// 所在区域（指公司内部的办公区划分）
        /// </summary>
        [StringLength(50)]
        public string Area { get; set; }
    }
}

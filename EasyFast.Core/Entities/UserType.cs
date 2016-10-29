using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using EasyFast.Core.Entities;

namespace EasyFast.Core.Entities
{
    public class UserType : BaseEntity
    {
        /// <summary>
        /// 人员类别名称
        /// </summary>
        [StringLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        public string Remarks { get; set; }
        public ICollection<User> User { get; set; }
    }
}

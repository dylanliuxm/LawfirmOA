using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyFast.Core.Entities
{
    public class BaseEntity : FullAuditedEntity<long>
    {
        public BaseEntity()
        {
            OrderId = 9999;
        }

        /// <summary>
        /// 排序Id，默认倒序排列
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// 行号，用于乐观并发控制
        /// </summary>
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}

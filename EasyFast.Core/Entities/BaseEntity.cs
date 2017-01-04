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
            OrderId = 999;
            Guid = Guid.NewGuid();
        }

        /// <summary>
        /// model的Guid，用于记录操作日志
        /// </summary>
        public Guid Guid { get; set; }

        /// <summary>
        /// 排序Id
        /// </summary>
        [Range(1,999)]
        public int OrderId { get; set; }
    }
}

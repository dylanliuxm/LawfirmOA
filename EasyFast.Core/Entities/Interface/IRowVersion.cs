using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyFast.Core.Entities.Interface
{
    /// <summary>
    /// 行号，用于乐观并发控制
    /// </summary>
    public interface IRowVersion
    {
        
        [Timestamp]
        byte[] RowVersion { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyFast.Application.UserType.Dto
{
    public class DeleteInput
    {
        public long OldId { get; set; }
        public long NewId { get; set; }
    }
}

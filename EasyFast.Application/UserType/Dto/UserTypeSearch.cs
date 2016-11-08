using EasyFast.Application.EasyUIHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EasyFast.Application.UserType.Dto
{
    public class UserTypeSearch : EasyUIPager
    {
        [StringLength(50)]
        public string Name { get; set; }
    }
}

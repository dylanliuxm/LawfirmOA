using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyFast.Application.UserType.Dto
{
    public class DeleteUser
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public bool Sex { get; set; }
        public string Avatar { get; set; }
        public string Phone { get; set; }
        public string OrganizationName { get; set; }
    }
}

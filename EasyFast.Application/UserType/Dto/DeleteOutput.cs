﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyFast.Application.UserType.Dto
{
    public class DeleteOutput
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Remarks { get; set; }
        public Dictionary<long, string> UserTypeList { get; set; }
    }
}

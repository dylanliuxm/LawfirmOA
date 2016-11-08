using AutoMapper;
using EasyFast.Application.UserType.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyFast.Application.AutoMapper
{
    public static class AutoMapperConfig
    {
        public static void Bind(IMapperConfigurationExpression opt)
        {
            opt.CreateMap<Core.Entities.UserType,UserTypeInput>();
            opt.CreateMap<UserTypeInput, Core.Entities.UserType>()
                .ForMember(d => d.User, s => s.Ignore());
            opt.CreateMap<Core.Entities.UserType, UserTypeDataGridDto>()
                .ForMember(d => d.UserCount, s => s.MapFrom(o => o.User.Count));

            //Mapper.AssertConfigurationIsValid();//验证所有的映射配置是否都正常
        }

        public static void Config()
        {
            Mapper.Initialize(Bind);
        }
    }
}

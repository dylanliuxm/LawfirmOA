using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using EasyFast.Application.AutoMapper;

namespace EasyFast.Application
{
    [DependsOn(typeof(EasyFastCoreModule), typeof(AbpAutoMapperModule))]
    public class EasyFastApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Modules.AbpAutoMapper().Configurators.Add(mapper =>
            {
                AutoMapperConfig.Bind(mapper);
                //Add your custom AutoMapper mappings here...
                //mapper.CreateMap<,>()
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}

using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using EasyFast.EntityFramework;
using EasyFast.EntityFramework.EntityFramework;

namespace EasyFast.EntityFramework
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(EasyFastCoreModule))]
    public class EasyFastDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<EasyFastDbContext>());

            Configuration.DefaultNameOrConnectionString = "AppDbContext";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}

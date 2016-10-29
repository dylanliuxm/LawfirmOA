using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using EasyFast.EntityFramework;
using EasyFast.EntityFramework.EntityFramework;


namespace EasyFast.Migrator
{
    [DependsOn(typeof(EasyFastDataModule))]
    public class EasyFastMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<EasyFastDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
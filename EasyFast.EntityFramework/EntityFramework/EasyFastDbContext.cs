using System.Data.Common;
using Abp.Zero.EntityFramework;
using EasyFast.Core.Authorization.Roles;
using EasyFast.Core.MultiTenancy;
using EasyFast.Core.Users;
using System.Data.Entity;
using EasyFast.Core.Entities;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Validation;
using System.Threading.Tasks;
using System.Threading;

namespace EasyFast.EntityFramework.EntityFramework
{
    public class EasyFastDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public EasyFastDbContext()
            : base("AppDbContext")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in EasyFastDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of EasyFastDbContext since ABP automatically handles it.
         */
        public EasyFastDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public EasyFastDbContext(DbConnection connection)
            : base(connection, true)
        {

        }

        #region EntityFramework并发冲突检测
        public override int SaveChanges()
        {
            try
            {
                ApplyAbpConcepts();
                return base.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                LogDbEntityValidationException(ex);
                throw;
            }
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            try
            {
                ApplyAbpConcepts();
                return await base.SaveChangesAsync(cancellationToken);
            }
            catch (DbEntityValidationException ex)
            {
                LogDbEntityValidationException(ex);
                throw;
            }
        }
        #endregion

        #region
        public virtual IDbSet<UserType> UserType { set; get; }
        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //将表名固定为单数形式
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}

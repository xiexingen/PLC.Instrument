using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using PLC.Instrument.EntityFramework;

namespace PLC.Instrument
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(InstrumentCoreModule))]
    public class InstrumentDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<InstrumentDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}

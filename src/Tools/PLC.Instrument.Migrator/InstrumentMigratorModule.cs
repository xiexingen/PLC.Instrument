using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using PLC.Instrument.EntityFramework;

namespace PLC.Instrument.Migrator
{
    [DependsOn(typeof(InstrumentDataModule))]
    public class InstrumentMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<InstrumentDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
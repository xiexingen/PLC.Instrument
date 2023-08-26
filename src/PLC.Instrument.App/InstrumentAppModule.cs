using System.Reflection;
using Abp.Modules;

namespace PLC.Instrument.App
{
    [DependsOn(typeof(InstrumentDataModule), typeof(InstrumentApplicationModule))]
    public class InstrumentAppModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}

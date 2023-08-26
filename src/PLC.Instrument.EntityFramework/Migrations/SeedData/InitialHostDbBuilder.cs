using PLC.Instrument.EntityFramework;
using EntityFramework.DynamicFilters;

namespace PLC.Instrument.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly InstrumentDbContext _context;

        public InitialHostDbBuilder(InstrumentDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}

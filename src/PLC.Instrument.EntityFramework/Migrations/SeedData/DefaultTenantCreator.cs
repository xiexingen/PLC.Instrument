using System.Linq;
using PLC.Instrument.EntityFramework;
using PLC.Instrument.MultiTenancy;

namespace PLC.Instrument.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly InstrumentDbContext _context;

        public DefaultTenantCreator(InstrumentDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}

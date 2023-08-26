using Abp.Application.Services;
using Abp.Authorization.Users;
using PLC.Instrument.Authorization.Accounts.Dto;
using PLC.Instrument.Authorization.Users;
using System.Threading.Tasks;

namespace PLC.Instrument.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<AbpLoginResult<MultiTenancy.Tenant, User>> Login(LoginInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

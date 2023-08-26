using System.Threading.Tasks;
using Abp.Application.Services;
using PLC.Instrument.Authorization.Accounts.Dto;

namespace PLC.Instrument.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

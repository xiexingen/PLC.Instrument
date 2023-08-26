using System.Threading.Tasks;
using Abp.Application.Services;
using PLC.Instrument.Sessions.Dto;

namespace PLC.Instrument.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PLC.Instrument.MultiTenancy.Dto;

namespace PLC.Instrument.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

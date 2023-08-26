using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PLC.Instrument.Roles.Dto;

namespace PLC.Instrument.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}

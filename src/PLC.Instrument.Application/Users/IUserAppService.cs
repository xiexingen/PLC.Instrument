using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PLC.Instrument.Roles.Dto;
using PLC.Instrument.Users.Dto;

namespace PLC.Instrument.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}
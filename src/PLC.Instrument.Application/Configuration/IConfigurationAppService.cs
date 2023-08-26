using System.Threading.Tasks;
using Abp.Application.Services;
using PLC.Instrument.Configuration.Dto;

namespace PLC.Instrument.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
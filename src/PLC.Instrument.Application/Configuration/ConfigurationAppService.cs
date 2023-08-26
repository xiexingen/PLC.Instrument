using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using PLC.Instrument.Configuration.Dto;

namespace PLC.Instrument.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : InstrumentAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

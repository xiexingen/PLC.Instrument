using System.Collections.Generic;
using Abp.Configuration;

namespace PLC.Instrument.Configuration
{
    public class AppSettingProvider : SettingProvider
    {
        public override IEnumerable<SettingDefinition> GetSettingDefinitions(SettingDefinitionProviderContext context)
        {
            return new[]
            {
                new SettingDefinition(AppSettingNames.UiTheme, "red", scopes: SettingScopes.Application | SettingScopes.Tenant | SettingScopes.User, isVisibleToClients: true),
                new SettingDefinition(Abp.Localization.LocalizationSettingNames.DefaultLanguage, "zh-Hans"),
            };
        }
    }
}
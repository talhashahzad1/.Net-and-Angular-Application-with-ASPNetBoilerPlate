using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MyEmployee.Configuration.Dto;

namespace MyEmployee.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MyEmployeeAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

using System.Threading.Tasks;
using MyEmployee.Configuration.Dto;

namespace MyEmployee.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

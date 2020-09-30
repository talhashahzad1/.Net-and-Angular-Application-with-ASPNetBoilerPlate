using System.Threading.Tasks;
using Abp.Application.Services;
using MyEmployee.Authorization.Accounts.Dto;

namespace MyEmployee.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

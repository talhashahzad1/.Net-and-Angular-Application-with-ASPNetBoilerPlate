using System.Threading.Tasks;
using Abp.Application.Services;
using MyEmployee.Sessions.Dto;

namespace MyEmployee.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

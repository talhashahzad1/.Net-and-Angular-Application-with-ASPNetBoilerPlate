using Abp.Application.Services;
using MyEmployee.MultiTenancy.Dto;

namespace MyEmployee.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}


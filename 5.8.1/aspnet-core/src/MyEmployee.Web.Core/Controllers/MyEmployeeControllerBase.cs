using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MyEmployee.Controllers
{
    public abstract class MyEmployeeControllerBase: AbpController
    {
        protected MyEmployeeControllerBase()
        {
            LocalizationSourceName = MyEmployeeConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

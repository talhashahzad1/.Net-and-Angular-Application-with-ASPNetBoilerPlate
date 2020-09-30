using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyEmployee.EntityFrameworkCore;
using MyEmployee.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace MyEmployee.Web.Tests
{
    [DependsOn(
        typeof(MyEmployeeWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class MyEmployeeWebTestModule : AbpModule
    {
        public MyEmployeeWebTestModule(MyEmployeeEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyEmployeeWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MyEmployeeWebMvcModule).Assembly);
        }
    }
}
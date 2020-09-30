using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyEmployee.Authorization;

namespace MyEmployee
{
    [DependsOn(
        typeof(MyEmployeeCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyEmployeeApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MyEmployeeAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MyEmployeeApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}

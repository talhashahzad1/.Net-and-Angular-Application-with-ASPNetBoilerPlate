using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyEmployee.Configuration;

namespace MyEmployee.Web.Host.Startup
{
    [DependsOn(
       typeof(MyEmployeeWebCoreModule))]
    public class MyEmployeeWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MyEmployeeWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyEmployeeWebHostModule).GetAssembly());
        }
    }
}

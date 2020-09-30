using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MyEmployee.Configuration;
using MyEmployee.Web;

namespace MyEmployee.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MyEmployeeDbContextFactory : IDesignTimeDbContextFactory<MyEmployeeDbContext>
    {
        public MyEmployeeDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyEmployeeDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MyEmployeeDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MyEmployeeConsts.ConnectionStringName));

            return new MyEmployeeDbContext(builder.Options);
        }
    }
}

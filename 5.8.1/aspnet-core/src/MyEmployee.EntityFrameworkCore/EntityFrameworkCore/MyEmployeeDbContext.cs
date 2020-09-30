using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyEmployee.Authorization.Roles;
using MyEmployee.Authorization.Users;
using MyEmployee.MultiTenancy;

namespace MyEmployee.EntityFrameworkCore
{
    public class MyEmployeeDbContext : AbpZeroDbContext<Tenant, Role, User, MyEmployeeDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MyEmployeeDbContext(DbContextOptions<MyEmployeeDbContext> options)
            : base(options)
        {
        }
    }
}

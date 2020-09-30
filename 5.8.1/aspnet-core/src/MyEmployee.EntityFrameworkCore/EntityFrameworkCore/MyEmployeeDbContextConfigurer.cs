using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyEmployee.EntityFrameworkCore
{
    public static class MyEmployeeDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyEmployeeDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MyEmployeeDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}

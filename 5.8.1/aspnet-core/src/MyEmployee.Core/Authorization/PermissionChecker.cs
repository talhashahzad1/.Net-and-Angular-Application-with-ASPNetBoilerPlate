using Abp.Authorization;
using MyEmployee.Authorization.Roles;
using MyEmployee.Authorization.Users;

namespace MyEmployee.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}

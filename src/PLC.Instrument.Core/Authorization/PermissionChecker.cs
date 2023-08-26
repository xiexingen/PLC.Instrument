using Abp.Authorization;
using PLC.Instrument.Authorization.Roles;
using PLC.Instrument.Authorization.Users;

namespace PLC.Instrument.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}

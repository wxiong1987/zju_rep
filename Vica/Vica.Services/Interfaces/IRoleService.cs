using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vica.Models;

namespace Vica.Services
{
    public interface IRoleService : IServiceBase<Role>
    {
        bool IsRoleExists(string roleName);
        List<Role> GetRolesForUser(string username);
        List<Role> GetRolesForUser(Guid userId);
    }
}

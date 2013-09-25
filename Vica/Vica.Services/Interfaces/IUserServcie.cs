using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vica.Models;

namespace Vica.Services
{
    public interface IUserServcie : IServiceBase<User>
    {
        bool IsUserExists(string username);
        bool IsUserExists(string username, string password);
        void ChangePassword(string username, string password);
        void ChangePassword(Guid userId, string password);
        void ChangeDisplayName(string username, string displayName);
        void ChangeDisplayName(Guid userId, string displayName);
    }
}

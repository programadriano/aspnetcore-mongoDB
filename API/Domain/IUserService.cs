using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Domain
{
    public interface IUserService
    {
        Task<User> FindUser(User user);
    }
}

using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Client.Service.UserService
{
    interface IUserService
    {
        Task<List<User>> AddUser(User user);
        Task<List<User>> UpdateUser(User user);
        Task<List<User>> DeleteUser(User user);
        Task<List<User>> GetAllUser();

        Task<User> GetUser(int Id);
    }
}

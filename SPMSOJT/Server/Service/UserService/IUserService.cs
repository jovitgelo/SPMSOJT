using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Server.Service.UserService
{
    public interface IUserService
    {
        Task<List<User>> AddUser(User user);
        Task<User> GetUser(int userId);
        Task<List<User>> UpdateUser(User user);
        Task<List<User>> RemoveUser(User user);
        Task<List<User>> LoadAllStudents();
    }
}

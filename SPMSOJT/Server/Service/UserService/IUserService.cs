using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Server.Service.UserService
{
    public interface IUserService
    {
        //interface of the user service class
        //add an abstract method in here first then implement in the UserService Class

        //abstract method of AddUser
        Task<List<User>> AddUser(User user);

        //abstract method of GetUser
        Task<User> GetUser(int userId);

        //abstract method of UpdateUser
        Task<List<User>> UpdateUser(User user);

        //abstract method of RemoveUser
        Task<List<User>> RemoveUser(User user);

        //abstract method of LoadAllStudents
        Task<List<User>> LoadAllStudents();
    }
}

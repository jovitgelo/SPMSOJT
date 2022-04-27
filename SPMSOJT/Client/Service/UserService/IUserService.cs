using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Client.Service.UserService
{
    interface IUserService
    {
        //interface of the user service class
        //add an abstract method in here first then implement in the UserService Class

        //abstract method of AddUser
        Task<List<User>> AddUser(User user);

        //abstract method of UpdateUser
        Task<List<User>> UpdateUser(User user);

        //abstract method of DeleteUser
        Task<List<User>> DeleteUser(User user);

        //abstract method of GetAllUser
        Task<List<User>> GetAllUser();

        //abstract method of GetUser
        Task<User> GetUser(int Id);
    }
}

using Microsoft.EntityFrameworkCore;
using SPMSOJT.Server.Data;
using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Server.Service.UserService
{
    public class UserService : IUserService
    {
        //dependecy inject variable
        private readonly DataContext _data;

        //DataContext are used to connect to the DataContext Class
        //DataContext file path: SPMJSOJT.Server/Data/DataContext
        //DataContext Class is the direct connection between the SQL Server Database and the SPMJSOJT Server
        public UserService(DataContext data)
        {
            _data = data;
        }

        //Create New instance of List of User
        List<User> Users = new List<User>();
        //Create new instance of User
        User user = new User();

        //Method for adding new User data to the user_info table
        public async Task<List<User>> AddUser(User user)
        {
            //Add the user to the database table
            await _data.user_info.AddAsync(user);
            //Save the changes to the database
            await _data.SaveChangesAsync();
            //return a list of User from the user_info table
            return Users = await _data.user_info.ToListAsync();
        }

        //Method for getting all the User data from user_info table
        public async Task<List<User>> LoadAllStudents()
        {
            //Get all the User Data for the user_infor table and Convert it to a list/collection
            return Users = await _data.user_info.ToListAsync();
        }

        //Method for getting a specific User data from user_info table
        public async Task<User> GetUser(int userId)
        {
            //Get the User Data if the userId is equal to the user.Id in the user_info table
            return user = await _data.user_info.Where(u => u.Id == userId).FirstOrDefaultAsync();
        }

        //Method for updating a specific User data from user_info table
        public async Task<List<User>> UpdateUser(User user)
        {
            //store a list of User from the user_info table
            Users = await _data.user_info.ToListAsync();
            //find a User where user.id is equal to the User.id in the user_infor table
            var dbUser = await _data.user_info.FindAsync(user.Id);
            //check if there is a specific user
            if (dbUser != null)
            {
                //Get the the user from the table and update its value
                _data.Entry(dbUser).CurrentValues.SetValues(user);
                //Save the changes to the database
                await _data.SaveChangesAsync();
            }
            //return the list of user
            return Users;
        }

        //Method for Removing a specific User data from user_info table
        public async Task<List<User>> RemoveUser(User user)
        {
            //remove the user from the database
            //the user that's passed needs to have and Id for this to work
            _data.user_info.Remove(user);
            //Save the changes to the database
            await _data.SaveChangesAsync();
            //return a List of User Data
            Users = await _data.user_info.ToListAsync();
            return Users;
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SPMSOJT.Server.Service.UserService;
using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Server.Controllers
{
    //the route or url are the words you used as ClassName
    //ex. UserController route/url will be api/user
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        //dependecy injection variable
        private readonly IUserService _userService;

        //constructor for the injection of IUserService located at SPMJSOJT.Server/Service/UserService
        //Use as a connection between the UserService Class and UserController
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        //Create New instance of List of User
        List<User> Users = new List<User>();
        //Create new instance of User
        User user = new User();

        //HttPost will be the API accessor
        //api/user/create will be the route for the API
        [HttpPost("create")]
        public async Task<ActionResult<List<User>>> LoginUser(User user)
        {
            //send the user to the UserService.AddUser and get the List of Users after
            return Users = await _userService.AddUser(user);
        }

        //HttPost will be the API accessor
        //api/user/update will be the route for the API
        [HttpPost("update")]
        public async Task<ActionResult<List<User>>> UpdateUser(User user)
        {
            //send the user to the UserService.UpdateUser and get the List of Users after
            return Users = await _userService.UpdateUser(user);
        }

        //HttPost will be the API accessor
        //api/user/delete will be the route for the API
        [HttpPost("delete")]
        public async Task<ActionResult<List<User>>> DeleteUser(User user)
        {
            //send the user to the UserService.RemoveUser and get the List of Users after
            return Users = await _userService.RemoveUser(user);
        }

        //HttpGet will be the API accessor
        //api/user/displayall will be the route for the API
        [HttpGet("displayall")]
        public async Task<ActionResult<List<User>>> GetAllStudent()
        {
            //send the user to the UserService.LoadAllStudents and get the List of Users after
            return Users = await _userService.LoadAllStudents();
        }

        //HttpGet will be the API accessor
        //api/user/display/Id will be the route for the API
        //The id needs to be an integer to access the route
        [HttpGet("display/{Id:int}")]
        public async Task<ActionResult<User>> GetAllStudent(int Id)
        {
            //send the user to the UserService.GetUser and get the List of Users after
            return user = await _userService.GetUser(Id);
        }
    }
}

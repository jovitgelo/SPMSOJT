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
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        List<User> Users = new List<User>();
        User user = new User();

        [HttpPost("create")]
        public async Task<ActionResult<List<User>>> LoginUser(User user)
        {
            return Users = await _userService.AddUser(user);
        }

        [HttpPost("update")]
        public async Task<ActionResult<List<User>>> UpdateUser(User user)
        {
            return Users = await _userService.UpdateUser(user);
        }

        [HttpPost("delete")]
        public async Task<ActionResult<List<User>>> DeleteUser(User user)
        {
            return Users = await _userService.RemoveUser(user);
        }

        [HttpGet("displayall")]
        public async Task<ActionResult<List<User>>> GetAllStudent()
        {
            return Users = await _userService.LoadAllStudents();
        }

        [HttpGet("display/{Id:int}")]
        public async Task<ActionResult<User>> GetAllStudent(int Id)
        {
            return user = await _userService.GetUser(Id);
        }
    }
}

using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SPMSOJT.Client.Service.UserService
{
    public class UserService : IUserService
    {
        //dependecy injection varibale of HttpClient
        private readonly HttpClient _http;

        //construstor for the dependecy injection
        //HttpClient is used for the connection between the Client Service and The Server Controller located at SPMSOJT.Server/Controller
        public UserService(HttpClient http)
        {
            _http = http;
        }

        //Method for the connection of the LoginUser Method located at SPMSOJT.Server/Controller/UserController
        //api/user/ is the controller url of UserController
        public async Task<List<User>> AddUser(User user)
        {
            //Serialized the user object as JSON then use POST to send it at api/user/create
            var result = await _http.PostAsJsonAsync("api/user/create", user);
            //Deserialized the result after the POST and store it at the status variable 
            var status = await result.Content.ReadFromJsonAsync<List<User>>();
            return status;
        }

        //Method for the connection of the DeleteUser Method located at SPMSOJT.Server/Controller/UserController
        public async Task<List<User>> DeleteUser(User user)
        {
            //Serialized the user object as JSON then use POST to send it at api/user/delete
            var result = await _http.PostAsJsonAsync("api/user/delete", user);
            //Deserialized the result after the POST and store it at the status variable 
            var status = await result.Content.ReadFromJsonAsync<List<User>>();
            return status;
        }

        //Method for the connection of the GetAllStudent Method located at SPMSOJT.Server/Controller/UserController
        public async Task<List<User>> GetAllUser()
        {
            //Send a GET and deserialized the JSON response and store it in the result variable
            var result = await _http.GetFromJsonAsync<List<User>>($"api/user/displayall");
            return result;
        }

        //Method for the connection of the GetStudent Method located at SPMSOJT.Server/Controller/UserController
        public async Task<User> GetUser(int Id)
        {
            //Send a GET and add the student id to the url string and deserialized the JSON response and store it in the result variable
            var result = await _http.GetFromJsonAsync<User>($"api/user/display/{Id}");
            return result;
        }

        //Method for the connection of the UpdateUser Method located at SPMSOJT.Server/Controller/UserController
        public async Task<List<User>> UpdateUser(User user)
        {
            //Serialized the user object as JSON then use POST to send it at api/user/update
            var result = await _http.PostAsJsonAsync("api/user/update", user);
            //Deserialized the result after the POST and store it at the status variable 
            var status = await result.Content.ReadFromJsonAsync<List<User>>();
            return status;
        }
    }
}

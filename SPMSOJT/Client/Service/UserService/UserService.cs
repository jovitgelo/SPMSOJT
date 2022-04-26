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
        private readonly HttpClient _http;

        public UserService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<User>> AddUser(User user)
        {
            var result = await _http.PostAsJsonAsync("api/user/create", user);
            var status = await result.Content.ReadFromJsonAsync<List<User>>();
            return status;
        }

        public async Task<List<User>> DeleteUser(User user)
        {
            var result = await _http.PostAsJsonAsync("api/user/delete", user);
            var status = await result.Content.ReadFromJsonAsync<List<User>>();
            return status;
        }

        public async Task<List<User>> GetAllUser()
        {
            var result = await _http.GetFromJsonAsync<List<User>>($"api/user/displayall");
            return result;
        }

        public async Task<User> GetUser(int Id)
        {
            var result = await _http.GetFromJsonAsync<User>($"api/user/display/{Id}");
            return result;
        }

        public async Task<List<User>> UpdateUser(User user)
        {
            var result = await _http.PostAsJsonAsync("api/user/update", user);
            var status = await result.Content.ReadFromJsonAsync<List<User>>();
            return status;
        }
    }
}

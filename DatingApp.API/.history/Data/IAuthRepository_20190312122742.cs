 using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public interface IAuthRepository
    {
        async    Task<User> Register(User user,string password);
    async    Task<User> Login(string username,string password);
        async Task<bool> UserExists(string username);
    }
}
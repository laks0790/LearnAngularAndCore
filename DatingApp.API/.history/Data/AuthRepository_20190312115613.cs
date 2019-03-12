using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data {
    public class AuthRepository : IAuthRepository {
 

        public Task<User> Register(User user, string password)
        {
            throw new System.NotImplementedException();
        }

        Task<User> IAuthRepository.Login(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        Task<bool> IAuthRepository.UserExists(string username)
        {
            throw new System.NotImplementedException();
        }

        Task<User> IAuthRepository.Login(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        Task<bool> IAuthRepository.UserExists(string username)
        {
            throw new System.NotImplementedException();
        }
    }
}
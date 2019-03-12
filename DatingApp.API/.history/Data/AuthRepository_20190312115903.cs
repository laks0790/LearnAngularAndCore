using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data {
    public class AuthRepository : IAuthRepository {

public AuthRepository(DataContext context)
{
    
}
        public Task<User> Register(User user, string password)
        {
           
        }

        

        Task<bool> IAuthRepository.UserExists(string username)
        {
            throw new System.NotImplementedException();
        }

        Task<User> IAuthRepository.Login(string username, string password)
        {
            throw new System.NotImplementedException();
        }

 
    }
}
using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data {
    public class AuthRepository : IAuthRepository {
        public DataContext _context { get; }

        public AuthRepository (DataContext context) {
            _context= context;

        }
        public Task<User> Register (User user, string password) {
              byte [] passwordHash,passwordSalt;
           CreatePasswordHash(password,out passwordHash,out passwordSalt);

        }

        Task<bool> IAuthRepository.UserExists (string username) {
            throw new System.NotImplementedException ();
        }

        Task<User> IAuthRepository.Login (string username, string password) {
            throw new System.NotImplementedException ();
        }

    }
}
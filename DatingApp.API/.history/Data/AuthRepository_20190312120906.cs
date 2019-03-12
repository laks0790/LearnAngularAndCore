using System;
using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data {
        public class AuthRepository : IAuthRepository {
                private DataContext _context;

                public AuthRepository (DataContext context) {
                    _context = context;

                }
                public async Task<User> RegisterAsync (User user, string password) {
                        byte[] passwordHash, passwordSalt;
                        CreatePasswordHash (password, out passwordHash, out passwordSalt);
                        user.PasswordHash = passwordHash;
                        user.PasswordSalt = passwordSalt;
                        await _context.Users.AddAsync(user);
                     await _context.SaveChangesAsync();
        }

        private void CreatePasswordHash (string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac =new  System.Security.Cryptography.HMACSHA512 ())
           {
               passwordSalt=hmac.Key;
               passwordHash=hmac.ComputeHash ( System.Text.Encoding.UTF8.GetBytes (password));
           }
        }

        Task<bool> IAuthRepository.UserExists (string username) {
            throw new System.NotImplementedException ();
        }

        Task<User> IAuthRepository.Login (string username, string password) {
            throw new System.NotImplementedException ();
        }

    }
}
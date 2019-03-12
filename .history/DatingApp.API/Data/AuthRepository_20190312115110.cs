namespace DatingApp.API.Data {
    public class AuthRepository : IAuthRepository {
        public Task<User> Register (User user, string password) {

        }
        public Task<User> Login (string username, string password) {

        }
        public Task<bool> UserExists (string username) {

        }
    }
}
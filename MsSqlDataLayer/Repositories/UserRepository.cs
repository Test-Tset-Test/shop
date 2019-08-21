using System.Linq;
using Contracts.Data;
using DataModels;

namespace MsSqlDataLayer.Repositories
{
    public class UserRepository : MsSqlRepository, IUserRepository
    {
        public UserRepository(MsSqlContext context) : base(context)
        {
        }

        public bool CreateUser(User data)
        {
            // validation
            if (string.IsNullOrWhiteSpace(password))
                return false;
            if (context.Users.Any(x => x.Login == data.Login))
                return false;
            var hmac = new System.Security.Cryptography.HMACSHA512();
             byte[] passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            data.Password = passwordHash;
            context.Users.Add(data);

//            context.SaveChanges();
            return false;
        }

        public bool LoginUser(string login, string password)
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
                return false;
            var user = context.Users.SingleOrDefault(x => x.Password == password);

            // check if username exists
            if (user == null)
                return false;

            
            return true;
        }

        /*private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            if (password == null) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");

            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }*/
    }
}
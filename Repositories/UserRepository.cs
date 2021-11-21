using System.Collections.Generic;
using System.Linq;
using RefreshTokenAuth.Models;

namespace RefreshTokenAuth.Repositories
{
  public class UserRepository
    {
         public static User Get(string username, string password)
        {
            var users = new List<User>
            {
                new User {Id = 1, Username = "Mateus", Password = "mateus", Role = "manager"},
                new User {Id = 2, Username = "Macedo", Password = "macedo", Role = "employee"}
            };

            return users.FirstOrDefault(x => x.Username == username && x.Password == password);
        }
    }
}

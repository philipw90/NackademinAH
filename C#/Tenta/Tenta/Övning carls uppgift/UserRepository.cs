using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenta.Övning_carls_uppgift
{
    public class UserRepository : IUserRepository
    {
        //User _user = new User();
            
        //public List<User> CreaterUser(string name, string password, string email)
        //{
        //    User newUser = new User();
        //    List<User>users = new List<User>();
        //    _user.Name = name;
        //    _user.Password = password;
        //    _user.Email = email;
        //    users.Add(newUser);
        //    return users;
        //}

        public void DeleteUser(string email)
        {

        }

        public User CreateUser(string name, string password, string email)
        {
            var user = new User
            {
                Name = name,
                Password = password,
                Email = email
            };
            return user;

        }
    }
}

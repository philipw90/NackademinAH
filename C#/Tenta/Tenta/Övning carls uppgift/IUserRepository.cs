using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tenta.Övning_carls_uppgift
{
    public interface IUserRepository
    {
        //List<User>CreaterUser(string name, string password, string email);

        void DeleteUser(string email);

        User CreateUser(string name, string password, string email);

    }
}

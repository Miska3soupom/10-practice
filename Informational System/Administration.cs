using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informational_System
{
    internal class Administration
    {
        public int Id;
        public string Login, Password;
        public Role Role;

        public Administration(int id, string login, string password, Role role)
        {
            this.Id = id;
            this.Login = login;
            this.Password = password;
            this.Role = role;
        }
        Administration() { }
    }
}

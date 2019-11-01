using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlak.Models
{
    public class User
    {

        public string Username { get; set; }
        public string Password { get; set; }

        public User()
        {

        }

        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }

    }
}

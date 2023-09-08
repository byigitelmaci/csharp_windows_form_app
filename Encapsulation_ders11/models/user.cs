using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_ders11.models
{
    internal class user
    {
        public user(string _username,string password)
        {
            Username = _username;
            Password = password;
        }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}

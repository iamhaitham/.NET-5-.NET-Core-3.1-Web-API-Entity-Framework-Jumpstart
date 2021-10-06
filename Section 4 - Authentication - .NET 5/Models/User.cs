using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Section_1___Introduction___.NET_5.Models
{
    public class User
    {
        public int Id {set;get;}
        public string Username {set;get;}
        public byte[] PasswordHash {set;get;}
        public byte[] PasswordSalt {set;get;}
    }
}
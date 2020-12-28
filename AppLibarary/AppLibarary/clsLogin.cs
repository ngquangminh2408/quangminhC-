using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLibarary
{
    class clsLogin
    {
        string user;
        string pass;

        public string User { get => user; set => user = value; }
        public string Pass { get => pass; set => pass = value; }
        public clsLogin()
            {

            }
        public clsLogin(string user,string pass)
        {
            this.User = user;
            this.Pass = pass;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHOCSINH.DTO
{
    class ACCOUNT
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string DisplayName { get; set; }

        public ACCOUNT() { }

        public ACCOUNT(string UserName, string Password, string DisplayName)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.DisplayName = DisplayName;
        }
    }
}

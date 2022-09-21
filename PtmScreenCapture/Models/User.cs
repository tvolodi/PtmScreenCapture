using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PtmScreenCapture.Models
{
    internal class User : BaseMongoDoc
    {
        public string Login    { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }

        public UserRole Role { get; set; } = new UserRole();

        public bool Equals(User user)
        {
            if(user == null) return false;

            if(this.Login != user.Login) return false;
            if(this.Password != user.Password) return false;
            if(this.UserName != user.UserName) return false;
            if(this.Role.Name != user.Role.Name) return false;

            return true;
        }


    }
}

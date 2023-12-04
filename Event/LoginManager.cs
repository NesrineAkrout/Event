using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class LoginManager
    {

        public event EventHandler<UserEventArgs> UserLoginSuccsessful;
        public void login(User user)
        {
            if (!user.Email.EndsWith("@example.com"))
            {
                return;
            }

            OnUserloginSuccessful(user);

        }
        public void OnUserloginSuccessful(User user)
        {
            if (UserLoginSuccsessful != null)
                UserLoginSuccsessful.Invoke(this, new UserEventArgs(user));
        }
    }

    public class UserEventArgs : EventArgs
    {
        public User User { get; set; }
        public UserEventArgs(User user)
        {
            User = user;
        }
    }

}

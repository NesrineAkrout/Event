using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User(1, "Ali", "dd", "@example.com");
            LoginManager loginManager = new LoginManager();

            loginManager.UserLoginSuccsessful += LoginManager_UserLoginSuccsessful;

            loginManager.login(user);


        }

        private static void LoginManager_UserLoginSuccsessful1(object sender, UserEventArgs e)
        {
            throw new NotImplementedException();
        }

        private static void LoginManager_UserLoginSuccsessful(object sender, UserEventArgs e)
        {
            Console.WriteLine($"Welcome {e.User.FirstName} {e.User.LastName}");
        }

      
    }
}

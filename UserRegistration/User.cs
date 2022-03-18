using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class User : IUser
    {
        public string  email = "manoj@gmail.com", password = "12345678";
        public int age = 23;

        private readonly IUser user;
        public User(IUser user)
        {
            this.user = user;
        }

        public string UserChecker(string email, string password )
        {
            if(email == "manoj@gmail.com"  && password == "12345678")
            {
                return "Entered Details / Logging Succesfull";
            }
            else
            {
                return "Entered Invalid Details";
            }
        }
        public string AgeChecker(int age)
        {
            if(age >= 18)
            {
                return "Welcome";
            }
            else
            {
                return "Invalid Age";
            }
        }
    }
}

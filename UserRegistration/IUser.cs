using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public interface IUser
    {
        
        public string UserChecker(string email, string password);

        public string AgeChecker(int age);
       
    }
}

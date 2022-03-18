using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer 
{
    public  class MoodLogicClass : IAnalyzer
    {
        public string MoodChecker()
        {
            return "Checking Mood";  

        }
        public string IsHappy(string mood)
        {
            if("Happy"== mood)
            {
                return "Your Are Happy";
            }
            else
            {
                return "Your are Not Happy";
            }
        }

    }
}

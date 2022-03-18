using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public interface IAnalyzer
    {
        public string MoodChecker();
        public string IsHappy(string mood);
        
    }
}

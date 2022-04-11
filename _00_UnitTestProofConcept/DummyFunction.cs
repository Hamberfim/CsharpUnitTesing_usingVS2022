using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_UnitTestProofConcept
{
    public class DummyFunction
    {
        // assumed use case is that this function must always return an Affirmative response -
        // a critical business function in the app requires the ReturnAffirmative() function input to be a Zero
        public string ReturnAffirmative(int number)
        {
            if(number == 0) {
                return "Affirmative Zero";
            }
            else
            {
                return "Not Zero";
            }   
        }
    }
}

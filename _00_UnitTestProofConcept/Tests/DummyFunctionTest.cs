using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_UnitTestProofConcept.Tests
{
    public class DummyFunctionTest
    {
        // be mindful of naming conventions -  ClassName_MethodName_ExpectedResult
        public static void DummyFunction_ReturnAffirmative_ReturnsString()
        {
            try
            {
                // Arrange: Get the variables, functions, classes
                int number = 0;  // for test to pass - must be zero
                DummyFunction dummyFunction = new DummyFunction();


                // Act: Execute 
                string result = dummyFunction.ReturnAffirmative(number);

                // Assert: is what's return what is expected?
                if (result == "Affirmative Zero")
                {
                    // pass
                    Console.WriteLine($"PASSED! DummyFunction_ReturnAffirmative_ReturnsString returned {result}");
                }
                else
                {
                    Console.WriteLine($"FAILED! Expected: 'Affirmative Zero', Actual: {result}");
                }


            }
            catch (Exception exception)
            {
                Console.WriteLine($"Excpetion: {exception}");
            }
        }
    }
}

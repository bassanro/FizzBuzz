using System;

namespace FizzBuzzModels
{
    public class FizzBuzzDto
    {

        public static string GetResult(int value)
        {
            // This method will fail and assert that our test case fail.
            //throw new NotImplementedException();

            //return string.Empty;
            if (value%15 == 0)
            {
                return "FizzBuzz";
            }
            else if (value%3 ==0)
            {
                return "Fizz";
            }
            else if (value %5 ==0)
            {
                return "Buzz";
            }
            return value.ToString();
        }
    }
}

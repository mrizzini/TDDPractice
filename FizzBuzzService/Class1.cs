using System;

namespace FizzBuzz.Service
{
    public class FizzBuzzer
    {
        public static string GetValue(int input)
        {
            string result = input.ToString();

            if (input % 3 == 0 && input % 5 == 0)
                result = "FizzBuzz";

            else if (input % 3 == 0)
                result = "Fizz";
            
            else if (input % 5 == 0)
                result = "Buzz";

            return result;
            
        }
    }
}

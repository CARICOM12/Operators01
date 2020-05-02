using System;

namespace Operators01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int result, remainder;
            result = 10 / 3;
            remainder = 10 % 3;
            Console.WriteLine(result, remainder);
            //Why in the output it gives 4 instead of two numbers
        }
    }
}

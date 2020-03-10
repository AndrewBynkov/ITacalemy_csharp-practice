using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            short number1 = 10;
            object num = number1;

            sbyte result = (sbyte)(short)num;
            Console.WriteLine(result);
        }
    }
}

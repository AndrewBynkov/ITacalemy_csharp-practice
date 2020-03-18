using System;

namespace Lect_5.Greeting_2
{
    class Program
    {
        private static char symb;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter you name");
            string myName = Console.ReadLine();
            int i = 0;

            foreach (char symb in myName) 
            {
                if (symb == 'a')
                {
                    i++;
                }
            }
            Console.WriteLine("The number of letters 'a' in this word is :" + i);
        }
    }
}

using System;

namespace Lect_5.Task1
{
    class Program
    {
        static void Task_1()
        {
            int[] array1 = new int[100];
            Console.WriteLine(array1);
            // выделяется память под 100 элементов но они не заполненны.
        }

        static void Task_2()
        {
            object[] array2 = new object[] { 32, 'A', "Hello" };
            Console.WriteLine(string.Join("\n", array2));
            object sum = 0;
 
            {
               for (int i = 0; i<array2.Length; i++)
                {
                    array2[0] = 1;
                    array2[2] = "Andrew";
                }

                Console.WriteLine();
                Console.WriteLine(string.Join("\n", array2));
                Console.WriteLine();

            }
        }
        static void Task_3()
        {
            int[] array3 = new int[13];
            Random rand = new Random();
            {
                for (int i = 0; i < array3.Length; i++)
                {
                    array3[i] = rand.Next();
                 

                }
                Console.WriteLine(string.Join("\n", array3));
                Console.WriteLine();

             
                

            }
        }

        static void Main(string[] args)
        {
            Task_1();
            Task_2();
            Task_3();
        }
        
     
    }

}

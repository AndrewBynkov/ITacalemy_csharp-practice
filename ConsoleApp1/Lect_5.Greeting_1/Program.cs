using System;

public class Program
{
    public static void Main()
    {
        TimeSpan dat = (DateTime.Now.TimeOfDay);
        int tim = DateTime.Now.Hour;

        if (tim <= 8)
        {
            Console.WriteLine("Good night,gyus ");
        }
        else if (tim >= 9 && tim <= 12)
        {
            Console.WriteLine("Good morning,gyus ");
        }
        else if (tim >= 13 && tim <= 15)
        {
            Console.WriteLine("Good day,gyus ");
        }
        else if (tim >= 16 && tim <= 22)
        {
            Console.WriteLine("Good evning,gyus ");
        }
        else
        {
            Console.WriteLine($"Error! Time is incorrect: {tim} ");
        }

    }
}

using System;
namespace Chapter5
{
    public class Question3
    {
        public static void Answer()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine(a + " is the biggest");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine(b + " is the biggest");
            }
            else if (c > b && c > a)
            {
                Console.WriteLine(c + " is the biggest");
            }
            else
            {
                Console.WriteLine("The numbers are equal to one another");
            }
        }
    }
}
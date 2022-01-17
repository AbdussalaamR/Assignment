using System;
namespace Chapter5
{
    public class Question7
    {
        public static void Answer()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int e = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c && a > d && a > e)
            {
                Console.WriteLine(a + " is the biggest");
            }
            else if (b > a && b > c && b > d && b> e)
            {
                Console.WriteLine(b + " is the biggest");
            }
            else if (c > b && c > a && c > d && c > e)
            {
                Console.WriteLine(c + " is the biggest");
            }
            else if (d > a && d > b && d > c && d > e)
            {
                Console.WriteLine(d + " is the biggest");
            }
             else if (e > a && e > b && e > c && e > d)
            {
                Console.WriteLine(e + " is the biggest");
            }
            else
            {
                Console.WriteLine("The numbers are equal to one another");
            }
        }
    }
}
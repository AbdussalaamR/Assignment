using System;
namespace Chapter5
{
    public class Question4
    {
        public static void Answer()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b && b > c)
            {
                Console.WriteLine("The order of the letters in descending order is " + a + ", " + b + ", " + c );
            }
            else if (b > a && a > c)
            {
                Console.WriteLine("The order of the letters in descending order is " + b + ", "+ a + ", " + c );
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("The order of the letters in descending order is " + c + ", "+ a + ", " + b );
            }
            else if (a > c && c > b)
            {
                Console.WriteLine("The order of the letters in descending order is " + a + ", "+ c + ", " + b );
            }
            else if (b > c && c > a)
            {
                Console.WriteLine("The order of the letters in descending order is " + b + ", "+ c + ", " + a );
            }
            else
            {
                Console.WriteLine("The order of the letters in descending order is " + c + ", "+ b + ", " + a );
            }
            
        }
    }
}
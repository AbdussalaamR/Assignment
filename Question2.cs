using System;
namespace Chapter5
{
    public class Question2
    {
        public static void Answer()
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int c = Convert.ToInt32(Console.ReadLine());
                if (a < 0 && b > 0 && c > 0)
                {
                    Console.WriteLine( "product of the three numbers is \'-\'");
                }
                 else if (b < 0 && a > 0 && c > 0)
                {
                    Console.WriteLine( "product of the three numbers is \'-\'");
                }
                 else if (c < 0 && b > 0 && a > 0)
                {
                    Console.WriteLine( "product of the three numbers is \'-\'");
                }
                else
                {
                  Console.WriteLine( "product of the three numbers is \'+\'");  
                }
            }
    }
}
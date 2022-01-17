using System;
namespace Chapter5
{
    public class Question9
    {
        public static void Answe()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int e = Convert.ToInt32(Console.ReadLine());
            
            if (a + b == 0)
            {
                Console.Write("Subset a + b == 0");
            }
           else if (a + c == 0)
            {
                Console.Write("Subset a + c == 0");
            }
           else if (a + d == 0)
            {
                Console.Write("Subset a + d == 0");
            }
               else if (a + e == 0)
            {
                Console.Write("Subset a + e == 0");
            }
               else if (b+ c == 0)
            {
                Console.Write("Subset b+ c == 0");
            }
               else if (b + d == 0)
            {
                Console.Write("Subset b + d == 0");
            }
               else if (b + e == 0)
            {
                Console.Write("Subset b + e == 0");
            }
               else if (c + d == 0)
            {
                Console.Write("Subset c + d == 0");
            }
               else if (c + e == 0)
            {
                Console.Write("Subset c + e == 0");
            }
               else if (d + e == 0)
            {
                Console.Write("Subset d + e == 0");
            }
           else if (a + b + c == 0)
            {
                Console.Write("Subset a + b + c == 0");
            }
            else if (a + b + d == 0)
            {
                Console.Write("Subset a + b + d == 0");
            }
            else if (a + b + e == 0)
            {
                Console.Write("Subset a + b + e == 0");
            }
               else if (a + c + d == 0)
            {
                Console.Write("Subset a + c + d == 0");
            }
               else if (a+ c + e == 0)
            {
                Console.Write("Subset a + c + e == 0");
            }
               else if (a + d + e == 0)
            {
                Console.Write("Subset a+ d + e == 0");
            }
                else if (b + c + d == 0)
            {
                Console.Write("Subset b + c + d == 0");
            }
               else if (b + c + e == 0)
            {
                Console.Write("Subset b + c + e == 0");
            }
                else if (c + d + e == 0)
            {
                Console.Write("Subset c + d + e == 0");
            }

        }
    }
}
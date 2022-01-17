using System;
namespace Chapter5
{
    public class Question8
    {
        public static void Answer()
            {
            Console.Write("Enter 1 if you wish the value you wish to enter is int, 2 if double and 3 if text: ");
              int num = Convert.ToInt32(Console.ReadLine());
              if (num == 1 || num == 2)
              {
                  Console.Write("Enter your number: ");
                  Double value = Convert.ToDouble(Console.ReadLine());
                  Console.WriteLine(value + 1);
              }
              else if (num == 3)
              {
                  Console.Write("Enter your text: ");
                  string text = Console.ReadLine();
                  Console.WriteLine('*');

              }
            }
        
    }
}
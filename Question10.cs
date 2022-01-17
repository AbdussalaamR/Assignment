using System;
namespace Chapter5
{
    public class Question10
    {
        public static void Answer()
        {
            Console.Write("Enter score: ");
            int score = Convert.ToInt32(Console.ReadLine());
            if (score > 0 && score <= 3)
            {
                Console.Write("New score is: " + score * 10);
            }
            else if (score >=4 && score <= 6)
            {
                Console.Write("New score is: " + score * 100);
            }
            else if (score >=7 && score < 9)
            {
                Console.Write("New score is: " + score * 1000);
            }
            else if (score == 0 || score > 9)
            {
                Console.Write("Invalid entry");
            }
        }
    }
}
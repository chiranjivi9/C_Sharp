using System;

namespace MyFirstProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int randomNumber1 = randomNumber.Next(2, 11);
            int randomNumber2 = randomNumber.Next(2, 11);
            int answer, computedAnswer;



            Console.Write("What is the answer for " + randomNumber1 + " * " + randomNumber2 + "? \n");
            answer = Convert.ToInt32(Console.ReadLine());
            computedAnswer = (randomNumber1 * randomNumber2);
            if (answer == computedAnswer)
            {
                Console.Write("You are right!");
            }
            else
            {
                Console.Write("The correct answer is: " + computedAnswer);
            }

        }
    }
}
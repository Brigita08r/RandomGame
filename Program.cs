using System;

namespace RandomGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random RandomClass = new Random();
            int x = RandomClass.Next(1, 10);

            Console.WriteLine("Guess the number between 1 and 10");
            int guess = 0;

            while (guess != x)
            {
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess == x)
                {
                    Console.WriteLine("well done!");
                    
                }
                else if (guess != x)
                {
                    if (guess < x)
                    {
                        Console.WriteLine("Number is higher");
                        
                    }
                    else if (guess > x)
                    {

                        Console.WriteLine("Nope, the number is lower");
                        
                    }
                } 

            }
        }
    }
}

using System;

namespace brackeysbeg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Skynet";
            Console.ForegroundColor = ConsoleColor.Green;
            //Console.WindowHeight = 40; //40 lines tall
            /*
            Console.WriteLine("Hello, what's your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}, my name is Luis!");

            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter first number: ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.WriteLine($"Your numbers where: {num1}, {num2} and {num3}");
            double avg = (num1+num2+num3)/3;
            Console.WriteLine("The average of your numbers is " + avg);
            */
            
            Random numberGen = new Random();

            int guess = 0;
            int attempts = 1;
            int ans = numberGen.Next(1,6);
            Console.WriteLine($"Answer is {ans}");
            Console.Write("Guess a number from 1 to 5: ");
            guess = Convert.ToInt32(Console.ReadLine());

            while(guess != ans){
                if(guess>ans){Console.WriteLine("Too High!");}
                else{Console.WriteLine("Too Low!");}
                Console.Write("Try again: ");
                guess = Convert.ToInt32(Console.ReadLine());
                attempts++;
            }

            Console.WriteLine($"You guessed the answer in {attempts} trys!");

            Console.ReadKey();
        }
    }
}


using System;

namespace Snake_and_Ladder_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int RollDice = random.Next(1, 7);
            Console.WriteLine("Welcome to Snake & Ladder Game!");
            Console.WriteLine("Roll the Dice:" +RollDice);
        }

    }

}
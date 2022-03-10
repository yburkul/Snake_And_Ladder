
using System;

namespace Snake_and_Ladder_Program
{
    class Program
    {
      
        public const int No_Play = 0;
        public const int Ladder = 1;
        public const int Snake = 2;
        static void Main(string[] args)
        {
            Random random = new Random();
            int RollDice = random.Next(1, 7);
            int SnakeLadder = random.Next(0, 3);
            Console.WriteLine("Welcome to Snake & Ladder Game!");
            Console.WriteLine("Roll the Dice:" +RollDice);
            Console.WriteLine("Snake Ladder: " + SnakeLadder);
            switch (SnakeLadder)
            {
                case No_Play:
                   Console.WriteLine("No Play");
                    break;
                case Ladder:
                    Console.WriteLine("The Player moves ahead");
                    break;
                case Snake:
                    Console.WriteLine("The Player moves behind");
                    break;
            }
        }

    }

}
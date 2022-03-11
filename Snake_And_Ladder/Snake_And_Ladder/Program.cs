
using System;

namespace Snake_and_Ladder_Program
{
    class Program
    {
        public const int No_Play = 0;
        public const int Ladder = 1;
        public const int Snake = 2;
        public const int Start_Player_Position = 0;
        public const int Winning_Player_Position = 100;
        static void Main(string[] args)
        {
            int Position = 0;
            int Count_Dice = 0;
            Console.WriteLine("Welcome to Snake & Ladder Game!");
            Console.WriteLine("Start Position of Player: " + Start_Player_Position);
            for (int Position_Move = Start_Player_Position; Position_Move <= Winning_Player_Position; Position_Move++)
            {
                Random random = new Random();
                int RollDice = random.Next(1, 7);
                int SnakeLadder = random.Next(0, 3);
                Console.WriteLine("Snake Ladder: " + SnakeLadder);
                switch (SnakeLadder)
                {
                    case No_Play:
                        Console.WriteLine("No Play");
                        Count_Dice++;
                        break;
                    case Ladder:
                        Console.WriteLine("The Player moves ahead");
                        Position += RollDice;
                        Count_Dice++;   
                        break;
                    case Snake:
                        Console.WriteLine("The Player moves behind");
                        Position -= RollDice;
                        Count_Dice++;
                        break;
                }
                Position_Move = Position;
                if (Position_Move < Start_Player_Position)
                {
                    Position_Move = Start_Player_Position;
                }
                else if (Position_Move > Winning_Player_Position)
                {
                    Position_Move = Position - RollDice;
                }
                else
                {
                    Position_Move = Position;
                }
                Console.WriteLine("Roll the Dice: " + RollDice);
                Console.WriteLine("Player Win: " + Position_Move);
                Console.WriteLine("Total Number of Dice: " + Count_Dice);
            }
        }

    }

}
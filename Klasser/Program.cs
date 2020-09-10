using System;

namespace Klasser
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] ballStartPos ={1.0f, 2.0f};
            Football ball = new Football(ballStartPos);

            string[] names = {"a","b","c","d","e","f","g","h","i","j"};
            Player[] players = new Player[10];
            for (int i = 0; i < 10; i++)
            {
                players[i] = new Player(names[i]);                
            }

            System.Console.WriteLine($"Instantiated ball at {ball.GetPos()}");

            System.Console.Write("Instantiated 10 players with names: ");
            for (int i = 0; i < names.Length-2; i++)
            {
                Console.Write($"{players[i].GetName()}, ");
            }
            System.Console.WriteLine(players[players.Length-1].GetName());
            Console.ReadLine();
        }
    }
}

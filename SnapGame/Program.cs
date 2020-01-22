using System;

namespace SnapGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snap Game!!!!");
            Console.WriteLine("Enter number of packs:");
            string numberOfPacks = Console.ReadLine();
            Console.WriteLine("Enter type of Game 0-FaceMatch, 1-SuitMatch, 2-AllMatch:");
            string typeOfGame = Console.ReadLine();
            Game game = new Game(Convert.ToInt32(numberOfPacks), (GameType)Enum.Parse(typeof(GameType), typeOfGame));
            game.Play();
        }
    }
}

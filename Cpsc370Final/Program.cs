using System.Text.RegularExpressions;

namespace Cpsc370Final;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length < 1)
                    Console.WriteLine("Usage: Cpsc370Final <arguments>");
        
        PlayerTurns game = new PlayerTurns();
        string input;
        string inputNum;
        if (args[0] == "0")
        {
            do
            {
                Console.WriteLine("Please enter a mystery word for the AI to guess (use letters only):"); 
                input = Console.ReadLine();
            } while (!Regex.IsMatch(input, @"^[a-zA-Z]+$"));
            
            do
            {
                Console.WriteLine("Please enter the number of lives for the AI (use numbers only):");
                inputNum = Console.ReadLine();
            } while(!Regex.IsMatch(inputNum, @"^[0-9]+$"));
            
            HangmanAI.SolvePuzzle(input, Int32.Parse(inputNum));
        }
        else if (args[0] == "1")
        {
            WordGenerator wordGenerator = new();
            wordGenerator.GenerateWordForGame(new Random());
            game.SetupGame(wordGenerator.RandomWord);
            game.RunGame();
        }
        else if (args[0] == "2")
        {
            do
            {
                Console.WriteLine("Player 1: please enter the word for player 2 to guess (use letters only):"); 
                input = Console.ReadLine();
            } while (!Regex.IsMatch(input, @"^[a-zA-Z]+$"));
            game.SetupGame(input);
            game.RunGame();
        }
        else
        {
            Console.WriteLine("Invalid argument. Please enter 0 for AI mode, 1 for single player, or 2 for multiplayer.");
        }
    }
}
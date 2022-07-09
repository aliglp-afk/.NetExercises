using System;
namespace XO
{
    class Program{
        public static void Main(string[] args)
        {
            Game game=new Game();
            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine($"Press P to play ");
            Console.ForegroundColor=ConsoleColor.White;
            while(Console.ReadKey().KeyChar.ToString().ToLower()=="p"){
                Console.Clear();
                game.Play();
            }
            
            
        }
    }
}
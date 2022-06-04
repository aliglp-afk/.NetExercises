using System;
namespace HangedMan{
    class Program{
        public static void Main(string[] args)
        {
            Console.WriteLine("Press {P} to Play {Q} to Quit");
            ConsoleKeyInfo cki=Console.ReadKey();
            while(cki.KeyChar.ToString().ToUpper()=="P"){
                Game.Play();
                Console.WriteLine("Try Again? Press {P}");
                cki=Console.ReadKey();
            }
        }
    }
    
}
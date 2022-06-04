using System;

namespace HangedMan
{
    public static class Game{
        public static List<string> Words=new List<string>{"focus","happy","energy","today",
        "persist","improve","apple","banana","yellow","actor","home","great","proxy","scared","connect","wonder","vision","journey","forward"
        ,"present","meditate","celebrate","forgive","ambition","simple","protected","heart"};
        public static List<string> Steps=new List<string>();
        public static List<char> Wrong=new List<char>();
        public static int Rights {get;set;}
        public static int Attempts{get;set;}
        public static void GameInit(){
            Game.Attempts=1;
            Game.Rights=0;
            Game.Wrong=new List<char>();

            string hang7="";
            hang7+= "  +++++++             \n";
            hang7+= "  |     0             \n";
            hang7+= "  |    /|\\            \n";
            hang7+= "  |    / \\            \n";
            hang7+= " ===                  \n";
            //////////////////////////////////
            string hang6="";
            hang6+= "  +++++++             \n";
            hang6+= "  |     0             \n";
            hang6+= "  |    /|\\            \n";
            hang6+= "  |    /              \n";
            hang6+= " ===                  \n";
            //////////////////////////////////
            string hang5="";
            hang5+= "  +++++++             \n";
            hang5+= "  |     0             \n";
            hang5+= "  |    /|\\            \n";
            hang5+= "  |                   \n";
            hang5+= " ===                  \n";
            //////////////////////////////////
            string hang4="";
            hang4+= "  +++++++             \n";
            hang4+= "  |     0             \n";
            hang4+= "  |    /|             \n";
            hang4+= "  |                   \n";
            hang4+= " ===                  \n";
            //////////////////////////////////
            string hang3="";
            hang3+= "  +++++++             \n";
            hang3+= "  |     0             \n";
            hang3+= "  |    /              \n";
            hang3+= "  |                   \n";
            hang3+= " ===                  \n";
            //////////////////////////////////
            string hang2="";
            hang2+= "  +++++++             \n";
            hang2+= "  |     0             \n";
            hang2+= "  |                   \n";
            hang2+= "  |                   \n";
            hang2+= " ===                  \n";
            //////////////////////////////////
            string hang1="";
            hang1+= "  +++++++             \n";
            hang1+= "  |                   \n";
            hang1+= "  |                   \n";
            hang1+= "  |                   \n";
            hang1+= " ===                  \n";
            //////////////////////////////////
            Steps.Add(hang1);Steps.Add(hang2);Steps.Add(hang3);
            Steps.Add(hang4);Steps.Add(hang5);Steps.Add(hang6);
            Steps.Add(hang7);
        }
        public static void Play(){
            
            Game.GameInit();
            
            Random random=new Random();
            string word=Game.Words[random.Next(Game.Words.Count)];

            char[] guess=new char[word.Length];
            for (int i = 0; i < guess.Length; i++)
                guess[i]='_';

            while(Game.Attempts<7&& guess.Contains('_')){
                Console.Clear();

                string g="Word: ";
                foreach(char c in guess)
                    g+=c;
                Console.WriteLine(g);

                Console.WriteLine($"{Game.Steps[Game.Attempts-1]}");

                string wrong="Wrong guesses: ";
                foreach(char c in Game.Wrong)
                    wrong+=$"-{c}";
                Console.WriteLine($"{wrong}");

                Console.Write("Guess: ");
                ConsoleKeyInfo cki=Console.ReadKey();
                char input=cki.KeyChar.ToString().ToLower()[0];
                if(!Wrong.Contains(input)){
                    bool wasright=false;
                    for(int i = 0; i < word.Length; i++)
                    {
                        if(word[i]==input){
                            guess[i] = input;
                            wasright =true;
                            Game.Rights++;
                        }
                    }
                    if(!wasright){
                        Game.Wrong.Add(input);
                        Game.Attempts++;
                    }
                }
            }

            if(!guess.Contains('_')){
                Console.Clear();
                Console.ForegroundColor=ConsoleColor.Green;
                Console.WriteLine($"{word.ToUpper()}");
                Console.WriteLine($"You Won !!!!!");
                Console.ForegroundColor=ConsoleColor.White;
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor=ConsoleColor.Red;
                Console.WriteLine($"Game Over!! You are DEAD");
                Console.WriteLine($"{Game.Steps[6]}");
                Console.WriteLine($"The Word Was \"{word}\"");
                Console.ForegroundColor=ConsoleColor.White;
            }
        }
    }
}
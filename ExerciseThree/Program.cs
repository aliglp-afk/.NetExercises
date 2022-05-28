using System;
using System.Text;
namespace ExerciseThree{
    class Program{
        public static void Main(string[] args){
            ConsoleKeyInfo cki;
            do{
                Console.WriteLine($"Input S1: ");
                string S1=Console.ReadLine().ToLower();
                Console.WriteLine($"Input S2: ");
                string S2=Console.ReadLine().ToLower();
                if(S1==null || S2==null || S1=="" || S2=="" || S1==" " || S2==" ")
                    Console.WriteLine($"Input was null");
                else
                    Console.WriteLine(S1.Contains(S2)?"S2 was in the S1{index : "+S1.IndexOf(S2)+"}":"S2 Not Found");
                Console.Write($"A for again : ");
                cki =Console.ReadKey();   
                Console.WriteLine();                 
            }
            while(cki.Key ==ConsoleKey.A);

                


        }
    }
}
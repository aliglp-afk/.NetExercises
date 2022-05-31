using System;

namespace ExerciseFour // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Number One: ");
            char[] Num1=Console.ReadLine().ToCharArray();
            Console.WriteLine("Input Number Two: ");
            string Num2=Console.ReadLine();

            if(Num2.Length>1 || Num1.Length<2)
                Console.WriteLine($"Invalid Input");
            else{
                int count=0;
                foreach(char c in Num1)
                {
                    if(c==Num2[0])
                        count++;
                }
                Console.WriteLine($"Number One Had {count} Number Twos");
            }   

                
        }
    }
}
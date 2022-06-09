using System;
namespace ClassTemp{
    static class DataManager{
        public static int convToInt(this string i) {
            return Convert.ToInt32(i);
        }
    }
    class  Program{
        public static void Main(string[] args)
        {
            // Console.WriteLine($"Input N : ");
            // int n =Convert.ToInt32(Console.ReadLine());
            // List<string>strs=new List<string>();

            // for (var i = 0; i < n; i++)
            // {
            //     Console.WriteLine($"Input string {i+1}: ");
            //     strs.Add(Console.ReadLine());
            // }

            // Console.WriteLine($"Input C : ");
            // char c =Console.ReadKey().KeyChar;
            // Console.WriteLine();

            // Console.ForegroundColor=ConsoleColor.Green;
            // foreach(string s in strs){
            //     if(s[0]==c || s[s.Length-1]==c)
            //         Console.Write($"{s}\t");
            // }
            // Console.ForegroundColor=ConsoleColor.White;


            // Console.WriteLine($"Input Number");
            // char[] numchar =Console.ReadLine().ToCharArray();
            // bool Check=true;
            // for (int i = 0; i < numchar.Length-1; i++)
            // {
            //     int temp=Convert.ToInt32(numchar[i])-Convert.ToInt32(numchar[i+1]);
            //     // Console.WriteLine($"{Convert.ToInt32(numchar[i])} - {Convert.ToInt32(numchar[i+1])} = {temp}");
            //     if(temp!=-2)
            //         Check=false;
            // }
            // Console.WriteLine($"{Check}");
            
            
            // Console.WriteLine($"Input num");
            // int num=Console.ReadLine().convToInt();
            // Console.WriteLine($"{++num}");
            }

    }
}
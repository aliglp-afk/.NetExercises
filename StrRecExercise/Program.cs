using System;
namespace StrRecExercise{
    public class Program
    {
        public static string RevStr(string main,int index){
            if(index!=main.Length-1){
                return main[main.Length-index-1] + RevStr(main,index+1);
            }
            else
                return main[0].ToString();
        }
        public static void Main(string[] args)
        {
            Console.WriteLine($"Input the String: ");
            string s=Console.ReadLine();
            Console.WriteLine($"the reverse is \n{RevStr(s,0)}");
        }
    }
}
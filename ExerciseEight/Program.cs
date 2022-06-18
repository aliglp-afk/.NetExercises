using System;
namespace ExerciseEight
{
    class Program{
        public static string Binary(string num){
            int n=Convert.ToInt32(num);
            if(n/2==0)
                return (n%2).ToString();
            else{
                return Binary((n/2).ToString())+(n%2).ToString();
            }                
        }
        public static void Main(string[] args)
        {
            Console.WriteLine($"Text");
            string num=Console.ReadLine();
            Console.WriteLine(Binary(num));
            
        }
    }
}
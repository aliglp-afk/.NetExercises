using System;
namespace SessionThreeSecondExercise
{
    class Program{
        public static void Main(string[] args){
            System.Console.WriteLine("Input Number: ");
            int Sum=0;
            int input=Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=input;i+=2){
                Sum+=i;
            }
            Console.WriteLine($"Sum is : {Sum}");
        }
    }
}

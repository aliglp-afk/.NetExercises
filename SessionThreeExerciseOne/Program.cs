using System;
namespace SessionThreeExerciseOne{
    class Program{
        public static void Main(string[] args){
            Console.WriteLine("Input rows");
            int row=Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=row;i++){
                for(int j=1;j<=row-i;j++){
                    Console.Write(" ");
                }
                for(int j=1;j<=i;j++){
                    Console.Write(j);
                }
                for(int j=i-1;j>0;j--)
                {
                    Console.Write(j);
                }
                for(int j=1;j<=row-i;j++){
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
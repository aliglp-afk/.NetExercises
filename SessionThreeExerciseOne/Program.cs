using System;
namespace SessionThreeExerciseOne{
    class Program{
        public static void Main(string[] args){
            for(int i=1;i<=5;i++){
                for(int j=1;j<=5-i;j++){
                    Console.Write(" ");
                }
                for(int j=1;j<=i;j++){
                    Console.Write(j);
                }
                for(int j=i-1;j>0;j--)
                {
                    Console.Write(j);
                }
                for(int j=1;j<=5-i;j++){
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
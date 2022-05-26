using System;
namespace SessionThreeExerciseOne{
    class Program{
        public static void Main(string[] args){
            while(true){
                Console.WriteLine("Input rows: (q for quit)");
                string input=Console.ReadLine();    
                if(input=="q")
                    break;
                int row=Convert.ToInt32(input);
                for(int i=1;i<=row;i++){
                    for(int j=1;j<=row-i;j++){
                        Console.Write(" ");
                    }
                    for(int j=1;j<=i;j++){
                        Console.Write(j%10);
                    }
                    for(int j=i-1;j>0;j--)
                    {
                        Console.Write(j%10);
                    }
                    Console.WriteLine();
                }

                Console.WriteLine($"Test Checkout");
                
            }
        }
    }
}
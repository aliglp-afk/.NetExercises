﻿using System;
using System.Text;
namespace ExerciseThree{
    class Program{
        public static bool SearchStr(string str1, string str2)
        {
            if (str1.Length > 0 && str2.Length > 0)
            {
                if (str1.Length == 1 && str2.Length == 1)
                {
                    if (str1[0] == str2[0])
                    {
                        return true;
                    }
                    else
                        return false;
                }
                else
                {
                    if (str1[0] == str2[0])
                    {
                            return SearchStr(str1.Substring(1), str2.Substring(1));
                    }
                    else
                        return false;
                }
            }
            else
                return true;

        }
        public static void Main(string[] args){
            
            ConsoleKeyInfo cki;
            do{
                Console.WriteLine($"Input S1: ");
                string S1=Console.ReadLine();
                Console.WriteLine($"Input S2: ");
                string S2=Console.ReadLine();
                if(S1==null || S2==null || S1=="" || S2=="" || S1==" " || S2==" ")
                    Console.WriteLine($"Input was null");
                else{
                    bool search=false;
                    for (int i = 0; i < S1.Length-S2.Length+1; i++)
                    {
                        
                        search = SearchStr(S1.Substring(i),S2);
                        if(search==true)
                            break;
                    }
                        Console.WriteLine(search?"S2 was in the S1{index : "+S1.IndexOf(S2)+"}":"S2 Not Found");
                }                    
                Console.Write($"A for again : ");
                cki =Console.ReadKey();   
                Console.WriteLine();                 
            }
            while(cki.Key ==ConsoleKey.A);
                


        }
    }
}
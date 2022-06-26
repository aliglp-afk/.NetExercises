using System;
using System.Linq;
namespace ExerciseTen{
    class Program{
        public static void Main(string[] args)
        {
            List<Questions> Qs1=new List<Questions>(){
                new Questions(1,1,"Q1"),
                new Questions(2,1,"Q5"),
                new Questions(3,1,"Q3")
            };
            List<Questions> Qs2=new List<Questions>(){
                new Questions(10,1,"Q2"),
                new Questions(12,1,"Q4"),
                new Questions(2,1,"Q5"),
                new Questions(14,1,"Q6"),
                new Questions(15,1,"Q28")
            };
            List<Exams> exams=new List<Exams>(){
                new Exams(){
                ID=1,
                questions=Qs2}
            };
            bool check =false;
            Qs1.ForEach(q1=>exams.ForEach(exam=>exam.questions.ForEach(q2=>check=check||q1.Question==q2.Question)));
            Console.WriteLine($"{check}");
            

        }
    }
}
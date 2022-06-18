using System;
namespace ExerciseNine{
    class Program{
        public static void Main(string[] args)
        {
            
            // Check if the numbers have an order
            // Console.WriteLine($"Input Numbers");
            // string input=Console.ReadLine();
            // List<int> nums=new List<int>();
            // input.Split(" ").ToList().ForEach(c=>nums.Add(Convert.ToInt32(c)));
            // bool check=true;
            // nums.ForEach(c=>check=check&(c-(nums.IndexOf(c)-1>0?nums[nums.IndexOf(c)-1]:c-2)==2));
            // Console.WriteLine($"{check}");
            
            // Movie Join Exercises
            // List<Movie> title=new List<Movie>{
            //     new Movie("Harry Potter",1),
            //     new Movie("Harry Potter",2),
            //     new Movie("Harry Potter",3),
            //     new Movie("Harry Potter",4),
            //     new Movie("Harry Potter",5),
            //     new Movie("Harry Potter",6),
            //     new Movie("James Bond",7),
            //     new Movie("James Bond",8),
            //     new Movie("James Bond",9)
            // };

            // List<Movie>movies=new List<Movie>(){
            //     new Movie("Harry Potter and the Philosopher's Stone",1),
            //     new Movie("Harry Potter and the Chamber of Secrets",2),
            //     new Movie("Harry Potter and the Prisoner of Azkaban",3),
            //     new Movie("Harry Potter and the Goblet of Fire",4),
            //     new Movie("Harry Potter and the Order of the Phoenix",5),
            //     new Movie("Harry Potter and the Half-Blood Prince",6),
            //     new Movie("James Bond Skyfall",7),
            //     new Movie("James Bond Spectre",8),
            //     new Movie("James Bond No Time to Die",9)
            // };

            // var result=title.Join(movies,c=>c.Id,x=>x.Id,(c,x)=>new {c.Id,x.Name}).ToList();
            // result.ForEach(c=>Console.Write($"{c.Id}\t{c.Name}\n"));
        }
    }
}
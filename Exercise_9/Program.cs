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
            List<Movie> title=new List<Movie>{
                new Movie("Harry Potter",1),
                new Movie("James Bond",9)
            };

            List<Movie>movies=new List<Movie>(){
                new Movie("and the Philosopher's Stone",1),
                new Movie("and the Chamber of Secrets",1),
                new Movie("and the Prisoner of Azkaban",6),
                new Movie("and the Goblet of Fire",1),
                new Movie("and the Order of the Phoenix",1),
                new Movie("and the Half-Blood Prince",5),
                new Movie("Skyfall",9),
                new Movie("Spectre",9),
                new Movie("No Time to Die",9)
            };

            // title.ExceptBy(movies,x=>x.Name).ToList().ForEach(c=>Console.WriteLine($"{c}"));
            // movies.OrderBy(c=>c.Id).ToList().ForEach(c=>Console.WriteLine($"{c.id}"));


            // var result=title.Join(movies,c=>c.Id,x=>x.Id,(c,x)=>new {
            //     Name=c.Name+"\t"+x.Name
            // }).ToList();
            // result.ForEach(c=>Console.Write($"{c.Name}\n"));
            
        }
    }
}
using System;
namespace ExerciseNine{
    class Movie{
        public int Id { get; set; }
        public string Name { get; set; }
        public Movie(string Name,int id)
        {
            Id=id;
            this.Name=Name;
        }
    }
}
namespace ClassExercise{
    class Animal{
        public string Name { get; set; }
        
        public int Age { get; set; }
        
        public virtual void MakeSound(){

        }
        public virtual void Play(){
            Console.WriteLine($"Plays Games");
        }
        public Animal(string name,int age)
        {
            Name=name;
            Age=age;
        }        
    }
}
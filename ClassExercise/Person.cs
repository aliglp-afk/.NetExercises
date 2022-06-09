namespace ClassExercise{
    class Person{
        public string Name { get; set; }
        
        
        public string FName { get; set; }

        public Person(string name,string fname)
        {
            Name=name;
            FName=fname;
        }
        public virtual string Explain(){
            return $"{Name} {FName} is Explaining";
        }
        public virtual string Study(){
            return $"{Name} {FName} is Studying";
        }
        public virtual string Work(){
            return $"Basic Work";
        }
    }
}
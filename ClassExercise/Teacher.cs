namespace ClassExercise{
    class Teacher:Person{
        public Teacher(string name,string fname):base(name,fname)
        {
            
        }
        public override string Work()
        {
           return base.Explain();
        }
    }
}
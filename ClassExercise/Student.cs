namespace ClassExercise{
    class Student:Person{
        public Student(string name,string fname):base (name,fname)
        {
            
        }
        public override string Work()
        {
            return base.Study();
        }
    }
}
namespace ClassExercise{
    
    class Program{

        public static void Main(string[]args){

            Teacher teacher=new Teacher("","");
            List<Student>studentList=new List<Student>();
            for (var i = 0; i < 4; i++)
            {
                if(i==0){
                    Console.WriteLine($"Input Teachers Name: ");
                    string name=Console.ReadLine();

                    Console.WriteLine($"Input Teachers FName: ");
                    string fname=Console.ReadLine();

                    teacher =new Teacher(name,fname);
                }
                else{
                    Console.WriteLine($"Input Teachers Name: ");
                    string studentName=Console.ReadLine();
        
                    Console.WriteLine($"Input Teachers FName: ");
                    string studentFName=Console.ReadLine();

                    studentList.Add(new Student(studentName,studentName));
                }
            }            
            Console.WriteLine(teacher.Work());
             
            for(int i=0;i<studentList.Count;i++)
                Console.WriteLine(studentList[i].Work());
            
            
            // Console.WriteLine($"Input height");
            // int height=Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine($"Input width");
            // int width=Convert.ToInt32(Console.ReadLine());
            
            // Rectangle rec=new Rectangle(height,width);
            // rec.Area();
        }
    }
}
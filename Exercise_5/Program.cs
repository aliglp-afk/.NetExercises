namespace ExerciseFive
{
    public class Program
    {
        public static void Main(string[]args){
            List<Employee>employees=new List<Employee>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Input Name e{i+1}");
                string name=Console.ReadLine();
                Console.WriteLine($"Input saatKarDarroz e{i+1}");
                int workingHour=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Input Haghzahmeh e{i+1}");
                int salary=Convert.ToInt32(Console.ReadLine());
                Employee employee=new Employee(name,workingHour,salary);
                employees.Add(employee);
            }
            Console.WriteLine();
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine($"{employees[i].GetResult()}\n\n");
            }
        }
    }
}
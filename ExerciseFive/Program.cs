namespace ExerciseFive
{
    public class Program
    {
        public static void Main(string[]args){
            List<Employee>employees=new List<Employee>();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Input Name e{i+1}");
                string name=Console.ReadLine();
                Console.WriteLine($"Input WorkingHour e{i+1}");
                int workingHour=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Input Salary e{i+1}");
                int salary=Convert.ToInt32(Console.ReadLine());
                Employee employee=new Employee(name,workingHour,salary);
                employees.Add(employee);
            }
            Console.WriteLine("{Name}\t{WorkingHour}\t{Salary}\t{DailyWage}\t{MonthlyWage}");
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine($"{employees[i].GetResult()}");
            }
        }
    }
}
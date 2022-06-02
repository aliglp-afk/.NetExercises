namespace ExerciseFive
{
    public class Employee
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
        private int _workingHour;
        public int WorkingHour
        {
            get { return _workingHour; }
            set { _workingHour = value; }
        }
        
        private int _salary;
        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        private int _monthlyWage;
        public int MonthlyWage
        {
            get { return _monthlyWage; }
            set { _monthlyWage = value*WorkingHour*24; }
        }
        
        private int _dailyWage;
        public int DailyWage
        {
            get { return _dailyWage; }
            set { _dailyWage = value*WorkingHour; }
        }
        public Employee(string name,int workingHour,int salary)
        {
            Name=name;
            WorkingHour=workingHour;
            Salary=salary;
            MonthlyWage=salary;
            DailyWage=salary;
        }

        public string GetResult(){
            string result="";
            result+=$"Name: {Name}\n";
            result+=$"Haghzahmeh: {Salary}\n";
            result+=$"saatKarDarroz: {WorkingHour}\n";
            result+=$"daramad mahiuane: {MonthlyWage}\n";
            return result;
        }
        
    }
}
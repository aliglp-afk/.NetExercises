// namespace ExerciseThree{
//     class Teacher{
//         private int _dailywage;
//         public int DailyWage
//         {
//             get { return _dailywage; }
//             set { 
//                 if(value<=0){
//                     Console.WriteLine($"Invalid Input");
//                 }
//                 else{
//                     _dailywage=value*_workingHours;
//                 }
//                 }
//         }

//         private int _monthlywage;
//         public int MonthyWage
//         {
//             get { return _monthlywage; }
//             set { if(value<=0){
//                     Console.WriteLine($"Invalid Input");
//                 }
//                 else{
//                     _monthlywage=value*_workingHours*30;
//                 }
//                 }
//         }

//         private int _workingHours;
//         public int WorkingHours
//         {
//             get { return _workingHours; }
//             set { _workingHours = value; }
//         }
        
//         private string _name;
//         public string Name
//         {
//             get { return _name; }
//             set { _name = value; }
//         }
        
//         public string GetResult(){
//             Console.WriteLine($"{Name}-{WorkingHours}-{DailyWage}-{MonthyWage}");
//         }
//         public Teacher(int wage,string name,int workinghours)
//         {
//             WorkingHours=workinghours;
//             Name=name;
//             DailyWage=wage;
//             MonthyWage=wage;
//         }
//     }
// }
using System;
namespace Exercise_11
{
    class Attendance{
        public List<string> BannedList=new List<string>{
            "Jack","Steven","Mathew"
        };
        public string UserName { get; set; }
        public event EventHandler BanUserEntered;
        public void Enter(){
            BanUserEntered+=Banned;
            Console.Write($"Please Enter Your UserName: ");
            UserName=Console.ReadLine();
            if(BannedList.Contains(UserName)){
                BanUserEntered?.Invoke(this,EventArgs.Empty);
            }
            else{
                Console.WriteLine($"Welcome {UserName}");
            }
        }
        public void Banned(object sender,EventArgs e){
            Console.ForegroundColor=ConsoleColor.Red;
            Console.WriteLine($"This User is Banned from the Online Attendance\nUserName: {UserName}");
            Console.ForegroundColor=ConsoleColor.White;
        }
    }
    class Program{
        public static void Main(string[] args)
        {
            Attendance att=new Attendance();
            att.Enter();
        }
    }
}
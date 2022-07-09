using System;
namespace XO
{
        public class Game{
            
        public Game()
        {
            Set=1;
        }
        public void Play(){
            BattleField = new char[3,3]{{'7','8','9'},{'4','5','6'},{'1','2','3'}};
            int sc1,sc2;
            if(Set==1){
                sc1=0;sc2=0;
                Console.Write("Input Player 1 Name {X}: ");
                this.X=new Player(){
                Name=Console.ReadLine(),
                Score=sc1,
                XO='X'
                };
                Console.Write("Input Player 1 Name {O}: ");
                this.O=new Player(){
                    Name=Console.ReadLine(),
                    Score=sc2,
                    XO='O'
                };
            }
            for(int turn=1;CheckWinner()==null;turn++){
                ShowBattleField();
                if(turn%2==0){
                    Console.WriteLine($"{X.Name} Choose a house:");
                    if(Input(Console.ReadKey().KeyChar,X)==null){
                        turn--;
                    }
                }
                else{
                    Console.WriteLine($"{O.Name} Choose a house:");
                   
                    if(Input(Console.ReadKey().KeyChar,O)==null){
                        turn--;
                    }
                }
            }
            ShowBattleField();
            Player winner=CheckWinner();
            if(winner.Name=="Draw"){
                Console.ForegroundColor=ConsoleColor.Yellow;
                Console.WriteLine($"DRAW !!!");
                Console.WriteLine($"Scores:\nX:{X.Score}\tO:{O.Score}");
            }
            else{
                if(winner.XO=='X')
                    X.Score++;
                else
                    O.Score++;
                Console.ForegroundColor=ConsoleColor.Green;
                Console.WriteLine($"{winner.Name} has Won The Game!!!");
                Console.WriteLine($"Scores:\nX:{X.Score}\tO:{O.Score}");
            }
            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine($"Press P to play ");
            Console.ForegroundColor=ConsoleColor.White;
            if(Console.ReadKey().KeyChar.ToString().ToLower()=="p"){
                Console.WriteLine($"Play again pressed");
                Set++;
                Play();
            }
        }   
        public int Set { get; set; }
        public void ShowBattleField(){

            Console.Clear();
            for (int i = 0; i < this.BattleField.GetLength(0); i++)
            {
                for (int j = 0; j < this.BattleField.GetLength(1); j++)
                {
                    if(this.BattleField[i,j]=='X'){
                        Console.ForegroundColor=ConsoleColor.Blue;
                    }
                    else if(this.BattleField[i,j]=='O'){
                        Console.ForegroundColor=ConsoleColor.Red;
                    }
                    string res=this.BattleField[i,j].ToString();
                    res+=j==this.BattleField.GetLength(1)-1?"":"-";
                    Console.Write($"{res}");
                    Console.ForegroundColor=ConsoleColor.White;
                }
                Console.WriteLine();
            }           
        }
        public Player X { get; set; }
        public Player O { get; set; }
       public char[,]BattleField = new char[3,3]{{'7','8','9'},{'4','5','6'},{'1','2','3'}};
        public Player CheckWinner(){
            
            //Row Check
            for (int i = 0; i < 3; i++)
            {
                if(BattleField[i,0]==BattleField[i,1]&&BattleField[i,1]==BattleField[i,2])
                {
                    return new Player(BattleField[i,0],this);
                }
            }
            //Column Check
            for (int i = 0; i < 3; i++)
            {
                if(BattleField[0,i]==BattleField[1,i]&&BattleField[1,i]==BattleField[2,i])
                {
                    return new Player(BattleField[0,i],this);
                }
            }
            //X Check 
            if(BattleField[0,0]==BattleField[1,1]&&BattleField[1,1]==BattleField[2,2])
            {
                return new Player(BattleField[1,1],this);
            }
            else if(BattleField[2,0]==BattleField[1,1]&&BattleField[1,1]==BattleField[0,2])
            {
                return new Player(BattleField[1,1],this);
            }

            //Check for draw 
            bool checkdraw=true;
            for (int i = 0; i < BattleField.GetLength(0); i++)
            {
                for (int j = 0; j < BattleField.GetLength(1); j++)
                {
                    if(BattleField[i,j]!='X'||BattleField[i,j]!='O'){
                        checkdraw=false;
                        break;
                    }
                }
            }
            if(checkdraw)
                return new Player('d',this);
            //If theres no winner return null
            return null;
        }
        public string Input(char c,Player xo){
            int ch=Convert.ToInt32(c.ToString());
            if(ch<=3)
            {
                if(BattleField[2,ch-1]!='X'&&BattleField[2,ch-1]!='O'){
                    if(xo.XO=='X')
                        BattleField[2,ch-1]=xo.XO;
                    else
                        BattleField[2,ch-1]=xo.XO;

                    return "";    
                }
            }
            else if(ch<=6)
            {
                if(BattleField[1,ch-4]!='X'&&BattleField[1,ch-4]!='O'){
                    if(xo.XO=='X')
                        BattleField[1,ch-4]='X';
                    else
                        BattleField[1,ch-4]='O';
                    return "";    
                }
            }
            else if(ch<=9)
            {
                if(BattleField[0,ch-7]!='X'&&BattleField[0,ch-7]!='O'){
                    if(xo.XO=='X')
                        BattleField[0,ch-7]='X';
                    else
                        BattleField[0,ch-7]='O';
                    return "";    
                }
            }
            return null;
        }
    }
}
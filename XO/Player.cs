using System;
namespace XO
{
   public class Player{
        public string Name { get; set; }
        public int Score { get; set; }
        public char XO { get; set; }
        
        
        public Player(char xo,Game game)
        {
            if(xo=='X')
            {
                this.Name=game.X.Name;
                this.Score=game.X.Score;
            }else if (xo=='O'){
                this.Name=game.O.Name;
                this.Score=game.O.Score;
            }
            else    
                this.Name="Draw";
        }

        public Player()
        {
            
        }
    }
}
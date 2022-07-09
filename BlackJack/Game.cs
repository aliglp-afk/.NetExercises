using System;
namespace BlackJack
{
        public class Game{
            public int[] Cards =new int[]{11,2,3,4,5,6,7,8,9,10,10,10};
            public List<int> PlayerCards { get; set; }
            public List<int> DealerCards { get; set; }
            public void AddCard(string PlayerOrDealer){
                Random r=new Random();
                int hit=Cards[r.Next(Cards.Length-1)];
                if(PlayerOrDealer.ToLower()=="p"){
                    if(hit==11){
                        if(PlayerCards.Sum()+hit<21)
                            hit=11;
                        else
                            hit=1;
                    }
                        PlayerCards.Add(hit);
                }
                else if(PlayerOrDealer.ToLower()=="d"){
                    if(hit==11){
                        if(PlayerCards.Sum()+hit<21)
                            hit=11;
                        else
                            hit=1;
                    }
                    DealerCards.Add(hit);
                }
            }
            public string ShowCards(List<int> Cards){
                int sum=Cards.Sum();
                string result=$"Cards: [";
                for (int i = 0; i < Cards.Count-1; i++)
                    result+=$"{Cards[i]}, ";
                // Cards.ForEach(c=>result+=Cards.IndexOf(c)!=Cards.IndexOf(Cards.Last())?$"{c}, ":"");
                result+=$"{Cards.Last()}]";
                result+=$"\nTotal is {sum}";
                return result;
            }
            
            public void Play(){
                Random r=new Random();

                PlayerCards=new List<int>();
                DealerCards=new List<int>();

                PlayerCards.Add(Cards[r.Next(Cards.Length-1)]);
                PlayerCards.Add(Cards[r.Next(Cards.Length-1)]);
                
                DealerCards.Add(Cards[r.Next(Cards.Length-1)]);
                DealerCards.Add(Cards[r.Next(Cards.Length-1)]);
                // if(PlayerCards.Contains(11)){

                //     if(PlayerCards.Count(c=>c==11)==2){
                //         PlayerCards[PlayerCards.IndexOf(PlayerCards.Where(c=>c==11).First())]=1;
                //     }
                //     else
                //     {
                //         Console.WriteLine($"You have an Ace 11 or 1?\nYour Other Card:{PlayerCards[PlayerCards.IndexOf(PlayerCards.Where(c=>c!=11).First())]}");
                //         int elvnorone=Convert.ToInt32(Console.ReadLine());
                //         if(elvnorone==1){
                //             PlayerCards[PlayerCards.IndexOf(PlayerCards.Where(c=>c==11).First())]=1;
                //         }
                //         else if(elvnorone==11){};
                //     }
                // }
                
                Console.WriteLine($"Your {ShowCards(PlayerCards)}");
                Console.WriteLine($"Dealers first card: {DealerCards[0]}");




                if(PlayerCards.Sum()==21){
                    if(DealerCards.Sum()==21){
                        Console.ForegroundColor=ConsoleColor.Red;
                        Console.WriteLine($"Both got a blackjack!!Dealer Wins");
                        Console.ForegroundColor=ConsoleColor.White;
                    }
                    else{
                        Console.ForegroundColor=ConsoleColor.Green;
                        Console.WriteLine($"Black Jack!!\nYou won!!!");
                        Console.ForegroundColor=ConsoleColor.White;
                    }
                }
                else
                {
                    Console.WriteLine($"hit(h) or pass(p)?");
                    char hop=Console.ReadKey().KeyChar;
                    while(hop == 'h'){
                        AddCard("p");
                        if(DealerCards.Sum()<15)
                            AddCard("d");
                        if(PlayerCards.Sum() >21){
                            break;
                        }
                        Console.WriteLine($"Your {ShowCards(PlayerCards)}");
                        Console.WriteLine($"hit(h) or pass(p)? {PlayerCards.Sum()}");
                        hop=Console.ReadKey().KeyChar;
                    }
                    Console.WriteLine($"Your {ShowCards(PlayerCards)}");
                    Console.WriteLine($"Dealers {ShowCards(DealerCards)}");
                    if(PlayerCards.Sum()>21){
                        Console.ForegroundColor=ConsoleColor.Red;
                        Console.WriteLine($"You are over 21! You Lost");
                        Console.ForegroundColor=ConsoleColor.White;
                    }
                    else if(PlayerCards.Sum()==21){
                        Console.ForegroundColor=ConsoleColor.Green;
                        Console.WriteLine($"You are over 21! You Lost");
                        Console.ForegroundColor=ConsoleColor.White;
                    }
                    else if(PlayerCards.Sum()<21){
                        if(PlayerCards.Sum()>DealerCards.Sum()){
                        Console.ForegroundColor=ConsoleColor.Green;
                        Console.WriteLine($"You won!! ");
                        Console.ForegroundColor=ConsoleColor.White;
                        }
                        else if(DealerCards.Sum()>PlayerCards.Sum()){
                        Console.ForegroundColor=ConsoleColor.Red;
                        Console.WriteLine($"You Lost!! ");
                        Console.ForegroundColor=ConsoleColor.White;
                        }
                    }
                }
            }
        }
}
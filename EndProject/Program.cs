using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace playerandteam
{
    public class Program
    {
        static void Main(string[] args)
        {
            string temp;

            List<player> list = new List<player>();
           
            player p = new player();
            Onedayteam t = new Onedayteam();
            bool status;
            status = false;

            do
            { 
                Console.WriteLine("Enter 1:To Add Player 2:To Remove Player by Id 3.Get Player By Id 4.Get Player by Name 5.Get All Players:");
                int ch = Convert.ToInt32(Console.ReadLine());
                
               switch (ch)
                {
                    case 1:
                        t.AddPlayer();

                        break;
                    case 2:
                        Console.WriteLine("Enter Player id to remove");
                        p.PlayerID = Int32.Parse(Console.ReadLine());
                        t.Remove(p.PlayerID);
                        list.Remove(p);
                        break;
                    case 3:
                        Console.WriteLine("Enter Player id to print details");
                        p.PlayerID = Int32.Parse(Console.ReadLine());
                        t.GetPlayerById(p.PlayerID);
                        break;
                    case 4:
                        Console.WriteLine("Enter Player Name to print details");
                        p.PlayerName = Console.ReadLine();
                        t.GetPlayerByName(p.PlayerName);
                        break;
                    case 5:
                        t.GetAllPlayers();
                        
                       
                        break;
                }

                     Console.WriteLine("do you want to continue(Y/N)");
                      temp = Console.ReadLine();
                   
                      if (temp == "y" || temp == "Y")
                      {
                       status = true;
                      }
            } while (status);
        }
    }
}



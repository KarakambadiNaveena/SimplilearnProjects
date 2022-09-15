using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace playerandteam
{
    public class Onedayteam : ITeam
    {
        public static int PlayerCount = 0;
        List<player> list = new List<player>();
        List<Onedayteam>plist =new List<Onedayteam>();

        public void AddPlayer()
        {
            if (PlayerCount < 11)
            {
                player p = new player();
                Console.WriteLine("Enter Player id");
                p.PlayerID = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter Player Name :");
                p.PlayerName = Console.ReadLine();
                Console.WriteLine("Enter Player Age ");
                int age = Convert.ToInt32(Console.ReadLine());
                p.PlayerAge = age;
                this.list.Add(p);
                PlayerCount++;
            }
            else
            {
                Console.WriteLine("Team is Full...");
            }
        }
       public void Add(player player)
        {
            if (PlayerCount < 11)
            {
                this.list.Add(player);
                PlayerCount++;
                Console.WriteLine("player added successfully");
            }
            else
            {
                Console.WriteLine("Team is full...");
            }
        }
        public void GetAllPlayers()
        {
            foreach (var item in this.list)
            {
                Console.WriteLine($"Player ID : {item.PlayerID} Player Name: {item.PlayerName} Player Age: {item.PlayerAge}");
            }
           
        }

        public void Remove(int playerId)
        {
            var found = this.list.Single(r => r.PlayerID == playerId);
            if (found != null)
            {
                this.list.Remove(found);
                PlayerCount--;
                Console.WriteLine("Player Removed Successfully....");
            }
            else
            {
                Console.WriteLine("Player Not Found");
            }
           
        }
          public void GetPlayerById(int playerId)
        {
            var found = this.list.FindAll(fo => fo.PlayerID == playerId);
            if (found != null)
            {
                Console.WriteLine("Player Found");
                foreach (var item in found)
                {
                    Console.WriteLine($"Player Id : {item.PlayerID} Player Name : {item.PlayerName} Age : {item.PlayerAge}");
                }
            }
            else
            {
                Console.WriteLine("Player Not Found!!");
            }
        }
        public void GetPlayerByName(string playerName)
        {
            var found = this.list.FindAll(fo => fo.PlayerName == playerName);
            if (found != null)
            {
                Console.WriteLine("Player Found");
                foreach (var item in found)
                {

                    Console.WriteLine($"Player Id : {item.PlayerID} Player Name : {item.PlayerName} Age : {item.PlayerAge}");
                }
            }
            else
            {
                Console.WriteLine("Player Not Found!!");
            }
        }
    }
}
    


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playerandteam
{
    public interface ITeam
    {
        void Add(player player);
        void Remove(int playerId);
        void GetPlayerById(int playerId);
        void GetPlayerByName(string playerName);

        void GetAllPlayers();

    }
}

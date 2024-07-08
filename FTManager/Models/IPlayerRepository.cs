using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTManager.Models
{
    internal interface IPlayerRepository
    {
        List<Player> GetAllPlayers();
        Player GetPlayerById(int playerId);
        void AddPlayer(Player player);
        void DeletePlayer(int playerId);
        void EditPlayer(Player player);
    }
}

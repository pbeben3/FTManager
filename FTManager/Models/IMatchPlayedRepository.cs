using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTManager.Models
{
    internal interface IMatchPlayedRepository
    {
        void AddMatchPlayed(MatchPlayed match);
        List<MatchPlayed> GetAllMatchesPlayed();
        void DeleteMatchPlayed(int matchId);
        void EditMatchPlayed(MatchPlayed match);
    }
}

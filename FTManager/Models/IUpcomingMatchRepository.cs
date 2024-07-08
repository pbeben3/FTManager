using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTManager.Models
{
    internal interface IUpcomingMatchRepository
    {
        void AddUpcomingMatch(UpcomingMatch match);
        List<UpcomingMatch> GetAllUpcomingMatches();
        void DeleteUpcomingMatch(int matchId);
        void EditUpcomingMatch(UpcomingMatch match);
    }
}

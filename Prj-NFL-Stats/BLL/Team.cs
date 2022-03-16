using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prj_NFL_Stats.DAL;

namespace Prj_NFL_Stats.BLL
{
    class Team
    {
        public string Name { get; set; }
        public string TeamCode { get; set; }
        public string City { get; set; }
        public Int32 ByeWeek { get; set; }

        public List<Team> GetTeamList()
        {
            return TeamDB.GetTeams();
        }

        public Team GetATeam(string code)
        {
            return TeamDB.GetATeam(code);
        }
        public Team GetATeamCode(string code)
        {
            return TeamDB.GetATeamCode(code);
        }
    }
}

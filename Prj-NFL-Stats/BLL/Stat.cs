using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prj_NFL_Stats.DAL;

namespace Prj_NFL_Stats.BLL
{
    class Stat
    {

        public Int32 PlayerId { get; set; }
        public Int32 Week { get; set; }
        public Int32 Rushes { get; set; }
        public Int32 RushingYards { get; set; }
        public Int32 RushingTouchDowns { get; set; }
        public Int32 Targets { get; set; }
        public Int32 Receptions { get; set; }
        public Int32 RecievingYards { get; set; }
        public Int32 RecievingTouchdowns { get; set; }
        public Int32 OffensiveSnaps { get; set; }
        public Int32 PassingYards { get; set; }
        public Int32 PassAttempts { get; set; }
        public Int32 PassCompletions { get; set; }
        public Int32 PassingTouchdowns { get; set; }
        public Int32 Sacks { get; set; }
        public Int32 Interceptions { get; set; }
        public Int32 Fumbles { get; set; }


        public void AddStats(Stat s1)
        {

            StatDB.AddStats(s1);

        }

        public List<Stat> ListPlayerStats(int id)
        {

            return StatDB.GetPlayerStats(id);

        }
    }
}

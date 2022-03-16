using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prj_NFL_Stats.DAL;

namespace Prj_NFL_Stats.BLL
{
     class PlayerTest
    {
        public string Name { get; set; }

        public int PlayerID { get; set; }

        public string Position { get; set; }

        public string Team { get; set; }

        public int? TeamID { get; set; }

        public List<PlayerTest> GetPlayerList()
        {
            return PlayerDB.GetNewPlayers();
        }

        //public Player GetAPlayer(Int32 id)
        //{
        //    return PlayerDB.GetRecord(id);
        //}

        //public void AddPlayer2(Player p1)
        //{

        //    PlayerDB.AddPlayer2(p1);

        //}

        //public void AddPlayer3(Player p1)
        //{

        //    PlayerDB.AddPlayer3(p1);

        //}

        //public List<Player> GetRbList()
        //{
        //    return PlayerDB.GetRbs();
        //}


        //public List<Player> GetQBList()
        //{
        //    return PlayerDB.GetQbs();
        //}


        //public List<Player> GetWRList()
        //{
        //    return PlayerDB.GetWrs();
        //}


        //public List<Player> GetTEList()
        //{
        //    return PlayerDB.GetTEs();
        //}

        //public List<Player> GetPList()
        //{
        //    return PlayerDB.GetPlayers();
        //}

        //public List<Player> GetPList2()
        //{
        //    return PlayerDB.GetPlayers2();
        //}
        //public List<Player> GetPList3()
        //{
        //    return PlayerDB.GetPlayers3();
        //}


        //public List<Player> GetTeamPlayers(string code)
        //{
        //    return PlayerDB.GetTeamPlayers(code);
        //}


    }
}

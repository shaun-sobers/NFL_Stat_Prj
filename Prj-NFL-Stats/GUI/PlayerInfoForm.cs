using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prj_NFL_Stats.BLL;

namespace Prj_NFL_Stats.GUI
{
    public partial class PlayerInfoForm : Form
    {
        public PlayerInfoForm()
        {
            InitializeComponent();
        }

        private void PlayerInfoForm_Load(object sender, EventArgs e)
        {
            Player p1 = new Player();
            Team t1 = new Team();
            Stat s1 = new Stat();

          
            p1 = p1.GetAPlayer(TeamForm.SearchPlayer);
    
            t1 = t1.GetATeamCode(p1.Team.Trim());


            List<Stat> listStat = new List<Stat>();

       
            listStat = s1.ListPlayerStats(TeamForm.SearchPlayer);
            ShowStatTotal(listStat);

            

          txtName.Text = p1.FirstName.Trim() +" "+ p1.LastName.Trim();
          txtTeam.Text = p1.Team.Trim();
          txtByeWeek.Text = t1.ByeWeek.ToString();

        }

        private void ShowStatTotal(List<Stat> listS)
        {
            int catches = 0;
            int totalyards = 0;
            int touchdowns=0;
            int rushtds = 0;
            int recievingtds = 0;
            int rushingyards = 0;
            int recievingsyards = 0;
            int passattempts = 0;
            int passyards = 0;
            int passtds = 0;
            int totaltos = 0;
            int carries = 0;
            int fumbles = 0;
            int ints = 0;
            int sacks = 0;
            int snaps = 0;
            int turnovers = 0;
            int totaltds = 0;
            int games = 0;
            


            foreach (Stat ss in listS)
            {
                catches = catches+ss.Receptions;
                recievingsyards = recievingsyards + ss.RecievingYards;
                passattempts = passattempts + ss.PassAttempts;
                passyards = passyards + ss.PassingYards;
                passtds = passtds + ss.PassingTouchdowns;
                fumbles = fumbles + ss.Fumbles;
                ints = ints + ss.Interceptions;
                sacks = sacks + ss.Sacks;
                carries = carries + ss.Rushes;
                rushingyards = rushingyards + ss.RushingYards;
                rushtds = rushtds + ss.RushingTouchDowns;
                snaps = snaps+ss.OffensiveSnaps;
                fumbles = fumbles + ss.Fumbles;
                ints = ints + ss.Interceptions;
                sacks = sacks + ss.Sacks;
                games++;
            }


            double avgRec = 0;
            if (catches == 0)
            {
                avgRec = 0;
            }
            else
            {
                avgRec = recievingsyards / catches;
            }


            txtRecs.Text = catches.ToString();
            txtRecYards.Text = recievingsyards.ToString();
            txtRecTds.Text = recievingtds.ToString();
            txtAvgRecYrds.Text = avgRec.ToString();


            double avgCar = 0;
            if (carries == 0)
            {
                avgCar = 0;
            }
            else
            {
                avgCar = rushingyards / carries;
            }
            txtRushingTD.Text = rushtds.ToString();
            txtRushYards.Text = rushingyards.ToString();
            txtCarries.Text = carries.ToString();
            txtAvgRushyrds.Text = avgCar.ToString();


            double avgPass = 0;
            if (passattempts == 0)
            {
                avgPass = 0;
            }
            else
            {
                avgPass = passyards / passattempts;
            }
            

            txtPassAttempts.Text = passattempts.ToString();
            txtPassTds.Text = passtds.ToString();
            txtPassYards.Text = passyards.ToString();
            txtavgPassyrds.Text = avgPass.ToString();

            Int32 totalTurnovers = fumbles + ints + sacks;
            txtFumble.Text = fumbles.ToString();
            txtInts.Text = ints.ToString();
            txtSacks.Text = sacks.ToString();
            txtTurnovers.Text = totalTurnovers.ToString();

            totalyards = rushingyards + recievingsyards;
            totaltds = rushtds + recievingtds;
            txtTotalTds.Text = totaltds.ToString();
            txtTotalTards.Text = totalyards.ToString();
            txtSnaps.Text = snaps.ToString();
            txtGamesPlayed.Text = games.ToString();


           


           
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

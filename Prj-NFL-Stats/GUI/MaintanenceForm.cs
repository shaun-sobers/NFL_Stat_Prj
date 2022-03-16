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
    public partial class MaintanenceForm : Form
    {
        public MaintanenceForm()
        {
            InitializeComponent();
        }

        Int32 currentweek;
        List<Stat> CurrentStats = new List<Stat>();
        Int32 currentPlayer;
        Player p1 = new Player();
        private void MaintanenceForm_Load(object sender, EventArgs e)
        {
            dataGridPlayerStat.DataSource = CurrentStats;
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Int32 playerid = Convert.ToInt32(txtSearch.Text);
            Stat s1 = new Stat();
            p1 = p1.GetAPlayer(playerid);
            txtName.Text = p1.FirstName.Trim() + p1.LastName.Trim();
            txtTeam.Text = p1.Team.Trim();
            
            txtNumber.Text = p1.PlayerId.ToString();

            dataGridPlayerStat.DataSource = s1.ListPlayerStats(playerid);
            

        }

        private void btnSaveStat_Click(object sender, EventArgs e)
        {
            Stat s1 = new Stat();
            DialogResult dialogResult = MessageBox.Show("Are you Sure you want to save?", "Save?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                s1.Week = Convert.ToInt32(txtWeek.Text);
                s1.PlayerId = Convert.ToInt32(txtNumber.Text);
                s1.Rushes = Convert.ToInt32(txtRushes.Text);
                s1.RushingYards= Convert.ToInt32(txtRushingYards.Text);
                s1.RushingTouchDowns = Convert.ToInt32(txtRushTDs.Text);
                s1.Targets = Convert.ToInt32(txtTargets.Text);
                s1.Receptions = Convert.ToInt32(txtReceptions.Text);
                s1.RecievingYards = Convert.ToInt32(txtRecievingYrds.Text);
                s1.RecievingTouchdowns = Convert.ToInt32(txtRecievingTds.Text);
                s1.OffensiveSnaps = Convert.ToInt32(txtOffenceSnaps.Text);
                s1.PassAttempts = Convert.ToInt32(txtPassAttempts.Text);
                s1.PassCompletions = Convert.ToInt32(txtPassCompletions.Text);
                s1.PassingTouchdowns = Convert.ToInt32(txtPassingTds.Text);
                s1.Interceptions = Convert.ToInt32(txtInts.Text);
                s1.Sacks = Convert.ToInt32(txtSacks.Text);
                s1.Fumbles = Convert.ToInt32(txtFumbles.Text);

                MessageBox.Show("Stat was saved");
                s1.AddStats(s1);

                CurrentStats.Add(s1);
                txtRushes.Text = txtRushingYards.Text = txtRushTDs.Text = txtTargets.Text = txtReceptions.Text =
               txtRecievingYrds.Text = txtRecievingTds.Text = txtOffenceSnaps.Text = txtPassAttempts.Text =
               txtPassCompletions.Text = txtPassingTds.Text = txtInts.Text = txtSacks.Text = txtFumbles.Text= "";

                dataGridPlayerStat.DataSource = s1.ListPlayerStats(s1.PlayerId);
                int currentweek = Convert.ToInt32(txtWeek.Text);
                txtWeek.Text = currentweek++.ToString();


            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btnNextPlayer_Click(object sender, EventArgs e)
        {
            currentweek = 1;
            Int32 currentid = p1.PlayerId;
            currentid++;

            p1 = p1.GetAPlayer(currentid);
            txtName.Text = p1.FirstName.Trim() + p1.LastName.Trim();
            txtTeam.Text = p1.Team.Trim();
            txtWeek.Text = currentweek.ToString();
            txtNumber.Text = p1.PlayerId.ToString();

            Stat s1 = new Stat();

            dataGridPlayerStat.DataSource = s1.ListPlayerStats(p1.PlayerId);
        }

        private void btnPrevPlayer_Click(object sender, EventArgs e)
        {
            Int32 currentid = p1.PlayerId;
            currentid--;

            p1 = p1.GetAPlayer(currentid);
            txtName.Text = p1.FirstName.Trim() + p1.LastName.Trim();
            txtTeam.Text = p1.Team.Trim();
            txtWeek.Text = currentweek.ToString();
            txtNumber.Text = p1.PlayerId.ToString();
        }

        private void btnNextWeek_Click(object sender, EventArgs e)
        {
            currentweek++;
            txtWeek.Text = currentweek.ToString();
        }
    }
}

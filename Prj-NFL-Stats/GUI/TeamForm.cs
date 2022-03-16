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
    public partial class TeamForm : Form
    {
        public TeamForm()
        {
            InitializeComponent();
        }

        public static Int32 SearchPlayer = 0;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TeamForm_Load(object sender, EventArgs e)
        {

            Team tmpTm = new Team();
            List<Team> listT = new List<Team>();
            listT = tmpTm.GetTeamList();

            if (cmbTeams.Items.Count == 0)
            {
                foreach (Team tm in listT)
                {
                    cmbTeams.Items.Add(tm.City.Trim()+"," +tm.Name.Trim());
                }
            }


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string team = cmbTeams.SelectedItem.ToString();
            string[] teamField = team.Split(',');
            string teamId = teamField[0];
            string teamName = teamField[1];
            string trimedteam= teamId.Replace(" ", "");
            pictureBoxTeam.ImageLocation = "C:/Users/Shaun/source/repos/Prj-NFL-Stats/NFL-Teams/!"+trimedteam.Trim()+".png";
            pictureBoxName.ImageLocation = "C:/Users/Shaun/source/repos/Prj-NFL-Stats/Team-Name/" + trimedteam.Trim() + ".png";
            pictureBoxTeam.Load();
            pictureBoxName.Load();
            Team t1 = new Team();
            t1 = t1.GetATeam(teamName);
            txtTeamCode.Text = t1.TeamCode;
            txtByeWeek.Text = t1.ByeWeek.ToString();
            
            Player p1 = new Player();

            dataGridViewPlayers.DataSource = p1.GetTeamPlayers(t1.TeamCode);


            
           





        }

        private void dataGridViewPlayers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dataGridViewPlayers.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewPlayers.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["PlayerId"].Value);
            Player p1 = new Player();
            p1 = p1.GetAPlayer(Convert.ToInt32(cellValue));

            SearchPlayer = p1.PlayerId;

            PlayerInfoForm f1 = new PlayerInfoForm();
            f1.Show();

            
        }
    }
}

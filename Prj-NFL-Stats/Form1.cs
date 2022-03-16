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

namespace Prj_NFL_Stats
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rbQb_CheckedChanged(object sender, EventArgs e)
        {
            if (rbQb.Checked == true)
            {
                Int32 index = 1;
                Player tmpP1 = new Player();
                List<Player> listP, listP2, listP3 = new List<Player>();
                

                
                List<Player> ListC = tmpP1.GetQBList();
                if (ListC.Count != 0)
                {
                    dataGridViewPlayers.DataSource = ListC;
                    
                }


            } else
            {
                
            }
        }

        private void rbRb_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRb.Checked == true)
            {
                Int32 index = 1;
                Player tmpP1 = new Player();
                List<Player> listP, listP2, listP3 = new List<Player>();
                listP = tmpP1.GetRbList();


                List<Player> ListC = tmpP1.GetRbList();
                if (ListC.Count != 0)
                {
                    dataGridViewPlayers.DataSource = ListC;

                }


            }
            else
            {
               
            }
        }

        private void rbWr_CheckedChanged(object sender, EventArgs e)
        {
            if (rbWr.Checked == true)
            {
                Int32 index = 1;
                Player tmpP1 = new Player();
                List<Player> listP, listP2, listP3 = new List<Player>();
                listP = tmpP1.GetRbList();


                List<Player> ListC = tmpP1.GetWRList();
                if (ListC.Count != 0)
                {
                    dataGridViewPlayers.DataSource = ListC;

                }


            }
            else
            {
               
            }
        }

        private void rbTE_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTE.Checked == true)
            {
                Int32 index = 1;
                Player tmpP1 = new Player();
                List<Player> listP, listP2, listP3 = new List<Player>();
                listP = tmpP1.GetRbList();


                List<Player> ListC = tmpP1.GetTEList();
                if (ListC.Count != 0)
                {
                    dataGridViewPlayers.DataSource = ListC;

                }


            }
            else
            {

            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

            int selectedrowindex = dataGridViewPlayers.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewPlayers.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["PlayerId"].Value);
            Player p1 = new Player();
            Team t1 = new Team();

            p1=p1.GetAPlayer(Convert.ToInt32(cellValue));

            t1 = t1.GetATeamCode(p1.Team);

            txtFName.Text = p1.FirstName;
            txtLName.Text = p1.LastName;
            txtTeam.Text = p1.Team;
           txtByeWeek.Text = t1.ByeWeek.ToString();
        }

        private void dataGridViewPlayers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

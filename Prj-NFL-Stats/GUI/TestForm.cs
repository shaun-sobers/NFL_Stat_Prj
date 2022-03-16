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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            int count = 0;
            PlayerTest p1 = new PlayerTest();
            List<PlayerTest> listP = new List<PlayerTest>();
            listP = p1.GetPlayerList();
            dataGridPlayers.DataSource = listP;
            foreach(PlayerTest p2 in listP)
            {
                count++;
            }
            lblCount.Text = count.ToString();
        }
    }
}

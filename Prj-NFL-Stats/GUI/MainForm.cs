using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj_NFL_Stats.GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static string Search = "";
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            openChildForm(new Form1());
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            openChildForm(new TeamForm());
        }

        private void bunifuThinButton23_Click_1(object sender, EventArgs e)
        {
            openChildForm(new TeamForm());
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {
            Search = txtSearch.text;

            openChildForm(new SearchForm());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search = txtSearch.text;
        }
    }
}

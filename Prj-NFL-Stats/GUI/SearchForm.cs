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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

            Player p1 = new Player();
            List<Player> listP = new List<Player>();
            List<string> lists = new List<string>();
            listP = p1.GetPList();
            List<Player> newList = new List<Player>();
            string searched = MainForm.Search;

            foreach (Player p in listP)
            {
                if (p.FirstName.Contains(searched) || p.LastName.Contains(searched))
                {
                    newList.Add(p);
                }

            }
            dataGridSearch.DataSource = newList;
            dataGridSearch.Columns.RemoveAt(0);
            
        }
    }
}

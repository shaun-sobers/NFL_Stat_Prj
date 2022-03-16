using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace Prj_NFL_Stats.GUI
{
    public class internetstat
    {
        public string information1;
        public string information2;
    }
    public partial class GetInfoForm : Form
    {
        HtmlWeb web = new HtmlWeb();
        DataTable table;
        public GetInfoForm()
        {
            InitializeComponent();
            InitTable();
        }

        private void InitTable()
        {
            table = new DataTable("PlayerStats");
            table.Columns.Add("Touchdowns", typeof(int));
            table.Rows.Add("1");
            dataGridViewInfo.DataSource = table;
        }

        private async Task<string> InfoFromPage ()
        {
            var doc = await Task.Factory.StartNew(() => web.Load("https://www.pro-football-reference.com/players/H/HenrDe00.htm"));
            var info = doc.DocumentNode.SelectNodes("//*[@id=\"stats.79\"]");
            var info1 = info.Select(node => node.InnerText);
            return info.ToString();
        }

         
        private async void GetInfoForm_Load(object sender, EventArgs e)
        {

            var ranking = await InfoFromPage();

            foreach (var rank in ranking)
            {
                table.Rows.Add(rank);
            }
            
        }
    }
}

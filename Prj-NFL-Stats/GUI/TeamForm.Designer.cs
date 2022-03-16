
namespace Prj_NFL_Stats.GUI
{
    partial class TeamForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTeamCode = new System.Windows.Forms.TextBox();
            this.txtByeWeek = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBoxTeam = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbTeams = new System.Windows.Forms.ComboBox();
            this.pictureBoxName = new System.Windows.Forms.PictureBox();
            this.dataGridViewPlayers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bye Week:";
            // 
            // txtTeamCode
            // 
            this.txtTeamCode.Location = new System.Drawing.Point(94, 78);
            this.txtTeamCode.Name = "txtTeamCode";
            this.txtTeamCode.Size = new System.Drawing.Size(100, 22);
            this.txtTeamCode.TabIndex = 4;
            // 
            // txtByeWeek
            // 
            this.txtByeWeek.Location = new System.Drawing.Point(125, 120);
            this.txtByeWeek.Name = "txtByeWeek";
            this.txtByeWeek.Size = new System.Drawing.Size(100, 22);
            this.txtByeWeek.TabIndex = 5;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "!Arizona.png");
            this.imageList1.Images.SetKeyName(1, "!Atlanta.png");
            this.imageList1.Images.SetKeyName(2, "!Baltimore.png");
            this.imageList1.Images.SetKeyName(3, "!Bufallo.png");
            this.imageList1.Images.SetKeyName(4, "!Carolina.png");
            this.imageList1.Images.SetKeyName(5, "!Chicago.png");
            this.imageList1.Images.SetKeyName(6, "!Cincinnati.png");
            this.imageList1.Images.SetKeyName(7, "!Cleveland.png");
            this.imageList1.Images.SetKeyName(8, "!Dallas.png");
            this.imageList1.Images.SetKeyName(9, "!Denver.png");
            this.imageList1.Images.SetKeyName(10, "!Detroit.png");
            this.imageList1.Images.SetKeyName(11, "!GreenBay.png");
            this.imageList1.Images.SetKeyName(12, "!Houston.png");
            this.imageList1.Images.SetKeyName(13, "!Indianapolis.png");
            this.imageList1.Images.SetKeyName(14, "!Jacksonville.png");
            this.imageList1.Images.SetKeyName(15, "!KansasCity.png");
            this.imageList1.Images.SetKeyName(16, "!LAChargers.png");
            this.imageList1.Images.SetKeyName(17, "!LARams.png");
            this.imageList1.Images.SetKeyName(18, "!LasVegas.png");
            this.imageList1.Images.SetKeyName(19, "!Miami.png");
            this.imageList1.Images.SetKeyName(20, "!Minnesota.png");
            this.imageList1.Images.SetKeyName(21, "!NewEngland.png");
            this.imageList1.Images.SetKeyName(22, "!NewOrleans.png");
            this.imageList1.Images.SetKeyName(23, "!NewYorkGiants.png");
            this.imageList1.Images.SetKeyName(24, "!NewYorkJets.png");
            this.imageList1.Images.SetKeyName(25, "!Philadelphia.png");
            this.imageList1.Images.SetKeyName(26, "!Pittsburgh.png");
            this.imageList1.Images.SetKeyName(27, "!SanFrancisco.png");
            this.imageList1.Images.SetKeyName(28, "!Seattle.png");
            this.imageList1.Images.SetKeyName(29, "!TampaBay.png");
            this.imageList1.Images.SetKeyName(30, "!Tennesse.png");
            this.imageList1.Images.SetKeyName(31, "!Tennessee.png");
            this.imageList1.Images.SetKeyName(32, "!Washington.png");
            this.imageList1.Images.SetKeyName(33, "nfl-logo.png");
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBoxTeam
            // 
            this.pictureBoxTeam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxTeam.Location = new System.Drawing.Point(541, 267);
            this.pictureBoxTeam.Name = "pictureBoxTeam";
            this.pictureBoxTeam.Size = new System.Drawing.Size(233, 216);
            this.pictureBoxTeam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxTeam.TabIndex = 6;
            this.pictureBoxTeam.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(227, 81);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbTeams
            // 
            this.cmbTeams.FormattingEnabled = true;
            this.cmbTeams.Location = new System.Drawing.Point(94, 43);
            this.cmbTeams.Name = "cmbTeams";
            this.cmbTeams.Size = new System.Drawing.Size(208, 24);
            this.cmbTeams.TabIndex = 8;
            // 
            // pictureBoxName
            // 
            this.pictureBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxName.Location = new System.Drawing.Point(541, 22);
            this.pictureBoxName.Name = "pictureBoxName";
            this.pictureBoxName.Size = new System.Drawing.Size(233, 216);
            this.pictureBoxName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxName.TabIndex = 9;
            this.pictureBoxName.TabStop = false;
            // 
            // dataGridViewPlayers
            // 
            this.dataGridViewPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayers.Location = new System.Drawing.Point(12, 226);
            this.dataGridViewPlayers.Name = "dataGridViewPlayers";
            this.dataGridViewPlayers.RowHeadersWidth = 51;
            this.dataGridViewPlayers.RowTemplate.Height = 24;
            this.dataGridViewPlayers.Size = new System.Drawing.Size(479, 257);
            this.dataGridViewPlayers.TabIndex = 10;
            this.dataGridViewPlayers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPlayers_CellContentClick);
            // 
            // TeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 494);
            this.Controls.Add(this.dataGridViewPlayers);
            this.Controls.Add(this.pictureBoxName);
            this.Controls.Add(this.cmbTeams);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pictureBoxTeam);
            this.Controls.Add(this.txtByeWeek);
            this.Controls.Add(this.txtTeamCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeamForm";
            this.Text = "TeamForm";
            this.Load += new System.EventHandler(this.TeamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTeamCode;
        private System.Windows.Forms.TextBox txtByeWeek;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.PictureBox pictureBoxTeam;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbTeams;
        private System.Windows.Forms.PictureBox pictureBoxName;
        private System.Windows.Forms.DataGridView dataGridViewPlayers;
    }
}
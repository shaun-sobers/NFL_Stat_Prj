
namespace Prj_NFL_Stats.GUI
{
    partial class MaintanenceForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.MaskedTextBox();
            this.txtTeam = new System.Windows.Forms.MaskedTextBox();
            this.txtWeek = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridPlayerStat = new System.Windows.Forms.DataGridView();
            this.txtRushes = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRushingYards = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRushTDs = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTargets = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReceptions = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRecievingYrds = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRecievingTds = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPassingTds = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassCompletions = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPassAttempts = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOffenceSnaps = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtInts = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSacks = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnNextPlayer = new System.Windows.Forms.Button();
            this.btnSaveStat = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPrevPlayer = new System.Windows.Forms.Button();
            this.txtFumbles = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPlayerStat)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(96, 77);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam.Location = new System.Drawing.Point(96, 163);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(56, 20);
            this.lblTeam.TabIndex = 2;
            this.lblTeam.Text = "Team:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(155, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 3;
            // 
            // txtTeam
            // 
            this.txtTeam.Location = new System.Drawing.Point(155, 161);
            this.txtTeam.Name = "txtTeam";
            this.txtTeam.Size = new System.Drawing.Size(100, 22);
            this.txtTeam.TabIndex = 4;
            // 
            // txtWeek
            // 
            this.txtWeek.Location = new System.Drawing.Point(155, 209);
            this.txtWeek.Name = "txtWeek";
            this.txtWeek.Size = new System.Drawing.Size(100, 22);
            this.txtWeek.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Week";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(170, 114);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(85, 22);
            this.txtNumber.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Number";
            // 
            // dataGridPlayerStat
            // 
            this.dataGridPlayerStat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPlayerStat.Location = new System.Drawing.Point(434, 58);
            this.dataGridPlayerStat.Name = "dataGridPlayerStat";
            this.dataGridPlayerStat.RowHeadersWidth = 51;
            this.dataGridPlayerStat.RowTemplate.Height = 24;
            this.dataGridPlayerStat.Size = new System.Drawing.Size(880, 305);
            this.dataGridPlayerStat.TabIndex = 9;
            // 
            // txtRushes
            // 
            this.txtRushes.Location = new System.Drawing.Point(220, 442);
            this.txtRushes.Name = "txtRushes";
            this.txtRushes.Size = new System.Drawing.Size(71, 22);
            this.txtRushes.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Rushes";
            // 
            // txtRushingYards
            // 
            this.txtRushingYards.Location = new System.Drawing.Point(220, 484);
            this.txtRushingYards.Name = "txtRushingYards";
            this.txtRushingYards.Size = new System.Drawing.Size(71, 22);
            this.txtRushingYards.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Rushing Yards";
            // 
            // txtRushTDs
            // 
            this.txtRushTDs.Location = new System.Drawing.Point(220, 530);
            this.txtRushTDs.Name = "txtRushTDs";
            this.txtRushTDs.Size = new System.Drawing.Size(71, 22);
            this.txtRushTDs.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 532);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "RushingTouchdowns";
            // 
            // txtTargets
            // 
            this.txtTargets.Location = new System.Drawing.Point(472, 442);
            this.txtTargets.Name = "txtTargets";
            this.txtTargets.Size = new System.Drawing.Size(71, 22);
            this.txtTargets.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(400, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Targets";
            // 
            // txtReceptions
            // 
            this.txtReceptions.Location = new System.Drawing.Point(472, 486);
            this.txtReceptions.Name = "txtReceptions";
            this.txtReceptions.Size = new System.Drawing.Size(77, 22);
            this.txtReceptions.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(373, 488);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Receptions";
            // 
            // txtRecievingYrds
            // 
            this.txtRecievingYrds.Location = new System.Drawing.Point(498, 534);
            this.txtRecievingYrds.Name = "txtRecievingYrds";
            this.txtRecievingYrds.Size = new System.Drawing.Size(61, 22);
            this.txtRecievingYrds.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(352, 534);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Recieving Yards";
            // 
            // txtRecievingTds
            // 
            this.txtRecievingTds.Location = new System.Drawing.Point(488, 575);
            this.txtRecievingTds.Name = "txtRecievingTds";
            this.txtRecievingTds.Size = new System.Drawing.Size(71, 22);
            this.txtRecievingTds.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(299, 577);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "RecievingTouchdown";
            // 
            // txtPassingTds
            // 
            this.txtPassingTds.Location = new System.Drawing.Point(782, 573);
            this.txtPassingTds.Name = "txtPassingTds";
            this.txtPassingTds.Size = new System.Drawing.Size(71, 22);
            this.txtPassingTds.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(589, 573);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Passing Touchdowns";
            // 
            // txtPassCompletions
            // 
            this.txtPassCompletions.Location = new System.Drawing.Point(792, 527);
            this.txtPassCompletions.Name = "txtPassCompletions";
            this.txtPassCompletions.Size = new System.Drawing.Size(61, 22);
            this.txtPassCompletions.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(625, 529);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "Pass Completions";
            // 
            // txtPassAttempts
            // 
            this.txtPassAttempts.Location = new System.Drawing.Point(776, 484);
            this.txtPassAttempts.Name = "txtPassAttempts";
            this.txtPassAttempts.Size = new System.Drawing.Size(77, 22);
            this.txtPassAttempts.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(651, 486);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "Pass Attempts";
            // 
            // txtOffenceSnaps
            // 
            this.txtOffenceSnaps.Location = new System.Drawing.Point(782, 438);
            this.txtOffenceSnaps.Name = "txtOffenceSnaps";
            this.txtOffenceSnaps.Size = new System.Drawing.Size(71, 22);
            this.txtOffenceSnaps.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(625, 438);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = "Offensive Snaps";
            // 
            // txtInts
            // 
            this.txtInts.Location = new System.Drawing.Point(1025, 484);
            this.txtInts.Name = "txtInts";
            this.txtInts.Size = new System.Drawing.Size(77, 22);
            this.txtInts.TabIndex = 37;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(909, 486);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 20);
            this.label14.TabIndex = 36;
            this.label14.Text = "Interceptions";
            // 
            // txtSacks
            // 
            this.txtSacks.Location = new System.Drawing.Point(1031, 438);
            this.txtSacks.Name = "txtSacks";
            this.txtSacks.Size = new System.Drawing.Size(71, 22);
            this.txtSacks.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(959, 440);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 20);
            this.label15.TabIndex = 34;
            this.label15.Text = "Sacks";
            // 
            // btnNextPlayer
            // 
            this.btnNextPlayer.Location = new System.Drawing.Point(541, 9);
            this.btnNextPlayer.Name = "btnNextPlayer";
            this.btnNextPlayer.Size = new System.Drawing.Size(81, 40);
            this.btnNextPlayer.TabIndex = 39;
            this.btnNextPlayer.Text = "Player ->";
            this.btnNextPlayer.UseVisualStyleBackColor = true;
            this.btnNextPlayer.Click += new System.EventHandler(this.btnNextPlayer_Click);
            // 
            // btnSaveStat
            // 
            this.btnSaveStat.Location = new System.Drawing.Point(935, 568);
            this.btnSaveStat.Name = "btnSaveStat";
            this.btnSaveStat.Size = new System.Drawing.Size(167, 40);
            this.btnSaveStat.TabIndex = 40;
            this.btnSaveStat.Text = "Save Stat";
            this.btnSaveStat.UseVisualStyleBackColor = true;
            this.btnSaveStat.Click += new System.EventHandler(this.btnSaveStat_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(932, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 22);
            this.txtSearch.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(848, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 20);
            this.label16.TabIndex = 41;
            this.label16.Text = "Player ID";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1047, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(122, 27);
            this.btnSearch.TabIndex = 43;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPrevPlayer
            // 
            this.btnPrevPlayer.Location = new System.Drawing.Point(434, 9);
            this.btnPrevPlayer.Name = "btnPrevPlayer";
            this.btnPrevPlayer.Size = new System.Drawing.Size(81, 40);
            this.btnPrevPlayer.TabIndex = 44;
            this.btnPrevPlayer.Text = "<- Player";
            this.btnPrevPlayer.UseVisualStyleBackColor = true;
            this.btnPrevPlayer.Click += new System.EventHandler(this.btnPrevPlayer_Click);
            // 
            // txtFumbles
            // 
            this.txtFumbles.Location = new System.Drawing.Point(1017, 525);
            this.txtFumbles.Name = "txtFumbles";
            this.txtFumbles.Size = new System.Drawing.Size(85, 22);
            this.txtFumbles.TabIndex = 46;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(909, 525);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 20);
            this.label17.TabIndex = 45;
            this.label17.Text = "Fumbles";
            // 
            // MaintanenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 677);
            this.Controls.Add(this.txtFumbles);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnPrevPlayer);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnSaveStat);
            this.Controls.Add(this.btnNextPlayer);
            this.Controls.Add(this.txtInts);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtSacks);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtPassingTds);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPassCompletions);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPassAttempts);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtOffenceSnaps);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtRecievingTds);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtRecievingYrds);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtReceptions);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTargets);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRushTDs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRushingYards);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRushes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridPlayerStat);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWeek);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTeam);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.lblName);
            this.Name = "MaintanenceForm";
            this.Text = "MaintanenceForm";
            this.Load += new System.EventHandler(this.MaintanenceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPlayerStat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.MaskedTextBox txtName;
        private System.Windows.Forms.MaskedTextBox txtTeam;
        private System.Windows.Forms.MaskedTextBox txtWeek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridPlayerStat;
        private System.Windows.Forms.MaskedTextBox txtRushes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtRushingYards;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtRushTDs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtTargets;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtReceptions;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtRecievingYrds;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtRecievingTds;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtPassingTds;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtPassCompletions;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txtPassAttempts;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox txtOffenceSnaps;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox txtInts;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox txtSacks;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnNextPlayer;
        private System.Windows.Forms.Button btnSaveStat;
        private System.Windows.Forms.MaskedTextBox txtSearch;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPrevPlayer;
        private System.Windows.Forms.MaskedTextBox txtFumbles;
        private System.Windows.Forms.Label label17;
    }
}
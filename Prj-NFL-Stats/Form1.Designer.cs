
namespace Prj_NFL_Stats
{
    partial class Form1
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
            this.rbQb = new System.Windows.Forms.RadioButton();
            this.rbRb = new System.Windows.Forms.RadioButton();
            this.rbWr = new System.Windows.Forms.RadioButton();
            this.rbTE = new System.Windows.Forms.RadioButton();
            this.groupBoxPosition = new System.Windows.Forms.GroupBox();
            this.dataGridViewPlayers = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtByeWeek = new System.Windows.Forms.TextBox();
            this.txtTeam = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.groupBoxPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbQb
            // 
            this.rbQb.AutoSize = true;
            this.rbQb.Location = new System.Drawing.Point(19, 41);
            this.rbQb.Name = "rbQb";
            this.rbQb.Size = new System.Drawing.Size(108, 21);
            this.rbQb.TabIndex = 1;
            this.rbQb.TabStop = true;
            this.rbQb.Text = "Quarterback";
            this.rbQb.UseVisualStyleBackColor = true;
            this.rbQb.CheckedChanged += new System.EventHandler(this.rbQb_CheckedChanged);
            // 
            // rbRb
            // 
            this.rbRb.AutoSize = true;
            this.rbRb.Location = new System.Drawing.Point(19, 69);
            this.rbRb.Name = "rbRb";
            this.rbRb.Size = new System.Drawing.Size(112, 21);
            this.rbRb.TabIndex = 2;
            this.rbRb.TabStop = true;
            this.rbRb.Text = "Runningback";
            this.rbRb.UseVisualStyleBackColor = true;
            this.rbRb.CheckedChanged += new System.EventHandler(this.rbRb_CheckedChanged);
            // 
            // rbWr
            // 
            this.rbWr.AutoSize = true;
            this.rbWr.Location = new System.Drawing.Point(19, 97);
            this.rbWr.Name = "rbWr";
            this.rbWr.Size = new System.Drawing.Size(117, 21);
            this.rbWr.TabIndex = 3;
            this.rbWr.TabStop = true;
            this.rbWr.Text = "WideReciever";
            this.rbWr.UseVisualStyleBackColor = true;
            this.rbWr.CheckedChanged += new System.EventHandler(this.rbWr_CheckedChanged);
            // 
            // rbTE
            // 
            this.rbTE.AutoSize = true;
            this.rbTE.Location = new System.Drawing.Point(19, 125);
            this.rbTE.Name = "rbTE";
            this.rbTE.Size = new System.Drawing.Size(86, 21);
            this.rbTE.TabIndex = 4;
            this.rbTE.TabStop = true;
            this.rbTE.Text = "TightEnd";
            this.rbTE.UseVisualStyleBackColor = true;
            this.rbTE.CheckedChanged += new System.EventHandler(this.rbTE_CheckedChanged);
            // 
            // groupBoxPosition
            // 
            this.groupBoxPosition.Controls.Add(this.rbTE);
            this.groupBoxPosition.Controls.Add(this.rbWr);
            this.groupBoxPosition.Controls.Add(this.rbRb);
            this.groupBoxPosition.Controls.Add(this.rbQb);
            this.groupBoxPosition.Location = new System.Drawing.Point(24, 11);
            this.groupBoxPosition.Name = "groupBoxPosition";
            this.groupBoxPosition.Size = new System.Drawing.Size(159, 164);
            this.groupBoxPosition.TabIndex = 5;
            this.groupBoxPosition.TabStop = false;
            this.groupBoxPosition.Text = "Positions";
            // 
            // dataGridViewPlayers
            // 
            this.dataGridViewPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayers.Location = new System.Drawing.Point(24, 256);
            this.dataGridViewPlayers.Name = "dataGridViewPlayers";
            this.dataGridViewPlayers.RowHeadersWidth = 51;
            this.dataGridViewPlayers.RowTemplate.Height = 24;
            this.dataGridViewPlayers.Size = new System.Drawing.Size(599, 208);
            this.dataGridViewPlayers.TabIndex = 6;
            this.dataGridViewPlayers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPlayers_CellContentClick);
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.Location = new System.Drawing.Point(682, 370);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 7;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtByeWeek);
            this.groupBox1.Controls.Add(this.txtTeam);
            this.groupBox1.Controls.Add(this.txtLName);
            this.groupBox1.Controls.Add(this.txtFName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblFirstName);
            this.groupBox1.Location = new System.Drawing.Point(189, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 137);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // txtByeWeek
            // 
            this.txtByeWeek.Location = new System.Drawing.Point(120, 108);
            this.txtByeWeek.Name = "txtByeWeek";
            this.txtByeWeek.Size = new System.Drawing.Size(100, 22);
            this.txtByeWeek.TabIndex = 7;
            // 
            // txtTeam
            // 
            this.txtTeam.Location = new System.Drawing.Point(120, 78);
            this.txtTeam.Name = "txtTeam";
            this.txtTeam.Size = new System.Drawing.Size(100, 22);
            this.txtTeam.TabIndex = 6;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(120, 50);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(100, 22);
            this.txtLName.TabIndex = 5;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(120, 18);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(100, 22);
            this.txtFName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "By Week:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Team:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(22, 18);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 17);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 494);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dataGridViewPlayers);
            this.Controls.Add(this.groupBoxPosition);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxPosition.ResumeLayout(false);
            this.groupBoxPosition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbQb;
        private System.Windows.Forms.RadioButton rbRb;
        private System.Windows.Forms.RadioButton rbWr;
        private System.Windows.Forms.RadioButton rbTE;
        private System.Windows.Forms.GroupBox groupBoxPosition;
        private System.Windows.Forms.DataGridView dataGridViewPlayers;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtByeWeek;
        private System.Windows.Forms.TextBox txtTeam;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFirstName;
    }
}


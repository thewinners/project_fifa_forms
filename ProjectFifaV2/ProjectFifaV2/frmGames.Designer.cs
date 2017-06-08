namespace ProjectFifaV2
{
    partial class frmGames
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
            this.lvOverview = new System.Windows.Forms.ListView();
            this.clmHomeTeam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHomeTeamScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAwayTeamScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAwayTeam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblResultsOverview = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvOverview
            // 
            this.lvOverview.BackColor = System.Drawing.Color.Black;
            this.lvOverview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmHomeTeam,
            this.clmHomeTeamScore,
            this.clmAwayTeamScore,
            this.clmAwayTeam});
            this.lvOverview.ForeColor = System.Drawing.Color.White;
            this.lvOverview.Location = new System.Drawing.Point(182, 31);
            this.lvOverview.Margin = new System.Windows.Forms.Padding(4);
            this.lvOverview.Name = "lvOverview";
            this.lvOverview.Size = new System.Drawing.Size(412, 430);
            this.lvOverview.TabIndex = 8;
            this.lvOverview.UseCompatibleStateImageBehavior = false;
            this.lvOverview.View = System.Windows.Forms.View.Details;
            this.lvOverview.SelectedIndexChanged += new System.EventHandler(this.lvOverview_SelectedIndexChanged);
            // 
            // clmHomeTeam
            // 
            this.clmHomeTeam.Text = "HomeTeam";
            this.clmHomeTeam.Width = 100;
            // 
            // clmHomeTeamScore
            // 
            this.clmHomeTeamScore.Text = "Score";
            this.clmHomeTeamScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmHomeTeamScore.Width = 50;
            // 
            // clmAwayTeamScore
            // 
            this.clmAwayTeamScore.Text = "Score";
            this.clmAwayTeamScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmAwayTeamScore.Width = 50;
            // 
            // clmAwayTeam
            // 
            this.clmAwayTeam.Text = "Away Team";
            this.clmAwayTeam.Width = 100;
            // 
            // lblResultsOverview
            // 
            this.lblResultsOverview.AutoSize = true;
            this.lblResultsOverview.Location = new System.Drawing.Point(320, 9);
            this.lblResultsOverview.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultsOverview.Name = "lblResultsOverview";
            this.lblResultsOverview.Size = new System.Drawing.Size(117, 17);
            this.lblResultsOverview.TabIndex = 9;
            this.lblResultsOverview.Text = "Results Overview";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(22, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 70);
            this.button1.TabIndex = 10;
            this.button1.Text = "Load Results";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(22, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 93);
            this.button2.TabIndex = 11;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(618, 463);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblResultsOverview);
            this.Controls.Add(this.lvOverview);
            this.Name = "frmGames";
            this.Text = "frmGames";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvOverview;
        private System.Windows.Forms.ColumnHeader clmHomeTeam;
        private System.Windows.Forms.ColumnHeader clmHomeTeamScore;
        private System.Windows.Forms.ColumnHeader clmAwayTeamScore;
        private System.Windows.Forms.ColumnHeader clmAwayTeam;
        private System.Windows.Forms.Label lblResultsOverview;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
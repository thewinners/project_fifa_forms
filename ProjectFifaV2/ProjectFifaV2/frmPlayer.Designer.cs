﻿namespace ProjectFifaV2
{
    partial class frmPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlayer));
            this.btnEditPrediction = new System.Windows.Forms.Button();
            this.btnClearPrediction = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblResultsOverview = new System.Windows.Forms.Label();
            this.btnShowRanking = new System.Windows.Forms.Button();
            this.lvOverview = new System.Windows.Forms.ListView();
            this.clmHomeTeam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHomeTeamScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAwayTeamScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAwayTeam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlPredCard = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnEditPrediction
            // 
            this.btnEditPrediction.Location = new System.Drawing.Point(485, 87);
            this.btnEditPrediction.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditPrediction.Name = "btnEditPrediction";
            this.btnEditPrediction.Size = new System.Drawing.Size(141, 37);
            this.btnEditPrediction.TabIndex = 1;
            this.btnEditPrediction.Text = "Edit Prediction";
            this.btnEditPrediction.UseVisualStyleBackColor = true;
            // 
            // btnClearPrediction
            // 
            this.btnClearPrediction.Location = new System.Drawing.Point(485, 146);
            this.btnClearPrediction.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearPrediction.Name = "btnClearPrediction";
            this.btnClearPrediction.Size = new System.Drawing.Size(141, 37);
            this.btnClearPrediction.TabIndex = 2;
            this.btnClearPrediction.Text = "Clear Prediction";
            this.btnClearPrediction.UseVisualStyleBackColor = true;
            this.btnClearPrediction.Click += new System.EventHandler(this.btnClearPrediction_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(485, 213);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(141, 37);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblResultsOverview
            // 
            this.lblResultsOverview.AutoSize = true;
            this.lblResultsOverview.Location = new System.Drawing.Point(776, 25);
            this.lblResultsOverview.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultsOverview.Name = "lblResultsOverview";
            this.lblResultsOverview.Size = new System.Drawing.Size(117, 17);
            this.lblResultsOverview.TabIndex = 5;
            this.lblResultsOverview.Text = "Results Overview";
            // 
            // btnShowRanking
            // 
            this.btnShowRanking.Location = new System.Drawing.Point(485, 26);
            this.btnShowRanking.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowRanking.Name = "btnShowRanking";
            this.btnShowRanking.Size = new System.Drawing.Size(141, 37);
            this.btnShowRanking.TabIndex = 6;
            this.btnShowRanking.Text = "Show Ranking";
            this.btnShowRanking.UseVisualStyleBackColor = true;
            this.btnShowRanking.Click += new System.EventHandler(this.btnShowRanking_Click);
            // 
            // lvOverview
            // 
            this.lvOverview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmHomeTeam,
            this.clmHomeTeamScore,
            this.clmAwayTeamScore,
            this.clmAwayTeam});
            this.lvOverview.Location = new System.Drawing.Point(635, 44);
            this.lvOverview.Margin = new System.Windows.Forms.Padding(4);
            this.lvOverview.Name = "lvOverview";
            this.lvOverview.Size = new System.Drawing.Size(412, 738);
            this.lvOverview.TabIndex = 7;
            this.lvOverview.UseCompatibleStateImageBehavior = false;
            this.lvOverview.View = System.Windows.Forms.View.Details;
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
            // pnlPredCard
            // 
            this.pnlPredCard.Location = new System.Drawing.Point(16, 44);
            this.pnlPredCard.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPredCard.Name = "pnlPredCard";
            this.pnlPredCard.Size = new System.Drawing.Size(461, 737);
            this.pnlPredCard.TabIndex = 8;
            // 
            // frmPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 898);
            this.Controls.Add(this.pnlPredCard);
            this.Controls.Add(this.lvOverview);
            this.Controls.Add(this.btnShowRanking);
            this.Controls.Add(this.lblResultsOverview);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnClearPrediction);
            this.Controls.Add(this.btnEditPrediction);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayerName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditPrediction;
        private System.Windows.Forms.Button btnClearPrediction;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblResultsOverview;
        private System.Windows.Forms.Button btnShowRanking;
        private System.Windows.Forms.ListView lvOverview;
        private System.Windows.Forms.ColumnHeader clmHomeTeam;
        private System.Windows.Forms.ColumnHeader clmHomeTeamScore;
        private System.Windows.Forms.ColumnHeader clmAwayTeamScore;
        private System.Windows.Forms.ColumnHeader clmAwayTeam;
        private System.Windows.Forms.Panel pnlPredCard;
    }
}
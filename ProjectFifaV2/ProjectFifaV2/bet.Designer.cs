namespace ProjectFifaV2
{
    partial class bet
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Team", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Team", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bet));
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.listviewBetGames = new System.Windows.Forms.ListView();
            this.Home = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numberOfGoalsHome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.numberOfGoalsAway = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.game_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPayOut = new System.Windows.Forms.Button();
            this.listViewGamesId = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(534, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "BET";
            this.button1.UseVisualStyleBackColor = true;
           // this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listviewBetGames
            // 
            this.listviewBetGames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Home,
            this.columnHeader1,
            this.columnHeader2});
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup2";
            listViewGroup2.Header = "Team";
            listViewGroup2.Name = "listViewGroup1";
            this.listviewBetGames.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.listviewBetGames.Location = new System.Drawing.Point(95, 12);
            this.listviewBetGames.Name = "listviewBetGames";
            this.listviewBetGames.Size = new System.Drawing.Size(241, 441);
            this.listviewBetGames.TabIndex = 4;
            this.listviewBetGames.UseCompatibleStateImageBehavior = false;
            // 
            // Home
            // 
            this.Home.Text = "Home";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.label2.Location = new System.Drawing.Point(379, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 51);
            this.label2.TabIndex = 6;
            this.label2.Text = "Project Fifa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.label3.Location = new System.Drawing.Point(438, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bet App";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // numberOfGoalsHome
            // 
            this.numberOfGoalsHome.Location = new System.Drawing.Point(394, 405);
            this.numberOfGoalsHome.Name = "numberOfGoalsHome";
            this.numberOfGoalsHome.Size = new System.Drawing.Size(107, 22);
            this.numberOfGoalsHome.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "number of goals";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(531, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "BetPoints";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(588, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 48);
            this.button2.TabIndex = 11;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(345, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 48);
            this.button3.TabIndex = 12;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // numberOfGoalsAway
            // 
            this.numberOfGoalsAway.Location = new System.Drawing.Point(394, 433);
            this.numberOfGoalsAway.Name = "numberOfGoalsAway";
            this.numberOfGoalsAway.Size = new System.Drawing.Size(107, 22);
            this.numberOfGoalsAway.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Away:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(342, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Home:";
            // 
            // game_id
            // 
            this.game_id.Location = new System.Drawing.Point(594, 374);
            this.game_id.Name = "game_id";
            this.game_id.Size = new System.Drawing.Size(60, 22);
            this.game_id.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(596, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Game id";
            // 
            // btnPayOut
            // 
            this.btnPayOut.Location = new System.Drawing.Point(456, 12);
            this.btnPayOut.Name = "btnPayOut";
            this.btnPayOut.Size = new System.Drawing.Size(82, 48);
            this.btnPayOut.TabIndex = 18;
            this.btnPayOut.Text = "Pay out";
            this.btnPayOut.UseVisualStyleBackColor = true;
            this.btnPayOut.Click += new System.EventHandler(this.btnPayOut_Click);
            // 
            // listViewGamesId
            // 
            this.listViewGamesId.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewGamesId.FullRowSelect = true;
            listViewGroup3.Header = "ListViewGroup";
            listViewGroup3.Name = "listViewGroup2";
            listViewGroup4.Header = "Team";
            listViewGroup4.Name = "listViewGroup1";
            this.listViewGamesId.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3,
            listViewGroup4});
            this.listViewGamesId.Location = new System.Drawing.Point(7, 12);
            this.listViewGamesId.Name = "listViewGamesId";
            this.listViewGamesId.Size = new System.Drawing.Size(82, 441);
            this.listViewGamesId.TabIndex = 10;
            this.listViewGamesId.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Home";
            // 
            // bet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 467);
            this.Controls.Add(this.listViewGamesId);
            this.Controls.Add(this.btnPayOut);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.game_id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numberOfGoalsAway);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numberOfGoalsHome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listviewBetGames);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bet";
            this.Text = "bet";
            this.Load += new System.EventHandler(this.bet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListView listviewBetGames;
        private System.Windows.Forms.ColumnHeader Home;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox numberOfGoalsHome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox numberOfGoalsAway;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox game_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPayOut;
        private System.Windows.Forms.ListView listViewGamesId;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Data.SqlClient;
using System.IO;

namespace ProjectFifaV2
{
    public partial class frmPlayer : Form
    {
        private Form frmRanking;
        private DatabaseHandler dbh;
        private string userName;
        private ComboBox tableSelector;
        private TextBox txtPath;
        private Form frmGames;
        private TextBox txtHomePred;
        private TextBox txtAwayPred;
        List<TextBox> txtBoxList;

        public frmPlayer(Form frm, string un)
        {
            this.ControlBox = false;
            frmRanking = frm;
            frmGames = new frmGames();
            dbh = new DatabaseHandler();


            InitializeComponent();
            if (DisableEditButton())
            {
                btnEditPrediction.Enabled = false;
            }
            ShowResults();
            ShowScoreCard();
            this.Text = "Welcome " + un;

            userName = un;
   
        }
       
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnShowRanking_Click(object sender, EventArgs e)
        {
            frmRanking.Show();
        }

        private void btnClearPrediction_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to clear your prediction?", "Clear Predictions", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                // Clear predections
                // Update DB
                dbh.OpenConnectionToDB();
                int Id;
                using (SqlCommand cmd = new SqlCommand("SELECT Id FROM TblUsers WHERE Username = @username", dbh.GetCon()))
                {
                    cmd.Parameters.AddWithValue("username", userName);
                    Id = (int)cmd.ExecuteScalar();
                }

                using (SqlCommand cmd = new SqlCommand("DELETE * FROM TblPredictions WHERE User_id = @id"))
                {
                    cmd.Parameters.AddWithValue("id", Id);
                }
            }
        }

        private bool DisableEditButton()
        {
            bool hasPassed;
            //This is the deadline for filling in the predictions
            DateTime deadline = new DateTime(2017, 06, 12);
            DateTime curTime = DateTime.Now;
            int result = DateTime.Compare(deadline, curTime);

            if (result < 0)
            {
                hasPassed = true;
            }
            else
            {
                hasPassed = false;
            }

            return hasPassed;
        }

        private void ShowResults()
        { 
            dbh.TestConnection();
            dbh.OpenConnectionToDB();
              
            DataTable hometable = dbh.FillDT("SELECT tblTeams.TeamName, tblGames.HomeTeamScore FROM tblGames INNER JOIN tblTeams ON tblGames.HomeTeam = tblTeams.Team_ID");
            DataTable awayTable = dbh.FillDT("SELECT tblTeams.TeamName, tblGames.AwayTeamScore FROM tblGames INNER JOIN tblTeams ON tblGames.AwayTeam = tblTeams.Team_ID");

            dbh.CloseConnectionToDB();

            for (int i = 0; i < hometable.Rows.Count; i++)
            {
                DataRow dataRowHome = hometable.Rows[i];
                DataRow dataRowAway = awayTable.Rows[i];
                ListViewItem lstItem = new ListViewItem(dataRowHome["TeamName"].ToString());
                lstItem.SubItems.Add(dataRowHome["HomeTeamScore"].ToString());
                lstItem.SubItems.Add(dataRowAway["AwayTeamScore"].ToString());
                lstItem.SubItems.Add(dataRowAway["TeamName"].ToString());
                lvOverview.Items.Add(lstItem);
            }
        }

        private void ShowScoreCard()
        {
            dbh.TestConnection();
            dbh.OpenConnectionToDB();

            DataTable hometable = dbh.FillDT("SELECT tblTeams.TeamName FROM tblGames INNER JOIN tblTeams ON tblGames.HomeTeam = tblTeams.Team_ID");
            DataTable awayTable = dbh.FillDT("SELECT tblTeams.TeamName FROM tblGames INNER JOIN tblTeams ON tblGames.AwayTeam = tblTeams.Team_ID");
            //DataTable Teamname = dbh.FillDT("DELETE tblTeams.TeamName, Team_id ");
            dbh.CloseConnectionToDB();

            for (int i = 0; i < hometable.Rows.Count; i++)
            {
                
                DataRow dataRowHome = hometable.Rows[i];
                DataRow dataRowAway = awayTable.Rows[i];
               
                Label lblHomeTeam = new Label();
                Label lblAwayTeam = new Label();
                TextBox txtHomePred = new TextBox();
                TextBox txtAwayPred = new TextBox();
                this.txtHomePred = txtHomePred;
                this.txtAwayPred = txtAwayPred;
                lblHomeTeam.TextAlign = ContentAlignment.BottomRight;
                lblHomeTeam.Text = dataRowHome["TeamName"].ToString();
                lblHomeTeam.Location = new Point(15, txtHomePred.Bottom + (i * 30));
                lblHomeTeam.AutoSize = true;

                txtHomePred.Text = null;
                txtHomePred.Location = new Point(lblHomeTeam.Width, lblHomeTeam.Top - 3);
                txtHomePred.Width = 60;

                txtAwayPred.Text = null;
                txtAwayPred.Location = new Point(txtHomePred.Width + lblHomeTeam.Width, txtHomePred.Top);
                txtAwayPred.Width = 60;

                lblAwayTeam.Text = dataRowAway["TeamName"].ToString();
                lblAwayTeam.Location = new Point(txtHomePred.Width + lblHomeTeam.Width + txtAwayPred.Width, txtHomePred.Top + 3);
                lblAwayTeam.AutoSize = true;

                pnlPredCard.Controls.Add(lblHomeTeam);
                pnlPredCard.Controls.Add(txtHomePred);
                pnlPredCard.Controls.Add(txtAwayPred);
                pnlPredCard.Controls.Add(lblAwayTeam);
                //ListViewItem lstItem = new ListViewItem(dataRowHome["TeamName"].ToString());
                //lstItem.SubItems.Add(dataRowHome["HomeTeamScore"].ToString());
                //lstItem.SubItems.Add(dataRowAway["AwayTeamScore"].ToString());
                //lstItem.SubItems.Add(dataRowAway["TeamName"].ToString());
                //lvOverview.Items.Add(lstItem);
            }
        }

        internal void GetUsername(string un)
        {
            
            userName = un;
        }

        private void btnEditPrediction_Click(object sender, EventArgs e)
        {
            //btnEditPrediction.Enabled = false;
            //ShowScoreCard();
            //ShowResults();
            GetUsername(userName);
            InsertPredictions(userName);
        }

        private void InsertPredictions(string un)
        {
            
            int Id;

            dbh.OpenConnectionToDB();
            using (SqlCommand cmd = new SqlCommand("SELECT Id FROM [TblUsers] WHERE Username = @Username", dbh.GetCon()))
            {
                cmd.Parameters.AddWithValue("Username", userName);
                Id = (int)cmd.ExecuteScalar();
            }
            DataTable gamesIds = dbh.FillDT("SELECT Game_id FROM tblGames");

            for (int i = 0; i < gamesIds.Rows.Count; i++)
            {
                DataRow dataRowIds = gamesIds.Rows[i];

                if (txtHomePred.Text == "" && txtAwayPred.Text == "")
                {
                    btnEditPrediction.Enabled = false;
                    MessageHandler.ShowMessage("you have to insert your prediction!");
                }
                else if (txtHomePred.Text == "")
                {
                    MessageHandler.ShowMessage("you have to insert the amount of goals scored by the home team.");
                }
                else if (txtAwayPred.Text == "")
                {
                    MessageHandler.ShowMessage("you have to insert the amount of goals scored by the away team");
                }
                else if (txtHomePred.Text != "" && txtAwayPred.Text != "")
                {
                    string predictedHomeScore;
                    string predictedAwayScore;
                    int gameId;
                    predictedHomeScore = this.txtHomePred.Text;
                    predictedAwayScore = this.txtAwayPred.Text;
                    gameId = Convert.ToInt32(dataRowIds[0]);

                    dbh.TestConnection();
                    dbh.OpenConnectionToDB();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO tblPredictions ( User_id ,Game_id, PredictedHomeScore, PredictedAwayScore) VALUES ( @id, @gameId, @PredHomeScore, @predAwayScore)"))
                    {
                        cmd.Parameters.AddWithValue("id", Id);
                        cmd.Parameters.AddWithValue("gameId", gameId);
                        cmd.Parameters.AddWithValue("PredHomeScore", predictedHomeScore);
                        cmd.Parameters.AddWithValue("PredAwayScore", predictedAwayScore);
                        cmd.Connection = dbh.GetCon();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
        private void lvOverview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnlPredCard_Paint(object sender, PaintEventArgs e)
        {
               
        }

        private void PayOut(string un)
        {
            dbh.TestConnection();
            dbh.OpenConnectionToDB();
            int Id;
            int score;
            using (SqlCommand cmd = new SqlCommand("SELECT Id FROM [TblUsers] WHERE Username = @Username", dbh.GetCon()))
            {
                cmd.Parameters.AddWithValue("@Username", userName);
                Id = (int)cmd.ExecuteScalar();
            }
            

            using (SqlCommand cmd = new SqlCommand("SELECT Score FROM [TblUsers] WHERE Id = @id ", dbh.GetCon()))
            {
                cmd.Parameters.AddWithValue("@id", Id);
                score = (int)cmd.ExecuteScalar();

            }
            int predictedHomeScore;
            int predictedAwayScore;
            int gameId;

            using (SqlCommand cmd = new SqlCommand("SELECT PredictedHomeScore FROM [TblPredictions] WHERE  User_id = @Id ", dbh.GetCon()))
            {
                cmd.Parameters.AddWithValue("@Id", Id);
                predictedHomeScore = (int)cmd.ExecuteScalar();
            }

            using (SqlCommand cmd = new SqlCommand("SELECT PredictedAwayScore FROM [TblPredictions] WHERE  User_id = @Id", dbh.GetCon()))
            {
                cmd.Parameters.AddWithValue("@Id", Id);
                predictedAwayScore = (int)cmd.ExecuteScalar();
            }

            using (SqlCommand cmd = new SqlCommand("SELECT Game_id FROM [tblPredictions] WHERE  User_id = @Id", dbh.GetCon()))
            {
                cmd.Parameters.AddWithValue("@Id", Id);
                gameId = (int)cmd.ExecuteScalar();
            }

            int homeTeamScore;
            int awayTeamScore;

            using (SqlCommand cmd = new SqlCommand("SELECT HomeTeamScore FROM [tblGames] WHERE Game_id = @gameId", dbh.GetCon()))
            {
                cmd.Parameters.AddWithValue("@gameId", gameId);
                homeTeamScore = (int)cmd.ExecuteScalar();
            }

            using (SqlCommand cmd = new SqlCommand("SELECT AwayTeamScore FROM [tblGames] WHERE Game_id = @gameId", dbh.GetCon()))
            {
                cmd.Parameters.AddWithValue("@gameId", gameId);
                awayTeamScore = (int)cmd.ExecuteScalar();
            }
            bool homeTeamHaveWon = false;
            bool awayTeamHaveWon = false;
            bool isItEven = false;
            if (homeTeamScore > awayTeamScore)
            {
                homeTeamHaveWon = true;
            }
            else if (awayTeamScore > homeTeamScore)
            {
                awayTeamHaveWon = true;
            }
            else
            {
                isItEven = true;
            }
            


            bool homeTeamWon = false;
            bool awayTeamWon = false;
            bool betItsEven = false;
            if (predictedHomeScore > predictedAwayScore)
            {
                // nu weet ik dus dat hij denkt dat de home team gaat winnen
                homeTeamWon = true;
            }
            else if (predictedHomeScore < predictedAwayScore)
            {
                // en hier het uit team
                awayTeamWon = true;
            }
            else
            {
                betItsEven = true;
            }


            if (homeTeamHaveWon && homeTeamWon && homeTeamScore == predictedHomeScore && awayTeamScore == predictedAwayScore)
            {
                score += 3;
                using (SqlCommand cmd = new SqlCommand("UPDATE TblUsers SET score = @score WHERE Id = @id"))
                {
                    cmd.Parameters.AddWithValue("score", score);
                    cmd.Parameters.AddWithValue("Id", Id);
                    cmd.Connection = dbh.GetCon();
                    cmd.ExecuteNonQuery();
                }
                MessageHandler.ShowMessage("you won, you have guessed that the home team won and the endscore is correct");

                using (SqlCommand cmd = new SqlCommand("DELETE FROM TblPredictions WHERE User_id = @id AND Game_id = @game_id"))
                {
                    cmd.Parameters.AddWithValue("id", Id);
                    cmd.Parameters.AddWithValue("game_id", gameId);
                    cmd.Connection = dbh.GetCon();
                    cmd.ExecuteNonQuery();
                }
            }

            else if (awayTeamHaveWon && awayTeamWon && homeTeamScore == predictedHomeScore && awayTeamScore == predictedAwayScore)
            {
                score += 3;
                using (SqlCommand cmd = new SqlCommand("UPDATE TblUsers SET score = @score WHERE Id = @id"))
                {
                    cmd.Parameters.AddWithValue("score", score);
                    cmd.Parameters.AddWithValue("Id", Id);
                    cmd.Connection = dbh.GetCon();
                    cmd.ExecuteNonQuery();
                }
                MessageHandler.ShowMessage("you won, you have guessed that the home team won and the endscore is correct");

                using (SqlCommand cmd = new SqlCommand("DELETE FROM TblPredictions WHERE User_id = @id AND Game_id = @game_id"))
                {
                    cmd.Parameters.AddWithValue("id", Id);
                    cmd.Parameters.AddWithValue("game_id", gameId);
                    cmd.Connection = dbh.GetCon();
                    cmd.ExecuteNonQuery();
                }
            }

            else if (homeTeamHaveWon && homeTeamWon)
                {
                    score += 1;

                    using (SqlCommand cmd = new SqlCommand("UPDATE TblUsers SET score = @score WHERE Id = @id"))
                    {
                        cmd.Parameters.AddWithValue("score", score);
                        cmd.Parameters.AddWithValue("Id", Id);
                        cmd.Connection = dbh.GetCon();
                        cmd.ExecuteNonQuery();
                    }
                    MessageHandler.ShowMessage("you won, you have guessed that the home team would win and thats correct");


                    using (SqlCommand cmd = new SqlCommand("DELETE FROM TblPredictions WHERE User_id = @id AND Game_id = @game_id"))
                    {
                        cmd.Parameters.AddWithValue("id", Id);
                        cmd.Parameters.AddWithValue("game_id", gameId);
                        cmd.Connection = dbh.GetCon();
                        cmd.ExecuteNonQuery();
                    }

                }
            
            else if (awayTeamHaveWon && awayTeamWon)
            {
                score += 1;
                using (SqlCommand cmd = new SqlCommand("UPDATE TblUsers SET score = @score WHERE Id = @id"))
                {
                    cmd.Parameters.AddWithValue("score", score);
                    cmd.Parameters.AddWithValue("Id", Id);
                    cmd.Connection = dbh.GetCon();
                    cmd.ExecuteNonQuery();
                }
                MessageHandler.ShowMessage("you won, you have guessed that the away team would win and thats correct");

                using (SqlCommand cmd = new SqlCommand("DELETE FROM TblPredictions WHERE User_id = @id AND Game_id = @game_id"))
                {
                    cmd.Parameters.AddWithValue("id", Id);
                    cmd.Parameters.AddWithValue("game_id", gameId);
                    cmd.Connection = dbh.GetCon();
                    cmd.ExecuteNonQuery();
                }

            }
            
            else
            {
                MessageHandler.ShowMessage("you did not win.");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGames.Show();
        }

        private void btnPayOut_Click(object sender, EventArgs e)
        {
            PayOut(userName);
        }
    }
}
            
        
    


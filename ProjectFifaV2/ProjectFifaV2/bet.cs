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

namespace ProjectFifaV2
{
    public partial class bet : Form
    {
        private DatabaseHandler dbh;
        private string userName;


        public bet()
        {
            InitializeComponent();
            dbh = new DatabaseHandler();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Gebruiker\Documents\GitHub\project_fifa\mysite_downloads\ProjectFifaV2\Sounds\Chaching.wav");
            //simpleSound.Play();
            insertPredictions(userName);
        }

        private void insertPredictions(string un)
        {
            int numberOfGoalsHome = Convert.ToInt32(this.numberOfGoalsHome.Text);
            int numberOfGoalsAway = Convert.ToInt32(this.numberOfGoalsAway.Text);

            dbh.TestConnection();
            dbh.OpenConnectionToDB();

            int Id;
            using (SqlCommand cmd = new SqlCommand("SELECT Id FROM [TblUsers] WHERE Username = @Username", dbh.GetCon()))
            {
                cmd.Parameters.AddWithValue("@Username", un);

                Id = (int)cmd.ExecuteScalar();
            }
            int Points;
            using (SqlCommand cmd = new SqlCommand("SELECT Points FROM [TblUsers] WHERE Id = @Id", dbh.GetCon()))
            {
                cmd.Parameters.AddWithValue("Id", Id);
                Points = (int)cmd.ExecuteScalar();
            }

            int Game_id = Convert.ToInt32(game_id.Text);
            using (SqlCommand cmd = new SqlCommand("INSERT INTO TblPredictions ( User_id, Game_id, PredictedHomeScore, PredictedAwayScore) VALUES (@user_id, @Game_id, @PredictedHomeScore, @PredictedAwayScore)"))
            {

                cmd.Parameters.AddWithValue("@user_id", Id);
                cmd.Parameters.AddWithValue("@Game_id", Game_id);
                cmd.Parameters.AddWithValue("PredictedHomeScore", numberOfGoalsHome);
                cmd.Parameters.AddWithValue("PredictedAwayScore", numberOfGoalsAway);
                cmd.Connection = dbh.GetCon();
                cmd.ExecuteNonQuery();
            }
            dbh.CloseConnectionToDB();
        }


        private void bet_Load(object sender, EventArgs e)
        {
            DataTable idRow = dbh.FillDT("SELECT Game_id FROM tblGames");
            DataTable hometable = dbh.FillDT("SELECT  tblTeams.TeamName FROM tblGames INNER JOIN tblTeams ON tblGames.HomeTeam = tblTeams.Team_ID");
            DataTable awayTable = dbh.FillDT("SELECT  tblTeams.TeamName FROM tblGames INNER JOIN tblTeams ON tblGames.AwayTeam = tblTeams.Team_ID");

            dbh.CloseConnectionToDB();
            dbh.TestConnection();
            dbh.OpenConnectionToDB();
            for (int i = 0; i < idRow.Rows.Count; i++)
            {
                DataRow dataRowId = idRow.Rows[i];
                ListViewItem lstItem = new ListViewItem(dataRowId["Game_id"].ToString());
                listViewGamesId.Items.Add(lstItem);
            }

            for (int i = 0; i < hometable.Rows.Count; i++)
            {
                
                DataRow dataRowHome = hometable.Rows[i];
                DataRow dataRowAway = awayTable.Rows[i];
                ListViewItem lstItem = new ListViewItem(dataRowHome["TeamName"].ToString());
                lstItem.SubItems.Add(dataRowAway["TeamName"].ToString());
                listviewBetGames.Items.Add(lstItem);
            }
            int Id;

            using (SqlCommand cmd = new SqlCommand("SELECT Id FROM [TblUsers] WHERE Username = @Username", dbh.GetCon()))
            {
                cmd.Parameters.AddWithValue("@Username", userName);
                Id = (int)cmd.ExecuteScalar();
            }
           

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        internal void SetUsername(string un)
        {
            userName = un;
        }
        private void PayOut(string un)
        {
            dbh.TestConnection();
            dbh.OpenConnectionToDB();
            int Id;
            int score;
            using (SqlCommand cmd = new SqlCommand("SELECT Id FROM [TblUsers] WHERE Username = @Username", dbh.GetCon()))
            {
                cmd.Parameters.AddWithValue("@Username", un);
                Id = (int)cmd.ExecuteScalar();
            }

            int UserIdPredictions;
            using (SqlCommand cmd = new SqlCommand("SELECT User_id FROM TblPredictions", dbh.GetCon()))
            {
                UserIdPredictions = (int)cmd.ExecuteScalar();
            }

            for (int i = 0; i < 5; i++)
            {
                if (UserIdPredictions != Id)
                {
                    btnPayOut.Enabled = false;
                }
            }

            using (SqlCommand cmd = new SqlCommand("SELECT Score FROM [TblUsers] WHERE Username = @Username", dbh.GetCon()))
            {
                cmd.Parameters.AddWithValue("@Username", un);
                score = (int)cmd.ExecuteScalar();

            }
            int predictedHomeScore;
            int predictedAwayScore;
            int gameId;
            
            using (SqlCommand cmd = new SqlCommand("SELECT PredictedHomeScore FROM [TblPredictions] WHERE  User_id = @Id", dbh.GetCon()))
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
            int teamWon;
            if (homeTeamScore > awayTeamScore)
            {
                teamWon = 1;
            }
            else if (awayTeamScore > homeTeamScore)
            {
                teamWon = 2;
            }
            else
            {
                teamWon = 3;
            }

            string homeTeamWon = null;
            int homeTeamWin;
            int awayTeamWon;

            if (predictedHomeScore > predictedAwayScore)
            {
                // nu weet ik dus dat hij denkt dat de home team gaat winnen
               homeTeamWin = 1;
            }
            else if (predictedHomeScore > predictedAwayScore)
            {
                // en hier het uit team
                awayTeamWon = 2;
            }
            bool isCorrect = false;
            if (homeTeamScore == predictedHomeScore && awayTeamScore == predictedAwayScore)
            {
                score += 1;
                isCorrect = true;
                using (SqlCommand cmd = new SqlCommand("UPDATE TblUsers SET score = @score WHERE Id = @id"))
                {
                    cmd.Parameters.AddWithValue("score",score);
                    cmd.Parameters.AddWithValue("Id", Id);
                    cmd.Connection = dbh.GetCon();
                    cmd.ExecuteNonQuery();
                }

                using (SqlCommand cmd = new SqlCommand("DELETE FROM TblPredictions WHERE User_id = @id"))
                {
                    cmd.Parameters.AddWithValue("id", Id);
                    cmd.Connection = dbh.GetCon();
                    cmd.ExecuteNonQuery();
                }
                 
            }
            else
            {
                MessageHandler.ShowMessage("you did not win.");
            }

            //if (isCorrect && teamWon ==  homeTeamWin)
            //{
            //    score += 3; 
            //}
            
        }

        private void btnPayOut_Click(object sender, EventArgs e)
        {
            PayOut(userName);
            bet_Load(sender, e);
        }
    }
}

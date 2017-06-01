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
        
            //using (SqlCommand cmd = new SqlCommand("SELECT Id FROM TblUsers WHERE Username = @username", dbh.GetCon()))
            //{
            //    cmd.Parameters.AddWithValue("@username", userName);
            //    int userId = (int)cmd.ExecuteScalar();
            //    return userId;
            //}
            
        
        
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
            int numberOfPoints = Convert.ToInt32(betAmount.Value);
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
            int remainingPoints = Points - numberOfPoints;
            using (SqlCommand cmd = new SqlCommand("UPDATE TblUsers SET Points = @points WHERE Username = @username"))
            {
                cmd.Parameters.AddWithValue("username", userName);
                cmd.Parameters.AddWithValue("points", remainingPoints);
                cmd.Connection = dbh.GetCon();
                cmd.ExecuteNonQuery();
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
            int Id;
            using (SqlCommand cmd = new SqlCommand("SELECT Id FROM [TblUsers] WHERE Username = @Username", dbh.GetCon()))
            {
                cmd.Parameters.AddWithValue("@Username", un);

                Id = (int)cmd.ExecuteScalar();
            }
            int predictedHomeScore;
            int predictedAwayScore;
            using (SqlCommand cmd = new SqlCommand("SELECT PredictedHomeScore FROM [tblPredictions] WHERE  UserId = @Id", dbh.GetCon()))
            {
                cmd.Parameters.AddWithValue("@Id", Id);
                predictedHomeScore = (int)cmd.ExecuteScalar();
            }

            using (SqlCommand cmd = new SqlCommand("SELECT PredictedAwayScore FROM [tblPredictions] WHERE  UserId = @Id", dbh.GetCon()))
            {
                cmd.Parameters.AddWithValue("@Id", Id);
                predictedAwayScore = (int)cmd.ExecuteScalar();
            }
            int homeTeamWon;
            int awayTeamWon;
            if (predictedHomeScore > predictedAwayScore)
            {
                homeTeamWon++;
            }

        }

        private void btnPayOut_Click(object sender, EventArgs e)
        {
            PayOut(userName);
        }
    }
}

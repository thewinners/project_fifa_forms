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
            int numberOfGoalsHome = Convert.ToInt32(this.numberOfGoalsHome.Text);
            int numberOfGoalsAway = Convert.ToInt32(this.numberOfGoalsAway.Text);
            int numberOfPoints = Convert.ToInt32(betAmount.Value);
            dbh.TestConnection();
            dbh.OpenConnectionToDB();

            DataTable table = dbh.FillDT("SELECT Id FROM TblUsers WHERE Username = @userName");
            DataTable tableGame = dbh.FillDT("SELECT Game_id FROM TblGames");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow dataRow = table.Rows[0];
                DataRow dataRowGames = tableGame.Rows[0];
                int id = Convert.ToInt32(dataRow["Id"]);
                int Game_id = Convert.ToInt32(dataRowGames["Game_id"]);


                dbh.CloseConnectionToDB();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO TblPredictions ( User_id, Game_id, PredictedHomeScore, PredictedAwayScore) VALUES (@user_id, @Game_id, @PredictedHomeScore, @PredictedAwayScore)"))
                {
                    cmd.Parameters.AddWithValue("@user_id", id);
                    cmd.Parameters.AddWithValue("@Game_id", Game_id);
                    cmd.Parameters.AddWithValue("PredictedHomeScore", numberOfGoalsHome);
                    cmd.Parameters.AddWithValue("PredictedAwayScore", numberOfGoalsAway);

                }
            }
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
        internal void GetUsername(string un)
        {
            userName = un;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace ProjectFifaV2
{
    public partial class frmAdmin : Form
    {
        private DatabaseHandler dbh;
        private OpenFileDialog opfd;

        DataTable table;

        public frmAdmin()
        {
            dbh = new DatabaseHandler();
            table = new DataTable();
            this.ControlBox = false;
            InitializeComponent();
        }

        private void btnAdminLogOut_Click(object sender, EventArgs e)
        {
            txtQuery.Text = null;
            txtPath = null;
            dgvAdminData.DataSource = null;
            Hide();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (txtQuery.TextLength > 0)
            {
                ExecuteSQL(txtQuery.Text);
            }
        }

        private void ExecuteSQL(string selectCommandText)
        {
            dbh.TestConnection();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommandText, dbh.GetCon());
            dataAdapter.Fill(table);
            dgvAdminData.DataSource = table;
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            txtPath.Text = null;
            
            string path = GetFilePath();

            if (CheckExtension(path, "csv"))
            {
                txtPath.Text = path;
            }
            else
            {
                MessageHandler.ShowMessage("The wrong filetype is selected.");
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            if (!(txtPath.Text == null))
            {
                dbh.OpenConnectionToDB();
                StreamReader sr = new StreamReader(txtPath.Text);

                if (tableSelector.Text == "")
                {
                    MessageHandler.ShowMessage("you have to select an table.");
                }
                else if (tableSelector.Text == "matches")
                {
                    string data = sr.ReadLine();

                    while (data != null)
                    {
                        string[] value = data.Split(',');

                        int homeTeam = Convert.ToInt32(value[1]);
                        int awayTeam = Convert.ToInt32(value[2]);
                        int scoreHome = Convert.ToInt32(value[3]);
                        int scoreAway = Convert.ToInt32(value[4]);

                        data = sr.ReadLine();

                        using (SqlCommand cmd = new SqlCommand("INSERT INTO TblGames ( HomeTeam, AwayTeam, HomeTeamScore, AwayTeamScore) VALUES (@homeTeam, @awayTeam, @scoreHome, @scoreAway)"))
                        {
                            cmd.Parameters.AddWithValue("@homeTeam", homeTeam);
                            cmd.Parameters.AddWithValue("@awayTeam", awayTeam);
                            cmd.Parameters.AddWithValue("@scoreHome", scoreHome);
                            cmd.Parameters.AddWithValue("@scoreAway", scoreAway);
                            cmd.Connection = dbh.GetCon();
                            cmd.ExecuteNonQuery();

                            MessageHandler.ShowMessage("data insert has been succeeded");
                            dbh.CloseConnectionToDB();
                        }
                    }
                }


                else if (tableSelector.Text == "players")
                {
                    string data = sr.ReadLine();

                    while (data != null)
                    {
                        string[] value = data.Split(',');
                        int id = Convert.ToInt32(value[0]);
                        string name = value[3];
                        string newName = name.Trim('"');
                        string surname = value[4];
                        string newSurname = surname.Trim('"');
                        int goalScored = Convert.ToInt32(value[5]);
                        int team_id = Convert.ToInt32(value[2]);
                        data = sr.ReadLine();



                        using (SqlCommand cmd = new SqlCommand("INSERT INTO TblPlayers (Name, Surname, GoalsScored, Team_id) VALUES (@name, @surname, @goalScored, @Team_id)"))
                        {
                            cmd.Parameters.AddWithValue("@name", newName);
                            cmd.Parameters.AddWithValue("@surname", newSurname);
                            cmd.Parameters.AddWithValue("@goalScored", goalScored);
                            cmd.Parameters.AddWithValue("@Team_id", team_id);
                            cmd.Connection = dbh.GetCon();
                            cmd.ExecuteNonQuery();

                            MessageHandler.ShowMessage("data insert has been succeeded");
                            dbh.CloseConnectionToDB();
                        }

                    }
                }

                else if (tableSelector.Text == "teams")
                {
                    string data = sr.ReadLine();

                    while (data != null)
                    {
                        string[] value = data.Split(',');
                        int Teamid = Convert.ToInt32(value[0]);
                        string TeamName = value[2];
                        data = sr.ReadLine();

                        using (SqlCommand cmd = new SqlCommand("SELECT Team_id FROM TblTeams"))
                        {
                            SqlDataReader dr = cmd.ExecuteReader();
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    string checkId = dr.ToString();
                                    int checkTeamId = Convert.ToInt32(checkId);
                                    if (checkTeamId == Teamid)
                                    {
                                        MessageHandler.ShowMessage("there is already an team with that team id");
                                    }
                                    else if(checkTeamId != Teamid)
                                    {
                                        cmd.Parameters.AddWithValue("@Teamid", Teamid);
                                        cmd.Parameters.AddWithValue("@teamName", TeamName);
                                        cmd.Connection = dbh.GetCon();
                                        cmd.ExecuteNonQuery();

                                        MessageHandler.ShowMessage("data insert has been succeeded");
                                        dbh.CloseConnectionToDB();
                                        
                                    }
                                }
                            }
                        }

                        
                    }
                }
                else
                {
                    MessageHandler.ShowMessage("No filename selected.");
                    dbh.CloseConnectionToDB();
                }
                    
            }
        }
        
        private string GetFilePath()
        {
            string filePath = "";
            opfd = new OpenFileDialog();

            opfd.Multiselect = false;

            if (opfd.ShowDialog() == DialogResult.OK)
            {
                filePath = opfd.FileName;
            }

            return filePath;
        }

        private bool CheckExtension(string fileString, string extension)
        {
            int extensionLength = extension.Length;
            int strLength = fileString.Length;

            string ext = fileString.Substring(strLength - extensionLength, extensionLength);

            if (ext == extension)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Media;

namespace ProjectFifaV2
{
    public partial class frmLogin : Form
    {
        private DatabaseHandler dbh;
        private Form frmAdmin;
        private Form frmPlayer;
        private Form frmRanking;
        private bet frmBet;

        public frmLogin()
        {
            InitializeComponent();
            dbh = new DatabaseHandler();
            frmAdmin = new frmAdmin();
            frmRanking = new frmRanking();
            frmBet = new bet();
            //frmPlayer = new frmPlayer(frmRanking);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Gebruiker\Documents\GitHub\project_fifa\mysite_downloads\ProjectFifaV2\Sounds\button_click.wav");
            //simpleSound.Play();
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Both fields are required");
            }
            else
            {
                dbh.TestConnection();
                dbh.OpenConnectionToDB();
                bool exist = false;

                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [tblUsers] WHERE Username = @Username", dbh.GetCon()))
                {
                    cmd.Parameters.AddWithValue("Username", txtUsername.Text);
                    exist = (int)cmd.ExecuteScalar() > 0;
                }

                if (exist)
                {
                    MessageHandler.ShowMessage("This user already exists.");
                }
                else
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO [tblUsers] ([Username], [Password], [IsAdmin],[Score], [Points]) VALUES (@Username, @Password, @IsAdmin, @score, @points)"))
                    {
                        cmd.Parameters.AddWithValue("Username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("Password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("IsAdmin", 0);
                        cmd.Parameters.AddWithValue("score", 0);
                        cmd.Parameters.AddWithValue("Points", 50);
                        cmd.Connection = dbh.GetCon();
                        cmd.ExecuteNonQuery();
                    }

                    string username = txtUsername.Text;
                    string password = txtPassword.Text;

                    txtUsername.Text = "";
                    txtPassword.Text = "";

                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [tblUsers] WHERE Username = @Username AND Password = @Password", dbh.GetCon()))
                    {
                        cmd.Parameters.AddWithValue("Username", username);
                        cmd.Parameters.AddWithValue("Password", password);
                        exist = (int)cmd.ExecuteScalar() > 0;
                    }

                    if (exist)
                    {
                        bool admin;
                        using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) from [tblUsers] WHERE Username = @Username AND IsAdmin = 1", dbh.GetCon()))
                        {
                            cmd.Parameters.AddWithValue("Username", username);
                            admin = (int)cmd.ExecuteScalar() > 0;
                        }
                        dbh.CloseConnectionToDB();

                        if (admin)
                        {
                            frmAdmin.Show();
                        }
                        else
                        {
                            frmPlayer = new frmPlayer(frmRanking, username);
                            frmPlayer.Show();
                            //frmPlayer.Show();
                        }
                    }
                    else
                    {
                        dbh.CloseConnectionToDB();
                        MessageHandler.ShowMessage("Wrong username and/or password.");
                    }
                }

                dbh.CloseConnectionToDB();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Gebruiker\Documents\GitHub\project_fifa\mysite_downloads\ProjectFifaV2\Sounds\button_click.wav");
            simpleSound.Play();
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                if (dbh.GetCon().State == ConnectionState.Open)
                {
                    dbh.CloseConnectionToDB();
                }
                Application.Exit();
            }
        }

        private void btnShowRanking_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Gebruiker\Documents\GitHub\project_fifa\mysite_downloads\ProjectFifaV2\Sounds\button_click.wav");
            simpleSound.Play();
            frmRanking.Show(); 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Gebruiker\Documents\GitHub\project_fifa\mysite_downloads\ProjectFifaV2\Sounds\button_click.wav");
            //simpleSound.Play();
            dbh.TestConnection();
            dbh.OpenConnectionToDB();

            bool exist = false;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            txtUsername.Text = "";
            txtPassword.Text = "";

            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [tblUsers] WHERE Username = @Username AND Password = @Password", dbh.GetCon()))
            {

                cmd.Parameters.AddWithValue("Username", username);
                cmd.Parameters.AddWithValue("Password", password);
                exist = (int)cmd.ExecuteScalar() > 0;
            }           

            if (exist)
            {
                bool admin;
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) from [tblUsers] WHERE Username = @Username AND IsAdmin = 1", dbh.GetCon()))
                {
                    cmd.Parameters.AddWithValue("Username", username);
                    admin = (int)cmd.ExecuteScalar() > 0;
                }
                dbh.CloseConnectionToDB();

                if (admin)
                {
                    frmAdmin.Show();
                }
                else
                {
                    frmBet.SetUsername(username);
                    frmBet.Show();
                }
            }
            else
            {
                dbh.CloseConnectionToDB();
                MessageHandler.ShowMessage("Wrong username and/or password.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace ProjectFifaV2
{
    public partial class bet : Form
    {
        private Form frmRanking;
        public bet()
        {
            InitializeComponent();
            frmRanking = new frmRanking();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Gebruiker\Documents\GitHub\project_fifa_c#\project_fifa_forms\ProjectFifaV2\Sounds\Chaching.wav");
            simpleSound.Play();

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

        private void button3_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Gebruiker\Documents\GitHub\project_fifa_c#\project_fifa_forms\ProjectFifaV2\Sounds\button_click.wav");
            simpleSound.Play();
            frmRanking.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Gebruiker\Documents\GitHub\project_fifa_c#\project_fifa_forms\ProjectFifaV2\Sounds\button_back.wav");
            simpleSound.Play();
            Hide();

        }
    }
}

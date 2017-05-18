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
        public bet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Gebruiker\Documents\GitHub\project_fifa\mysite_downloads\ProjectFifaV2\Sounds\Chaching.wav");
            simpleSound.Play();

        }

        private void bet_Load(object sender, EventArgs e)
        {
            int numberOfGoalsHome = Convert.ToInt32(this.numberOfGoalsHome.Text);
            int numberOfGoalsAway = Convert.ToInt32(this.numberOfGoalsAway.Text);
            int numberOfPoints = Convert.ToInt32(betAmount.Value);
            
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
    }
}

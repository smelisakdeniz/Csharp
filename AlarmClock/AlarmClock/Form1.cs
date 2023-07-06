using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            if (label1.Text == label2.Text)
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\smeli\\Desktop\\alarm.mp3";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = maskedTextBox1.Text;
            this.Width = 330;
            this.Height = 75;
            label3.Visible = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Width = 330;
            this.Height = 122;
        }
    }
}

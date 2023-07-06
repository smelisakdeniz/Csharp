using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radyo_Uygulaması
{
    public partial class Form1 : Form
    {
        private int formKoor, formKoorX, formKoorY;
        private int panelMenuGenislik;
        private bool panelMenuGizli;
        public Form1()
        {
            InitializeComponent();
            panelMenuGenislik = panelMENU.Width;
            panelMenuGizli = false;
        }


        private void labelClose_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0); 
        }

        //mause tıkladı bırakmadığında yapılan işlem
        private void panelUst_MouseDown(object sender, MouseEventArgs e)
        {
            formKoor = 1;
            formKoorX = e.X;
            formKoorY = e.Y;
        }

        private void labelOpenClose_Click(object sender, EventArgs e)
        {
            timerMENU.Start();

        }

        private void timerMENU_Tick(object sender, EventArgs e)
        {
            if (panelMenuGizli)
            {
                panelMENU.Width = panelMENU.Width + 10;
                labelOpenClose.Text = "<";
                labelRadyolar.Text = "RADYOLAR";
                labelFAV.Text = "FAVORİLER";
                labelAYARLAR.Text = "AYARLAR";
                labelYARDIM.Text = "YARDIM";
                if (panelMENU.Width >= panelMenuGenislik)
                {
                    timerMENU.Stop();
                    panelMenuGizli = false;
                    this.Refresh();
                }

            }else
            {
                panelMENU.Width = panelMENU.Width - 10;
                labelOpenClose.Text = ">";
                labelRadyolar.Text = "";
                labelFAV.Text = "";
                labelAYARLAR.Text = "";
                labelYARDIM.Text = "?";
                if (panelMENU.Width <= 60)
                {
                    timerMENU.Stop();
                    panelMenuGizli = true;
                    this.Refresh();
                }
            }
        }

        private void labelOpenClose_MouseHover(object sender, EventArgs e)
        {
            labelOpenClose.ForeColor = Color.Yellow;
        }

        private void labelOpenClose_MouseLeave(object sender, EventArgs e)
        {
            labelOpenClose.ForeColor = Color.White;                
        }

        private void labelRadyolar_MouseHover(object sender, EventArgs e)
        {
            labelRadyolar.ForeColor = Color.Yellow;

        }

        private void labelRadyolar_MouseLeave(object sender, EventArgs e)
        {
            labelRadyolar.ForeColor = Color.White;

        }

        private void labelFAV_MouseHover(object sender, EventArgs e)
        {
            labelFAV.ForeColor = Color.Yellow;

        }

        private void labelFAV_MouseLeave(object sender, EventArgs e)
        {
            labelFAV.ForeColor = Color.White;
        }

        private void labelAYARLAR_MouseHover(object sender, EventArgs e)
        {
            labelAYARLAR.ForeColor = Color.Yellow;
        }

        private void labelAYARLAR_MouseLeave(object sender, EventArgs e)
        {
            labelAYARLAR.ForeColor = Color.White;
        }

    
        //mouse izleme işlemleri
        private void panelUst_MouseMove(object sender, MouseEventArgs e)
        {
           if (formKoor == 1)
            {
                this.SetDesktopLocation(MousePosition.X - formKoorX, MousePosition.Y - formKoorY);  
            }  
        }

        private void labelRadyolar_Click(object sender, EventArgs e)
        {
            panelOrta.Controls.Clear();
            panelOrta.Controls.Add(panelTumRadyolar1);
            panelTumRadyolar1.Dock = DockStyle.Fill;    
        }

        private void labelFAV_Click(object sender, EventArgs e)
        {
            panelOrta.Controls.Clear();
            panelOrta.Controls.Add(panelFavoriRadyolar1);
            panelFavoriRadyolar1.Dock = DockStyle.Fill;
        }

        private void labelAYARLAR_Click(object sender, EventArgs e)
        {
            panelOrta.Controls.Clear();
            panelOrta.Controls.Add(panelAyarlar1);
            panelAyarlar1.Dock = DockStyle.Fill;
        }

        private void panelUst_MouseUp(object sender, MouseEventArgs e)
        {
            formKoor = 0;
        }

        public void radyoCal (string adres)
        {
            axWindowsMediaPlayer.URL = adres;
            axWindowsMediaPlayer.Ctlcontrols.play();
        }
    }
}

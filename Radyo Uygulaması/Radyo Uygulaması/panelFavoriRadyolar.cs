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
    public partial class panelFavoriRadyolar : UserControl
    {
        public panelFavoriRadyolar()
        {
            InitializeComponent();
        }
        private void radyoPanelFenomen_Click(object sender, EventArgs e)
        {
            Form1 _from1 = (Form1)this.Parent;
            _from1.radyoCal("https://live.radyofenomen.com/fenomen/128/icecast.audio");

        }
        private void radyoPanelJoyFM_Click(object sender, EventArgs e)
        {
            Form1 _from1 = (Form1)this.Parent;
            _from1.radyoCal("https://playerservices.streamtheworld.com/api/livestream-redirect/JOY_FM2AAC_SC?/");

        }
    }
}

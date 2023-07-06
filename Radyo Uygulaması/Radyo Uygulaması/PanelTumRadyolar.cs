using AxWMPLib;
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
    public partial class PanelTumRadyolar : UserControl
    {
        public PanelTumRadyolar()
        {
            InitializeComponent();
        }

        private void radyoPanelBestFM_Click(object sender, EventArgs e)
        {
            Form1 _from1 = (Form1)this.Parent;
            _from1.radyoCal("https://babaradyo.turkhosted.com/best/bestfm.stream/playlist.m3u8");
        
        }

        private void radyoPanelFenomen_Click(object sender, EventArgs e)
        {
            Form1 _from1 = (Form1)this.Parent;
            _from1.radyoCal("https://live.radyofenomen.com/fenomen/128/icecast.audio");
            
        }

        private void radyoPanelBorusan_Click(object sender, EventArgs e)
        {
            Form1 _from1 = (Form1)this.Parent;
            _from1.radyoCal("https://babaradyo.turkhosted.com/best/bestfm.stream/playlist.m3u8");
            
        }

        private void radyoPanelJoyFM_Click(object sender, EventArgs e)
        {
            Form1 _from1 = (Form1)this.Parent;
            _from1.radyoCal("https://playerservices.streamtheworld.com/api/livestream-redirect/JOY_FM2AAC_SC?/");
            
        }

        private void radyoPanelGencFM_Click(object sender, EventArgs e)
        {
            Form1 _from1 = (Form1)this.Parent;
            _from1.radyoCal("http://dijimedya.radyotvonline.net/gncradyo");
            
        }

    
    }
}

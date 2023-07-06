namespace Radyo_Uygulaması
{
    partial class PanelTumRadyolar
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radyoPanelBestFM = new Radyo_Uygulaması.RadyoPanel();
            this.radyoPanelFenomen = new Radyo_Uygulaması.RadyoPanel();
            this.radyoPanelBorusan = new Radyo_Uygulaması.RadyoPanel();
            this.radyoPanelJoyFM = new Radyo_Uygulaması.RadyoPanel();
            this.radyoPanelGencFM = new Radyo_Uygulaması.RadyoPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.radyoPanelBestFM);
            this.flowLayoutPanel1.Controls.Add(this.radyoPanelFenomen);
            this.flowLayoutPanel1.Controls.Add(this.radyoPanelBorusan);
            this.flowLayoutPanel1.Controls.Add(this.radyoPanelJoyFM);
            this.flowLayoutPanel1.Controls.Add(this.radyoPanelGencFM);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(428, 406);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // radyoPanelBestFM
            // 
            this.radyoPanelBestFM.BackColor = System.Drawing.Color.Thistle;
            this.radyoPanelBestFM.Frekans = "98.2";
            this.radyoPanelBestFM.Isim = "Best FM";
            this.radyoPanelBestFM.Location = new System.Drawing.Point(3, 3);
            this.radyoPanelBestFM.Logo = global::Radyo_Uygulaması.Properties.Resources.radyoBest;
            this.radyoPanelBestFM.Name = "radyoPanelBestFM";
            this.radyoPanelBestFM.Size = new System.Drawing.Size(400, 130);
            this.radyoPanelBestFM.TabIndex = 5;
            this.radyoPanelBestFM.Tur = "Türkçe Pop";
            this.radyoPanelBestFM.Click += new System.EventHandler(this.radyoPanelBestFM_Click);
            // 
            // radyoPanelFenomen
            // 
            this.radyoPanelFenomen.BackColor = System.Drawing.Color.Thistle;
            this.radyoPanelFenomen.Frekans = "92.8";
            this.radyoPanelFenomen.Isim = "Fenomen FM";
            this.radyoPanelFenomen.Location = new System.Drawing.Point(3, 139);
            this.radyoPanelFenomen.Logo = global::Radyo_Uygulaması.Properties.Resources.radyoFenomen;
            this.radyoPanelFenomen.Name = "radyoPanelFenomen";
            this.radyoPanelFenomen.Size = new System.Drawing.Size(400, 130);
            this.radyoPanelFenomen.TabIndex = 7;
            this.radyoPanelFenomen.Tur = "Yabancı Pop";
            this.radyoPanelFenomen.Click += new System.EventHandler(this.radyoPanelFenomen_Click);
            // 
            // radyoPanelBorusan
            // 
            this.radyoPanelBorusan.BackColor = System.Drawing.Color.Thistle;
            this.radyoPanelBorusan.Frekans = "101.4";
            this.radyoPanelBorusan.Isim = "Borusan Klasik";
            this.radyoPanelBorusan.Location = new System.Drawing.Point(3, 275);
            this.radyoPanelBorusan.Logo = global::Radyo_Uygulaması.Properties.Resources.radyoBorusan;
            this.radyoPanelBorusan.Name = "radyoPanelBorusan";
            this.radyoPanelBorusan.Size = new System.Drawing.Size(400, 130);
            this.radyoPanelBorusan.TabIndex = 6;
            this.radyoPanelBorusan.Tur = "Klasik Müzik";
            this.radyoPanelBorusan.Click += new System.EventHandler(this.radyoPanelBorusan_Click);
            // 
            // radyoPanelJoyFM
            // 
            this.radyoPanelJoyFM.BackColor = System.Drawing.Color.Thistle;
            this.radyoPanelJoyFM.Frekans = "101.2";
            this.radyoPanelJoyFM.Isim = "Joy FM";
            this.radyoPanelJoyFM.Location = new System.Drawing.Point(3, 411);
            this.radyoPanelJoyFM.Logo = global::Radyo_Uygulaması.Properties.Resources.radyoJoy;
            this.radyoPanelJoyFM.Name = "radyoPanelJoyFM";
            this.radyoPanelJoyFM.Size = new System.Drawing.Size(400, 130);
            this.radyoPanelJoyFM.TabIndex = 8;
            this.radyoPanelJoyFM.Tur = "Karışık";
            this.radyoPanelJoyFM.Click += new System.EventHandler(this.radyoPanelJoyFM_Click);
            // 
            // radyoPanelGencFM
            // 
            this.radyoPanelGencFM.BackColor = System.Drawing.Color.Thistle;
            this.radyoPanelGencFM.Frekans = "98.0";
            this.radyoPanelGencFM.Isim = "Genç FM";
            this.radyoPanelGencFM.Location = new System.Drawing.Point(3, 547);
            this.radyoPanelGencFM.Logo = global::Radyo_Uygulaması.Properties.Resources.radyoGenc;
            this.radyoPanelGencFM.Name = "radyoPanelGencFM";
            this.radyoPanelGencFM.Size = new System.Drawing.Size(400, 130);
            this.radyoPanelGencFM.TabIndex = 9;
            this.radyoPanelGencFM.Tur = "Karışık";
            this.radyoPanelGencFM.Click += new System.EventHandler(this.radyoPanelGencFM_Click);
            // 
            // PanelTumRadyolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "PanelTumRadyolar";
            this.Size = new System.Drawing.Size(428, 406);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private RadyoPanel radyoPanelBestFM;
        private RadyoPanel radyoPanelFenomen;
        private RadyoPanel radyoPanelBorusan;
        private RadyoPanel radyoPanelJoyFM;
        private RadyoPanel radyoPanelGencFM;
    }
}

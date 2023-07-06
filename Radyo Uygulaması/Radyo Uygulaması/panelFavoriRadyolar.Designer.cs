namespace Radyo_Uygulaması
{
    partial class panelFavoriRadyolar
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
            this.radyoPanelJoyFM = new Radyo_Uygulaması.RadyoPanel();
            this.radyoPanelFenomen = new Radyo_Uygulaması.RadyoPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.radyoPanelJoyFM);
            this.flowLayoutPanel1.Controls.Add(this.radyoPanelFenomen);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(428, 406);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // radyoPanelJoyFM
            // 
            this.radyoPanelJoyFM.BackColor = System.Drawing.Color.Thistle;
            this.radyoPanelJoyFM.Frekans = "101.2";
            this.radyoPanelJoyFM.Isim = "Joy FM";
            this.radyoPanelJoyFM.Location = new System.Drawing.Point(3, 3);
            this.radyoPanelJoyFM.Logo = global::Radyo_Uygulaması.Properties.Resources.radyoJoy;
            this.radyoPanelJoyFM.Name = "radyoPanelJoyFM";
            this.radyoPanelJoyFM.Size = new System.Drawing.Size(400, 130);
            this.radyoPanelJoyFM.TabIndex = 9;
            this.radyoPanelJoyFM.Tur = "Karışık";
            this.radyoPanelJoyFM.Click += new System.EventHandler(this.radyoPanelJoyFM_Click);
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
            this.radyoPanelFenomen.TabIndex = 10;
            this.radyoPanelFenomen.Tur = "Yabancı Pop";
            this.radyoPanelFenomen.Click += new System.EventHandler(this.radyoPanelFenomen_Click);
            // 
            // panelFavoriRadyolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "panelFavoriRadyolar";
            this.Size = new System.Drawing.Size(428, 406);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private RadyoPanel radyoPanelJoyFM;
        private RadyoPanel radyoPanelFenomen;
    }
}

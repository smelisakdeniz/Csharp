namespace Radyo_Uygulaması
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelUst = new System.Windows.Forms.Panel();
            this.labelLOGO = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMENU = new System.Windows.Forms.Panel();
            this.labelYARDIM = new System.Windows.Forms.Label();
            this.labelAYARLAR = new System.Windows.Forms.Label();
            this.labelFAV = new System.Windows.Forms.Label();
            this.labelRadyolar = new System.Windows.Forms.Label();
            this.labelOpenClose = new System.Windows.Forms.Label();
            this.timerMENU = new System.Windows.Forms.Timer(this.components);
            this.panelOrta = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.panelFavoriRadyolar1 = new Radyo_Uygulaması.panelFavoriRadyolar();
            this.panelTumRadyolar1 = new Radyo_Uygulaması.PanelTumRadyolar();
            this.panelAyarlar1 = new Radyo_Uygulaması.panelAyarlar();
            this.panelUst.SuspendLayout();
            this.panelMENU.SuspendLayout();
            this.panelOrta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUst
            // 
            this.panelUst.BackColor = System.Drawing.Color.Indigo;
            this.panelUst.Controls.Add(this.labelLOGO);
            this.panelUst.Controls.Add(this.labelClose);
            this.panelUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUst.Location = new System.Drawing.Point(5, 5);
            this.panelUst.Name = "panelUst";
            this.panelUst.Size = new System.Drawing.Size(827, 33);
            this.panelUst.TabIndex = 0;
            this.panelUst.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelUst_MouseDown);
            this.panelUst.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelUst_MouseMove);
            this.panelUst.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelUst_MouseUp);
            // 
            // labelLOGO
            // 
            this.labelLOGO.AutoSize = true;
            this.labelLOGO.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelLOGO.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLOGO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLOGO.Location = new System.Drawing.Point(0, 0);
            this.labelLOGO.Name = "labelLOGO";
            this.labelLOGO.Size = new System.Drawing.Size(177, 33);
            this.labelLOGO.TabIndex = 1;
            this.labelLOGO.Text = "Radyo Uygulaması";
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelClose.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelClose.Location = new System.Drawing.Point(798, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(29, 33);
            this.labelClose.TabIndex = 0;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(702, 225);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panelMENU
            // 
            this.panelMENU.BackColor = System.Drawing.Color.Purple;
            this.panelMENU.Controls.Add(this.labelYARDIM);
            this.panelMENU.Controls.Add(this.labelAYARLAR);
            this.panelMENU.Controls.Add(this.labelFAV);
            this.panelMENU.Controls.Add(this.labelRadyolar);
            this.panelMENU.Controls.Add(this.labelOpenClose);
            this.panelMENU.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMENU.Location = new System.Drawing.Point(5, 38);
            this.panelMENU.Name = "panelMENU";
            this.panelMENU.Size = new System.Drawing.Size(177, 556);
            this.panelMENU.TabIndex = 2;
            // 
            // labelYARDIM
            // 
            this.labelYARDIM.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYARDIM.ForeColor = System.Drawing.Color.White;
            this.labelYARDIM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelYARDIM.Location = new System.Drawing.Point(10, 324);
            this.labelYARDIM.Name = "labelYARDIM";
            this.labelYARDIM.Size = new System.Drawing.Size(193, 60);
            this.labelYARDIM.TabIndex = 4;
            this.labelYARDIM.Text = "YARDIM";
            this.labelYARDIM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAYARLAR
            // 
            this.labelAYARLAR.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAYARLAR.ForeColor = System.Drawing.Color.White;
            this.labelAYARLAR.Image = global::Radyo_Uygulaması.Properties.Resources.menuAyar;
            this.labelAYARLAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAYARLAR.Location = new System.Drawing.Point(15, 209);
            this.labelAYARLAR.Name = "labelAYARLAR";
            this.labelAYARLAR.Size = new System.Drawing.Size(162, 60);
            this.labelAYARLAR.TabIndex = 3;
            this.labelAYARLAR.Text = "AYARLAR";
            this.labelAYARLAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelAYARLAR.Click += new System.EventHandler(this.labelAYARLAR_Click);
            this.labelAYARLAR.MouseLeave += new System.EventHandler(this.labelAYARLAR_MouseLeave);
            this.labelAYARLAR.MouseHover += new System.EventHandler(this.labelAYARLAR_MouseHover);
            // 
            // labelFAV
            // 
            this.labelFAV.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFAV.ForeColor = System.Drawing.Color.White;
            this.labelFAV.Image = global::Radyo_Uygulaması.Properties.Resources.menuFavori;
            this.labelFAV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelFAV.Location = new System.Drawing.Point(11, 141);
            this.labelFAV.Name = "labelFAV";
            this.labelFAV.Size = new System.Drawing.Size(166, 60);
            this.labelFAV.TabIndex = 2;
            this.labelFAV.Text = "FAVORİLER";
            this.labelFAV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelFAV.Click += new System.EventHandler(this.labelFAV_Click);
            this.labelFAV.MouseLeave += new System.EventHandler(this.labelFAV_MouseLeave);
            this.labelFAV.MouseHover += new System.EventHandler(this.labelFAV_MouseHover);
            // 
            // labelRadyolar
            // 
            this.labelRadyolar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRadyolar.ForeColor = System.Drawing.Color.White;
            this.labelRadyolar.Image = global::Radyo_Uygulaması.Properties.Resources.menuRadyo;
            this.labelRadyolar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelRadyolar.Location = new System.Drawing.Point(11, 81);
            this.labelRadyolar.Name = "labelRadyolar";
            this.labelRadyolar.Size = new System.Drawing.Size(166, 60);
            this.labelRadyolar.TabIndex = 1;
            this.labelRadyolar.Text = "RADYOLAR";
            this.labelRadyolar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelRadyolar.Click += new System.EventHandler(this.labelRadyolar_Click);
            this.labelRadyolar.MouseLeave += new System.EventHandler(this.labelRadyolar_MouseLeave);
            this.labelRadyolar.MouseHover += new System.EventHandler(this.labelRadyolar_MouseHover);
            // 
            // labelOpenClose
            // 
            this.labelOpenClose.AutoSize = true;
            this.labelOpenClose.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpenClose.ForeColor = System.Drawing.Color.White;
            this.labelOpenClose.Location = new System.Drawing.Point(9, 23);
            this.labelOpenClose.Name = "labelOpenClose";
            this.labelOpenClose.Size = new System.Drawing.Size(46, 58);
            this.labelOpenClose.TabIndex = 0;
            this.labelOpenClose.Text = ">";
            this.labelOpenClose.Click += new System.EventHandler(this.labelOpenClose_Click);
            this.labelOpenClose.MouseLeave += new System.EventHandler(this.labelOpenClose_MouseLeave);
            this.labelOpenClose.MouseHover += new System.EventHandler(this.labelOpenClose_MouseHover);
            // 
            // timerMENU
            // 
            this.timerMENU.Tick += new System.EventHandler(this.timerMENU_Tick);
            // 
            // panelOrta
            // 
            this.panelOrta.Controls.Add(this.panelAyarlar1);
            this.panelOrta.Controls.Add(this.panelFavoriRadyolar1);
            this.panelOrta.Controls.Add(this.panelTumRadyolar1);
            this.panelOrta.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOrta.Location = new System.Drawing.Point(182, 38);
            this.panelOrta.Name = "panelOrta";
            this.panelOrta.Size = new System.Drawing.Size(386, 556);
            this.panelOrta.TabIndex = 3;
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(568, 38);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(264, 556);
            this.axWindowsMediaPlayer.TabIndex = 4;
            // 
            // panelFavoriRadyolar1
            // 
            this.panelFavoriRadyolar1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panelFavoriRadyolar1.Location = new System.Drawing.Point(0, 0);
            this.panelFavoriRadyolar1.Name = "panelFavoriRadyolar1";
            this.panelFavoriRadyolar1.Size = new System.Drawing.Size(386, 553);
            this.panelFavoriRadyolar1.TabIndex = 1;
            // 
            // panelTumRadyolar1
            // 
            this.panelTumRadyolar1.BackColor = System.Drawing.Color.Plum;
            this.panelTumRadyolar1.Location = new System.Drawing.Point(0, 0);
            this.panelTumRadyolar1.Name = "panelTumRadyolar1";
            this.panelTumRadyolar1.Size = new System.Drawing.Size(386, 553);
            this.panelTumRadyolar1.TabIndex = 0;
            // 
            // panelAyarlar1
            // 
            this.panelAyarlar1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelAyarlar1.Location = new System.Drawing.Point(0, -2);
            this.panelAyarlar1.Name = "panelAyarlar1";
            this.panelAyarlar1.Size = new System.Drawing.Size(386, 555);
            this.panelAyarlar1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(837, 599);
            this.Controls.Add(this.axWindowsMediaPlayer);
            this.Controls.Add(this.panelOrta);
            this.Controls.Add(this.panelMENU);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelUst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.labelClose_Click);
            this.panelUst.ResumeLayout(false);
            this.panelUst.PerformLayout();
            this.panelMENU.ResumeLayout(false);
            this.panelMENU.PerformLayout();
            this.panelOrta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUst;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelLOGO;
        private System.Windows.Forms.Panel panelMENU;
        private System.Windows.Forms.Label labelRadyolar;
        private System.Windows.Forms.Label labelOpenClose;
        private System.Windows.Forms.Label labelAYARLAR;
        private System.Windows.Forms.Label labelFAV;
        private System.Windows.Forms.Label labelYARDIM;
        private System.Windows.Forms.Timer timerMENU;
        private System.Windows.Forms.Panel panelOrta;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private panelFavoriRadyolar panelFavoriRadyolar1;
        private PanelTumRadyolar panelTumRadyolar1;
        private panelAyarlar panelAyarlar1;
    }
}


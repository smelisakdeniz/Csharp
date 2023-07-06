namespace Radyo_Uygulaması
{
    partial class RadyoPanel
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelİsim = new System.Windows.Forms.Label();
            this.labelFrekans = new System.Windows.Forms.Label();
            this.labelTur = new System.Windows.Forms.Label();
            this.buttonFavori = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelİsim
            // 
            this.labelİsim.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelİsim.ForeColor = System.Drawing.Color.Black;
            this.labelİsim.Location = new System.Drawing.Point(125, 17);
            this.labelİsim.Name = "labelİsim";
            this.labelİsim.Size = new System.Drawing.Size(143, 31);
            this.labelİsim.TabIndex = 1;
            this.labelİsim.Text = "Radyo İsmi";
            // 
            // labelFrekans
            // 
            this.labelFrekans.AutoSize = true;
            this.labelFrekans.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrekans.ForeColor = System.Drawing.Color.Black;
            this.labelFrekans.Location = new System.Drawing.Point(125, 54);
            this.labelFrekans.Name = "labelFrekans";
            this.labelFrekans.Size = new System.Drawing.Size(94, 31);
            this.labelFrekans.TabIndex = 2;
            this.labelFrekans.Text = "100.0";
            // 
            // labelTur
            // 
            this.labelTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTur.ForeColor = System.Drawing.Color.DimGray;
            this.labelTur.Location = new System.Drawing.Point(125, 93);
            this.labelTur.Name = "labelTur";
            this.labelTur.Size = new System.Drawing.Size(124, 24);
            this.labelTur.TabIndex = 3;
            this.labelTur.Text = "Yabancı Pop";
            // 
            // buttonFavori
            // 
            this.buttonFavori.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonFavori.Image = global::Radyo_Uygulaması.Properties.Resources.menuFavori;
            this.buttonFavori.Location = new System.Drawing.Point(274, 7);
            this.buttonFavori.Name = "buttonFavori";
            this.buttonFavori.Size = new System.Drawing.Size(47, 41);
            this.buttonFavori.TabIndex = 4;
            this.buttonFavori.UseVisualStyleBackColor = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Radyo_Uygulaması.Properties.Resources.radyoBest;
            this.pictureBoxLogo.Location = new System.Drawing.Point(19, 17);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // RadyoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.Controls.Add(this.buttonFavori);
            this.Controls.Add(this.labelTur);
            this.Controls.Add(this.labelFrekans);
            this.Controls.Add(this.labelİsim);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "RadyoPanel";
            this.Size = new System.Drawing.Size(335, 130);
            this.MouseLeave += new System.EventHandler(this.RadyoPanel_MouseLeave);
            this.MouseHover += new System.EventHandler(this.RadyoPanel_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelİsim;
        private System.Windows.Forms.Label labelFrekans;
        private System.Windows.Forms.Label labelTur;
        private System.Windows.Forms.Button buttonFavori;
    }
}

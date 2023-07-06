namespace Radyo_Uygulaması
{
    partial class panelAyarlar
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
            this.labelAyarlar = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAyarlar
            // 
            this.labelAyarlar.AutoSize = true;
            this.labelAyarlar.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAyarlar.ForeColor = System.Drawing.Color.White;
            this.labelAyarlar.Location = new System.Drawing.Point(12, 12);
            this.labelAyarlar.Name = "labelAyarlar";
            this.labelAyarlar.Size = new System.Drawing.Size(142, 32);
            this.labelAyarlar.TabIndex = 0;
            this.labelAyarlar.Text = "AYARLAR";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Görüntü Ayarları";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(57, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(243, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ses Ayarları";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panelAyarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelAyarlar);
            this.Name = "panelAyarlar";
            this.Size = new System.Drawing.Size(386, 386);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAyarlar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

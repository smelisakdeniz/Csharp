using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinası
{
    public partial class Form1 : Form
    {
        Double sonuc = 0;
        String islem = "";
        bool islemSecili = false, yenisayı = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Sayilar_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            // yeni sayı giriliyor 
            if (yenisayı)
            {
                label_SAYİ.Text = "";
                yenisayı = false;
            }

            // negatif pozitif
            if (button.Text == "-/+")
            {
                if (label_SAYİ.Text != "")
                {
                    label_SAYİ.Text = "" + (Double.Parse(label_SAYİ.Text) * -1);
                }
            } 
            
            // ondalık sayı girişi
            else if (button.Text == ",")
            {
                if (label_SAYİ.Text == "")
                {
                    label_SAYİ.Text = "0,";
                }
                if (!label_SAYİ.Text.Contains(","))
                {
                    label_SAYİ.Text += ",";
                }
            }

            else
            {
                if (label_SAYİ.Text == "0")
                {
                    label_SAYİ.Text = "";
                }
                label_SAYİ.Text += button.Text;
            }
        }  
        private void Islemler_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (islemSecili)
            {
                button_ESİTTİR.PerformClick();
            }
            else
            {
                sonuc = Double.Parse(label_SAYİ.Text);
            }
            islem = button.Text;
            label_İSLEMLER.Text = sonuc + " " + islem;
            yenisayı = true;
            islemSecili = true;

        }

        private void button_ESİTTİR_Click(object sender, EventArgs e)
        {
            if (islemSecili)
            {
                String gecmis = label_İSLEMLER.Text + " " + label_SAYİ.Text + " = ";
                switch (islem)
                {
                    case "+":
                        label_SAYİ.Text = (sonuc + Double.Parse(label_SAYİ.Text)).ToString();
                        break;
                    case "-":
                        label_SAYİ.Text = (sonuc - Double.Parse(label_SAYİ.Text)).ToString();
                        break;
                    case "x":
                        label_SAYİ.Text = (sonuc * Double.Parse(label_SAYİ.Text)).ToString();
                        break;
                    case "/":
                        label_SAYİ.Text = (sonuc / Double.Parse(label_SAYİ.Text)).ToString();
                        break;
                    default:
                        break;
                }
                sonuc = Double.Parse(label_SAYİ.Text);
                listBox_GECMİS.Items.Add(gecmis + sonuc);
                label_İSLEMLER.Text = "";
                label_İSLEMLER.Text = sonuc + " " + islem;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CE_Click(object sender, EventArgs e)
        {
            label_SAYİ.Text = "0 ";
            yenisayı = true;
        }

        private void button_CLEAR_Click(object sender, EventArgs e)
        {
            button_CE.PerformClick();
            islem = "";
            label_İSLEMLER.Text = "";
            islemSecili = false;

        }

        private void button_AC_Click(object sender, EventArgs e)
        {
            button_CLEAR.PerformClick();
            listBox_GECMİS.Items.Clear();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}

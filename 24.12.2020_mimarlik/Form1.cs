using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24._12._2020_mimarlik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         
           _                                                    
 | |      | |                                            
 | |_ ___ | | __ _  __ _   _ __   ___   __ _  __ _ _   _ 
 | __/ _ \| |/ _` |/ _` | | '_ \ / _ \ / _` |/ _` | | | |
 | || (_) | | (_| | (_| | | | | | (_) | (_| | (_| | |_| |
  \__\___/|_|\__, |\__,_| |_| |_|\___/ \__, |\__,_|\__, |
              __/ |                     __/ |       __/ |
             |___/                     |___/       |___/ 

        𝐭𝐨𝐥𝐠𝐚𝐧𝐨𝐠𝐚𝐲.𝐜𝐨𝐦 / 𝐓𝐨𝐥𝐠𝐚 N𝐨𝐠𝐚𝐲

         */

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==0)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Perspektif");
                comboBox2.Items.Add("Zemin Kat");
                comboBox2.Items.Add("Birinci Kat");
            }
            else if (comboBox1.SelectedIndex==1)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Perspektif B");
                comboBox2.Items.Add("Zemin Kat B");
                comboBox2.Items.Add("Birinci Kat B");
                    
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == "Perspektif")
            {
                pictureBox1.Image = Image.FromFile("D:\\TolgaNogay/Okul Örnekleri/24.12.2020_mimarlik/villa plan/2katlivilla2/1.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (comboBox2.SelectedItem == "Zemin")
            {
                pictureBox1.Image = Image.FromFile("D:\\TolgaNogay/Okul Örnekleri/24.12.2020_mimarlik/villa plan/2katlivilla2/2.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (comboBox2.SelectedItem == "Birinci Kat")
            {
                pictureBox1.Image = Image.FromFile("D:\\TolgaNogay/Okul Örnekleri/24.12.2020_mimarlik/villa plan/2katlivilla2/3.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (comboBox2.SelectedItem == "Perspektif B")
            {
                pictureBox1.Image = Image.FromFile("D:\\TolgaNogay/Okul Örnekleri/24.12.2020_mimarlik/villa plan/2katlivilla/1.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (comboBox2.SelectedItem == "Zemin Kat B")
            {
                pictureBox1.Image = Image.FromFile("D:\\TolgaNogay/Okul Örnekleri/24.12.2020_mimarlik/villa plan/2katlivilla/2.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (comboBox2.SelectedItem == "Birinci Kat B")
            {
                pictureBox1.Image = Image.FromFile("D:\\TolgaNogay/Okul Örnekleri/24.12.2020_mimarlik/villa plan/2katlivilla/1.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("Seçim yapılmadı.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace GorselProgramlamaProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        


        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1 || textBox2.Text == "")
            {
                MessageBox.Show("Ürün ve adet seçin.");
                return;
            }

            string urun = comboBox2.SelectedItem.ToString();
            int adet = int.Parse(textBox2.Text);
            double fiyat = 0;
            if (urun == "T-Shirt : 200 TL") fiyat = 200;
            if (urun == "Kazak : 300 TL") fiyat = 300;
            if (urun == "Pantolon : 350 TL") fiyat = 350;
            if (urun == "Gömlek : 250 TL") fiyat = 250;
            if (urun == "Mont : 800 TL") fiyat = 800;

            double tutar = fiyat * adet;

            listBox1.Items.Add($"{urun} x {adet} = {tutar:F2} TL");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            if (listBox1.SelectedIndex == -1)
            {
                label24.Visible = true;
                return;
            }

            label24.Visible = false;


            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double araToplam = 0;
            int toplamAdet = 0;

            foreach(string item in listBox1.Items)
            {
                string[] parca = item.Split(' ');

                int adet = int.Parse(parca[5]);
                string tutarYazi = parca[7].Trim();
                double tutar = double.Parse(tutarYazi, new CultureInfo("tr-TR"));
                toplamAdet += adet;
                araToplam += tutar;
            }

            double indirim = 0;

            // burası öğrenci indirimii için:
            if (comboBox5.Text == "Öğrenci")
                indirim += araToplam * 0.05;
            // burası premium indirimi için:
            if (comboBox5.Text == "Premium")
                indirim += araToplam * 0.10;
            // 10dan fazla ürün alana indirim:
            if (toplamAdet >= 10)
                indirim += araToplam * 0.05;

            double kargo = 0;

            if (comboBox4.Text == "Standart")
                kargo = 29.90;
            if (comboBox4.Text == "Hızlı")
                kargo = 59.90;
            if (comboBox4.Text == "Express")
                kargo = 99.90;

            if (comboBox1.Text == "İstanbul")
                kargo = kargo * 0.90;
            if (comboBox1.Text == "Ankara" || comboBox1.Text == "İzmir")
                kargo = kargo * 0.95;

            double genelToplam = araToplam - indirim + kargo;

            label17.Text = araToplam.ToString("F2") + "TL";
            label19.Text = indirim.ToString("F2") + "TL";
            label21.Text = kargo.ToString("F2") + "TL";
            label23.Text = genelToplam.ToString("F2") + "TL";

            if (genelToplam >= 1000)
                panel1.BackColor = Color.Green;
            else 
                panel1.BackColor = Color.Orange;

            MessageBox.Show(
                $"Müşteri: {textBox1.Text}\n" +
                $"Toplam Ürün Adedi: {toplamAdet}\n" +
                $"İndirim Türü: {comboBox5.Text}\n" +
                $"Genel Toplam: {genelToplam:F2} TL",
                "Sipariş Özeti");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

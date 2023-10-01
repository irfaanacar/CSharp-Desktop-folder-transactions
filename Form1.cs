using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string klasör=textBox1.Text;
            try
            {
                Directory.Delete("C:\\Users\\irfaa\\OneDrive\\Masaüstü\\" + klasör);
                MessageBox.Show("KLASÖR BAŞARIYLA SİLİNDİ.");
            }
            catch (Exception)
            {
                MessageBox.Show("KLASÖR SİLİNEMEDİ.");


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string klasör = textBox1.Text;
            try
            {
                Directory.CreateDirectory("C:\\Users\\irfaa\\OneDrive\\Masaüstü\\" + klasör);
                MessageBox.Show("KLASÖR BAŞARIYLA OLUŞTURULDU");
            }
            catch (Exception)
            {
                MessageBox.Show("KLASÖR OLUŞTURULAMADI.");

            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string adres = "C:\\Users\\irfaa\\OneDrive\\Masaüstü\\GitHub Projects";
            MessageBox.Show(Directory.GetCreationTime(adres).ToString());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Directory.GetCurrentDirectory().ToString());
            MessageBox.Show("ŞU ANDA AÇIK OLAN KLASÖRÜN YOLU BELİRTİLDİ");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string yol = "C:\\Users\\irfaa\\OneDrive\\Masaüstü\\GitHub Projects";
            MessageBox.Show(Directory.GetLastAccessTime(yol).ToString());
            MessageBox.Show("SON ERİŞİM ZAMANI BELİRTİLDİ");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Directory.Move("C:\\Users\\irfaa\\OneDrive\\Masaüstü\\ab", "C:\\Users\\irfaa\\OneDrive\\Masaüstü\\yeni ad bu");
            MessageBox.Show("MASAÜSTÜNDE EĞER SİLİNMEDİYSE AB İSİMLİ KLASÖRÜN İSMİNİ 'YENİ AD BU' ŞEKLİNDE DEĞİŞTİRDİK.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = "DOSYALARI LİSTELE";
            string adres = "C:\\Program Files (x86)";
            string[] klasor = Directory.GetDirectories(adres);
            foreach(string j in klasor)
            {
                listBox1.Items.Add(j).ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label2.Text = "SÜRÜCÜLERİ LİSTELE";
            string[] dizi = System.IO.Directory.GetLogicalDrives();
            foreach (string i in dizi)
            {
                listBox1.Items.AddRange(dizi);
            }

        }
    }
}

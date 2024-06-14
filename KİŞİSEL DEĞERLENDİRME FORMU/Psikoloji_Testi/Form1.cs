using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Psikoloji_Testi
{
    public partial class Form1 : Form
    {
     

        public Form1()
        {
            InitializeComponent();
            this.Controls.Add(lblDegerlendirme);


        }
        

        private void btn1_Click(object sender, EventArgs e)
        {
            int puan;
            if (int.TryParse(textBox1.Text, out puan))
            {
                if (puan >= 1 && puan <= 10)
                {
                    // Burada puanı işleyebilirsiniz, örneğin bir veritabanına kaydedebilirsiniz.
                    MessageBox.Show("Puanınız kaydedildi: " + puan);
                }
                else
                {
                    MessageBox.Show("Lütfen 1 ile 10 arasında bir değer girin!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin!");
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int puan;
            if (int.TryParse(textBox2.Text, out puan))
            {
                if (puan >= 1 && puan <= 10)
                {
                    // Burada puanı işleyebilirsiniz, örneğin bir veritabanına kaydedebilirsiniz.
                    MessageBox.Show("Puanınız kaydedildi: " + puan);
                }
                else
                {
                    MessageBox.Show("Lütfen 1 ile 10 arasında bir değer girin!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin!");
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int puan;
            if (int.TryParse(textBox3.Text, out puan))
            {
                if (puan >= 1 && puan <= 10)
                {
                    // Burada puanı işleyebilirsiniz, örneğin bir veritabanına kaydedebilirsiniz.
                    MessageBox.Show("Puanınız kaydedildi: " + puan);
                }
                else
                {
                    MessageBox.Show("Lütfen 1 ile 10 arasında bir değer girin!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin!");
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            int puan;
            if (int.TryParse(textBox4.Text, out puan))
            {
                if (puan >= 1 && puan <= 10)
                {
                    // Burada puanı işleyebilirsiniz, örneğin bir veritabanına kaydedebilirsiniz.
                    MessageBox.Show("Puanınız kaydedildi: " + puan);
                }
                else
                {
                    MessageBox.Show("Lütfen 1 ile 10 arasında bir değer girin!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin!");
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            int puan;
            if (int.TryParse(textBox5.Text, out puan))
            {
                if (puan >= 1 && puan <= 10)
                {
                    // Burada puanı işleyebilirsiniz, örneğin bir veritabanına kaydedebilirsiniz.
                    MessageBox.Show("Puanınız kaydedildi: " + puan);
                }
                else
                {
                    MessageBox.Show("Lütfen 1 ile 10 arasında bir değer girin!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin!");
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            int puan;
            if (int.TryParse(textBox6.Text, out puan))
            {
                if (puan >= 1 && puan <= 10)
                {
                    // Burada puanı işleyebilirsiniz, örneğin bir veritabanına kaydedebilirsiniz.
                    MessageBox.Show("Puanınız kaydedildi: " + puan);
                }
                else
                {
                    MessageBox.Show("Lütfen 1 ile 10 arasında bir değer girin!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin!");
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            int puan;
            if (int.TryParse(textBox7.Text, out puan))
            {
                if (puan >= 1 && puan <= 10)
                {
                    // Burada puanı işleyebilirsiniz, örneğin bir veritabanına kaydedebilirsiniz.
                    MessageBox.Show("Puanınız kaydedildi: " + puan);
                }
                else
                {
                    MessageBox.Show("Lütfen 1 ile 10 arasında bir değer girin!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin!");
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            int puan;
            if (int.TryParse(textBox8.Text, out puan))
            {
                if (puan >= 1 && puan <= 10)
                {
                    // Burada puanı işleyebilirsiniz, örneğin bir veritabanına kaydedebilirsiniz.
                    MessageBox.Show("Puanınız kaydedildi: " + puan);
                }
                else
                {
                    MessageBox.Show("Lütfen 1 ile 10 arasında bir değer girin!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin!");
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            int puan;
            if (int.TryParse(textBox9.Text, out puan))
            {
                if (puan >= 1 && puan <= 10)
                {
                    // Burada puanı işleyebilirsiniz, örneğin bir veritabanına kaydedebilirsiniz.
                    MessageBox.Show("Puanınız kaydedildi: " + puan);
                }
                else
                {
                    MessageBox.Show("Lütfen 1 ile 10 arasında bir değer girin!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin!");
            }
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            int puan;
            if (int.TryParse(textBox10.Text, out puan))
            {
                if (puan >= 1 && puan <= 10)
                {
                    // Burada puanı işleyebilirsiniz, örneğin bir veritabanına kaydedebilirsiniz.
                    MessageBox.Show("Puanınız kaydedildi: " + puan);
                }
                else
                {
                    MessageBox.Show("Lütfen 1 ile 10 arasında bir değer girin!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin!");
            }
        }
        class AnketVerisi
        {
            public int Soru1Puan { get; set; }
            public int Soru2Puan { get; set; }
            public int Soru3Puan { get; set; }
            public int Soru4Puan { get; set; }
            public int Soru5Puan { get; set; }
            public int Soru6Puan { get; set; }
            public int Soru7Puan { get; set; }
            public int Soru8Puan { get; set; }
            public int Soru9Puan { get; set; }
            public int Soru10Puan { get; set; }
            // Daha fazla soru için gerektiği kadar özellik eklenebilir.
        }

        // Puanlama işlemini gerçekleştiren sınıf
        class Puanlayici
        {
            public int Puanla(AnketVerisi veri)
            {
                // Örnek olarak soruların puanlarını toplayıp bir genel puan elde ediyoruz
                int genelPuan = veri.Soru1Puan + veri.Soru2Puan + veri.Soru3Puan + veri.Soru4Puan 
                    + veri.Soru5Puan + veri.Soru6Puan + veri.Soru7Puan + veri.Soru8Puan 
                    + veri.Soru9Puan + veri.Soru10Puan;
                // Daha karmaşık bir puanlama algoritması burada uygulanabilir
                return genelPuan;
            }
        }

        
        private void btn11_Click(object sender, EventArgs e)
        {


            
                string ad = txtAd.Text;
                string soyad = txtSoyad.Text;

                // Ad ve soyadın boş olup olmadığını kontrol et
                if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad))
                {
                    MessageBox.Show("Lütfen adınızı ve soyadınızı giriniz.");
                    return; // Ad ve soyad boşsa işlemi sonlandır
                }

                // Anket verisi oluşturuluyor (örnek olarak)
                AnketVerisi veri = new AnketVerisi();

                // Soru puanlarını TextBox'lardan alarak AnketVerisi nesnesine atama yapma işlemi
                if (int.TryParse(textBox1.Text, out int soru1Puan) &&
                    int.TryParse(textBox2.Text, out int soru2Puan) &&
                    int.TryParse(textBox3.Text, out int soru3Puan) &&
                    int.TryParse(textBox4.Text, out int soru4Puan) &&
                    int.TryParse(textBox5.Text, out int soru5Puan) &&
                    int.TryParse(textBox6.Text, out int soru6Puan) &&
                    int.TryParse(textBox7.Text, out int soru7Puan) &&
                    int.TryParse(textBox8.Text, out int soru8Puan) &&
                    int.TryParse(textBox9.Text, out int soru9Puan) &&
                    int.TryParse(textBox10.Text, out int soru10Puan))
                {
                    // Tüm puanlar geçerli bir şekilde dönüştürülebildi, AnketVerisi nesnesine atama yapılıyor
                    veri.Soru1Puan = soru1Puan;
                    veri.Soru2Puan = soru2Puan;
                    veri.Soru3Puan = soru3Puan;
                    veri.Soru4Puan = soru4Puan;
                    veri.Soru5Puan = soru5Puan;
                    veri.Soru6Puan = soru6Puan;
                    veri.Soru7Puan = soru7Puan;
                    veri.Soru8Puan = soru8Puan;
                    veri.Soru9Puan = soru9Puan;
                    veri.Soru10Puan = soru10Puan;

                    // Puanlama işlemi gerçekleştiriliyor
                    Puanlayici puanlayici = new Puanlayici();
                    int genelPuan = puanlayici.Puanla(veri);

                    // Genel puan sayı türünde olduğu için bir dereceye çeviriyoruz
                    string derece;
                    if (genelPuan >= 90)
                    {
                        derece = "Çok İyi";
                    }
                    else if (genelPuan >= 70)
                    {
                        derece = "İyi";
                    }
                    else if (genelPuan >= 50)
                    {
                        derece = "Orta";
                    }
                    else
                    {
                        derece = "Kötü";
                    }

                    // Anket sonucunu Label kontrolüne yazdırın
                    lblDegerlendirme.Text = "Anket sonucunuz: " + derece;

                // DataGridView'e ekleme işlemi
                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells["Column1"].Value = ad + " " + soyad; // Ad ve soyadı birleştirerek yazdır
                dataGridView1.Rows[rowIndex].Cells["Column2"].Value = derece; // Dereceyi yazdır

                MessageBox.Show("PERSONEL KAYDI TAMAMLANDI!");

            }
            else
                {
                    // Bir veya daha fazla soru puanı geçerli bir tamsayıya dönüştürülemedi
                    MessageBox.Show("Lütfen tüm sorulara geçerli bir puan girin!");
                }
            




        }



        private void Form1_Load(object sender, EventArgs e)
        {
            
                // DataGridView sütunlarını tanımladıktan sonra satır ekleyin
                dataGridView1.Columns.Add("Column1", "İSİM SOYİSİM");
            dataGridView1.Columns["Column1"].Width = 300;

            dataGridView1.Columns.Add("Column2", "DURUM");
            dataGridView1.Columns["Column2"].Width = 150;







        }


    }
}

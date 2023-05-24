using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavNetHesap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double turkcedogru = 0, turkceyanlis = 0, matdogru = 0, matyanlis = 0, fendogru = 0, fenyanlis = 0, sosyaldogru = 0, sosyalyanlis = 0, turkcenet = 0, matnet = 0, fennet = 0, sosyalnet = 0, matsorusayi=0,turkcesorusayi=0,fensorusayi=0,soysalsorusayi=0;
            
            if (TurkceDogrutextBox.Text == "" || TurkceYanlistextBox.Text =="" || MatDogrutextBox.Text=="" || MatYanlistextBox.Text==""|| FenDogrutextBox.Text == "" || FenYanlistextBox.Text == "" || SosyalDogrutextBox.Text==""|| SosyalYanlistextBox.Text=="")
            {
                MessageBox.Show("Lütfen bütün kutucukları doldurunuz.");
            }
            else
            {
                turkcedogru = Convert.ToDouble(TurkceDogrutextBox.Text);
                turkceyanlis = Convert.ToDouble(TurkceYanlistextBox.Text);

                matdogru = Convert.ToDouble(MatDogrutextBox.Text);
                matyanlis = Convert.ToDouble(MatYanlistextBox.Text);

                fendogru = Convert.ToDouble(FenDogrutextBox.Text);
                fenyanlis = Convert.ToDouble(FenYanlistextBox.Text);

                sosyaldogru = Convert.ToDouble(SosyalDogrutextBox.Text);
                sosyalyanlis = Convert.ToDouble(SosyalYanlistextBox.Text);

                turkcenet = turkcedogru - (turkceyanlis * 0.25);
                matnet = matdogru - (matyanlis * 0.25);
                fennet = fendogru - (fenyanlis * 0.25);
                sosyalnet = sosyaldogru - (sosyalyanlis * 0.25);

                matsorusayi = Convert.ToInt32(MatDogrutextBox.Text) + Convert.ToInt32(MatYanlistextBox.Text);
                turkcesorusayi = Convert.ToInt32(TurkceDogrutextBox.Text) + Convert.ToInt32(TurkceYanlistextBox.Text);
                fensorusayi = Convert.ToInt32(FenDogrutextBox.Text) + Convert.ToInt32(FenYanlistextBox.Text);
                soysalsorusayi = Convert.ToInt32(SosyalDogrutextBox.Text) + Convert.ToInt32(SosyalYanlistextBox.Text);
            }
            if (matsorusayi > 40 || turkcesorusayi > 40)
            {
                MessageBox.Show("Türkçe veya Matematikte yanlış değer girildi, her iki ders de 40 sorudur. Doğru ve Yanlış sayısını kontol ediniz.");
            }
            else if (fensorusayi > 20 || soysalsorusayi > 20)
            {
                MessageBox.Show("Fen veya Sosyalde yanlış değer girildi, her iki ders de 20 sorudur. Doğru ve Yanlış sayısını kontol ediniz.");
            }
            else
            {
                TurkceNettextBox.Text = turkcenet.ToString();
                MatNettextBox.Text = matnet.ToString();
                FenNettextBox.Text = fennet.ToString();
                SosyalNettextBox.Text = sosyalnet.ToString();
                if (turkcenet < 20)
                {
                    TurkceNettextBox.BackColor = Color.Red;
                    TurkceNettextBox.ForeColor = Color.White;
                }
                else
                {
                    TurkceNettextBox.BackColor = Color.White;
                }
                if (matnet < 20)
                {
                    MatNettextBox.BackColor = Color.Red;
                    MatNettextBox.ForeColor = Color.White;
                }
                else
                {
                    MatNettextBox.BackColor = Color.White;
                }
                if (fennet < 10)
                {
                    FenNettextBox.BackColor = Color.Red;
                    FenNettextBox.ForeColor = Color.White;
                }
                else
                {
                    FenNettextBox.BackColor = Color.White;
                }
                if (sosyalnet < 10)
                {
                    SosyalNettextBox.BackColor = Color.Red;
                    SosyalNettextBox.ForeColor = Color.White;
                }
                else
                {
                    SosyalNettextBox.BackColor = Color.White;
                }
            }

        }
    }
}

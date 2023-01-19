using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp5.Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp5
{
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnaMenu fr = new AnaMenu();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new Context())
            {
            
                var musteri = new Musteriler();
                {
                    musteri.musteri_no = textBox4.Text;
                    musteri.isim = textBox1.Text;
                    musteri.soyisim = textBox2.Text;
                    musteri.adres = textBox3.Text;
                };
                context.musterilers.Add(musteri);
                context.SaveChanges();
                }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

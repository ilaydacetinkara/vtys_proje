using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp5.Entity;

namespace WindowsFormsApp5
{
    public partial class VeresiyeOdeme : Form
    {
        public VeresiyeOdeme()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnaMenu fr = new AnaMenu();
            fr.Show();
            this.Hide();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void VeresiyeOdeme_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var context = new Context())
            {
                var musteriler = context.musterilers
                                    .Where(u => u.isim == textBox2.Text)
                                    .Select(u=> new { u.musteri_no, u.veresiye_Satis, u.isim, u.adres, u.soyisim })
                                    .ToList();
                dataGridView1.DataSource = musteriler;
                dataGridView1.AutoGenerateColumns = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

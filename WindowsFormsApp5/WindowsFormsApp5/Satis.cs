﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Satis : Form
    {
        public Satis()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VeresiyeGiris fr = new VeresiyeGiris();
            fr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AnaMenu fr = new AnaMenu();
            fr.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpedApp
{
    public partial class FormPgt6 : Form
    {
        public FormPgt6()
        {
            InitializeComponent();
        }

        private void bntPgt6_Click(object sender, EventArgs e)
        {
            if (radioBnt1.Checked == true)
            {
                Porcentagem PorOBJ = new Porcentagem();
                PorOBJ.valor += 1;

                FormPgt7 pgt7 = new FormPgt7();
                pgt7.ShowDialog();
                this.Dispose();
            }

            else if (radioBnt2.Checked == true)
            {
                Porcentagem PorOBJ = new Porcentagem();
                PorOBJ.valor2 += 1;

                FormPgt7 pgt7 = new FormPgt7();
                pgt7.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Assinale uma alternativa");
            }
        }

        private void radioBnt2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBnt1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

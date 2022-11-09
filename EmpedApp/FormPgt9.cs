using System;
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
    public partial class FormPgt9 : Form
    {
        public FormPgt9()
        {
            InitializeComponent();
        }

        private void bntPgt7_Click(object sender, EventArgs e)
        {
            if (radioBnt1.Checked == true)
            {
                pontos.a += 1;
                FormPgt10 pgt10 = new FormPgt10();
                pgt10.ShowDialog();
                this.Dispose();

            }

            else if (radioBnt2.Checked == true)
            {
                FormPgt10 pgt10 = new FormPgt10();
                pgt10.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Assinale uma alternativa");
            }
        }
    }
}

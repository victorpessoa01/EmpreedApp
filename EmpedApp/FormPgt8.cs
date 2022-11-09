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
    public partial class FormPgt8 : Form
    {
        public FormPgt8()
        {
            InitializeComponent();
        }

        private void bntPgt8_Click(object sender, EventArgs e)
        {
            if (radioBnt1.Checked == true)
            {
                FormPgt9 pgt9 = new FormPgt9();
                pgt9.ShowDialog();
                this.Dispose();
            }

            else if (radioBnt2.Checked == true)
            {
                FormPgt9 pgt9 = new FormPgt9();
                pgt9.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Assinale uma alternativa");
            }
        }
    }
}

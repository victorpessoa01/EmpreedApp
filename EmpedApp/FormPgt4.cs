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
    public partial class FormPgt4 : Form
    {
        public FormPgt4()
        {
            InitializeComponent();
        }

        private void bntPgt4_Click(object sender, EventArgs e)
        {
            if (radioBnt1.Checked == true)
            {
                pontos.a += 1;
                FormPgt5 pgt5 = new FormPgt5();
                pgt5.ShowDialog();
                this.Dispose();
                
            }

            else if (radioBnt2.Checked == true)
            {
                FormPgt5 pgt5 = new FormPgt5();
                pgt5.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Assinale uma alternativa");
            }
        }
    }
}

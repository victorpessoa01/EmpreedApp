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
                FormPerfil perfil = new FormPerfil();
                perfil.ShowDialog();
                this.Dispose();
            }

            else if (radioBnt2.Checked == true)
            {
                FormPerfil perfil = new FormPerfil();
                perfil.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Assinale uma alternativa");
            }
        }
    }
}

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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Porcentagem PorOBJ = new Porcentagem();
            PorOBJ.valor = 0;
            PorOBJ.nome = textBoxNome.Text;

            if (textBoxNome.Text == "")
            {
                MessageBox.Show("Insira seu nome");
            }

            else
            {
                FormPgt1 pgt1 = new FormPgt1();
                pgt1.ShowDialog();
                this.Dispose();
            }
        }
    }
}

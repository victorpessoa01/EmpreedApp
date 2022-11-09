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
    public partial class FormPerfil : Form
    {
        public FormPerfil()
        {
            InitializeComponent();

            pontos pontos = new pontos();

            labelNome.Text = pontos.nome;

            if (pontos.a < 6)
            {
               labelA.Text = "Sua nota foi " + pontos.a + ".0 Pontos";
               labelB.Text = "Você não tem um perfil Empreendedor";
            }

            else if (pontos.a >= 6)
            {
                labelA.Text = "Sua nota foi " + pontos.a+".0 Pontos";
                labelB.Text = "Você tem um perfil Empreendedor";                
            }


        }

        private void FormPerfil_Load(object sender, EventArgs e)
        {
            
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bntMenu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelA_Click(object sender, EventArgs e)
        {
        }

        private void labeltext_Click(object sender, EventArgs e)
        {

        }
    }
}

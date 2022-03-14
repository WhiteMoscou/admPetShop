using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admPetShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCadCliente cliente = new frmCadCliente();
            cliente.topLevel = false;
            cliente.Dock = DockStyle.Fill;
            centralPanel.Controls.Add(cliente); //Adiciona o form no painel
        }

        private void btnFecharJanela_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair a aplicação?","Adm PetShop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {

        }

        private void btnMinimizarJanela_Click(object sender, EventArgs e)
        {
            //Minimizar   
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

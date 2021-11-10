using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if ((txtEmail.Text == "exemplo@gmail.com") && (txtSenha.Text == "exemplo123"))
            {
                Form3 frmp = new Form3();
                frmp.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.", "Ocorreu um erro ao autenticar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

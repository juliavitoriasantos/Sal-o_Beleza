using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salão_Beleza
{
    public partial class Tela_login : Form
    {
        public Tela_login()
        {
            InitializeComponent();
        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void txbUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txbUser.Text == "admin" && txbSenha.Text == "123456")
            {
                txbUser.Text = String.Empty; //Limpa campo de usuário
                txbSenha.Text = String.Empty; //Limpa o campo de senha
                txbUser.Focus(); //Coloca o foco no campo de usuário
                Form1 Tela_login = new Form1();
                this.Visible = false; // Esconder a tela de login
                Tela_login.ShowDialog();//Abre a tela principal
                this.Visible = true; //Volta a mortrar a tela de login
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha incorretos.",
                "ERRO NO LOGIN",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
    }
}

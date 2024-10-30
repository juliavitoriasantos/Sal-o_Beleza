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
    public partial class Tela_Tipo : Form
    {
        public Tela_Tipo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Tela_Tipo_Load(object sender, EventArgs e)
        {

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            string nome = txbnome.Text;
            string status = cbbstatus.Text;
            Tipo tipo = new Tipo(nome, status);
            TipoDAO tipoDAO = new TipoDAO();
            tipoDAO.Inserir(tipo);
        }
    }
}

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
    public partial class Tela_Cadastro : Form
    {
        public Tela_Cadastro()
        {
            InitializeComponent();
        }
        private int Id = -1;
      
        private void ClearFields()
        {
            txbCad.Clear();
            txbCadCode.Clear();
            txbTelefone.Clear();
            txbEmail.Clear();
            txbPassword.Clear();
            btnDel.Visible = false;
            btnUpdate.Visible = false;
        }

        private bool ValidateFields()
        {
            if (txbCadCode.Text.Length == 0 || txbPassword.Text.Length == 0)
            {
                MessageBox.Show("Os campos CRECI e Senha são obrigatórios", "ATENÇÃO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void UpdateListView()
        {
            ltvCad.Items.Clear();

            CadDAO cadDAO = new CadDAO();
            List<Cad> brokers = cadDAO.ListAllCads();

            //This code part access all brokers received from database and iterate by them.
            foreach (Cad broker in brokers)
            {
                //Creating a fully line of listview with items from database.
                ListViewItem item = new ListViewItem(cad.Id.ToString());
                item.SubItems.Add(cad.CadName);
                item.SubItems.Add(cad.CadCode);
                item.SubItems.Add(cad.Telefone);
                item.SubItems.Add(cad.Email);
                //Adding the fully line to the listview.
                ltvCad.Items.Add(item);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                try
                {
                    //Capture inputed text from fields.
                    if (new Cad().Insert(new Cad(
                        txbCad.Text, txbCadCode.Text, txbTelefone.Text, txbEmail.Text, txbPassword.Text)))
                        MessageBox.Show("Corretor cadastrado!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UpdateListView();
                ClearFields();
            }
        }

        private void Tela_Cadastro_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void ltvCad_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            try
            {
                index = ltvCad.FocusedItem.Index;
                Id = int.Parse(ltvCad.Items[index].SubItems[0].Text);
                txbCad.Text = ltvCad.Items[index].SubItems[1].Text;
                txbCadCode.Text = ltvCad.Items[index].SubItems[2].Text;
                txbTelefone.Text = ltvCad.Items[index].SubItems[5].Text;
                txbEmail.Text = ltvCad.Items[index].SubItems[5].Text;

                btnDel.Visible = true;
                btnUpdate.Visible = true;

            }

            catch (Exception)
            {
                MessageBox.Show("Você precisa selecionar uma linha", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CadDAO brokerDao = new CadDAO();

            DialogResult resultado = MessageBox.Show("Tem certeza" +
            " que deseja excluir?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    brokerDao.Del(Id);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UpdateListView();
                ClearFields();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                try
                {
                    //Capture inputed text from fields.
                    new CadDAO().Update(new Cad(Id, txbCad.Text, txbCadCode.Text, txbTelefone.Text, txbEmail.Text, txbPassword.Text));
                    MessageBox.Show("Corretor atualizado!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UpdateListView();
                ClearFields();
            }
        }
    }
}
    


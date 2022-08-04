using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetododeAutenticacao.Classes;

namespace MetododeAutenticacao.Desktop
{
    public partial class TelaNivel : Form
    {
        public TelaNivel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            NivelDAO nivel = new NivelDAO();
            MessageBox.Show(nivel.Inserir(txtNome.Text));
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            NivelDAO nivel = new NivelDAO();
            MessageBox.Show(nivel.Atualizar());

        }

        private void txtPesquisar_Click(object sender, EventArgs e)
        {
            NivelDAO nivel = new NivelDAO();
            dgvNivel.DataSource= nivel.PesquisarPorNome(txtNome.Text);
            
        }

        private void txtDeletar_Click(object sender, EventArgs e)
        {

            NivelDAO nivel = new NivelDAO();
            MessageBox.Show(nivel.Deletar(txtID.Text));//DELETAR USUARIO
            NivelDAO nivelQuery = new NivelDAO();
            dgvNivel.DataSource = nivelQuery.Pesquisar();

        }

        private void TelaNivel_Load(object sender, EventArgs e)
        {
            /*
            dgvNivel.DataSource = new NivelDAO().Pesquisar();
            */
            NivelDAO nivelQuery = new NivelDAO();
            dgvNivel.DataSource = nivelQuery.Pesquisar();
        }

        private void dgvNivel_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtID.Text = dgvNivel.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dgvNivel.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}

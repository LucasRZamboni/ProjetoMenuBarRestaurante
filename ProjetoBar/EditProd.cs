using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBar
{
    public partial class EditProd : Form
    {
        public EditProd()
        {
            InitializeComponent();
        }

        private void cadProdutosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cadProdutosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroProdutosDataSet);

        }

        private void EditProd_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroProdutosDataSet.CadProdutos'. Você pode movê-la ou removê-la conforme necessário.
            this.cadProdutosTableAdapter.Fill(this.cadastroProdutosDataSet.CadProdutos);


            cadProdutosDataGridView.Columns[0].Width = 50;
            cadProdutosDataGridView.Columns[0].HeaderText = "Código";
            cadProdutosDataGridView.Columns[1].Width = 150;
            cadProdutosDataGridView.Columns[1].HeaderText = "Produto";
            cadProdutosDataGridView.Columns[2].Width = 50;
            cadProdutosDataGridView.Columns[2].HeaderText = "Preço";
            cadProdutosDataGridView.Columns[3].Width = 150;
            cadProdutosDataGridView.Columns[3].HeaderText = "Quantidade";
            cadProdutosDataGridView.Columns[4].Width = 100;
            cadProdutosDataGridView.Columns[4].HeaderText = "Categoria";

        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            var menu2 = new Menu2();
            this.Hide();
            menu2.ShowDialog();
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

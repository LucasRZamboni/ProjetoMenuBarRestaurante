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
    public partial class CadastroProdutos : Form
    {

        
        public CadastroProdutos()
        {
            InitializeComponent();

        }

        

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            var menu2 = new Menu2();
            this.Hide();
            menu2.ShowDialog();
        }

       

        private void CadastroProdutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroProdutosDataSet.CadProdutos'. Você pode movê-la ou removê-la conforme necessário.
            this.cadProdutosTableAdapter.Fill(this.cadastroProdutosDataSet.CadProdutos);
            // TODO: esta linha de código carrega dados na tabela 'cadastroProdutosDataSet.CadProdutos'. Você pode movê-la ou removê-la conforme necessário.
            this.cadProdutosTableAdapter.Fill(this.cadastroProdutosDataSet.CadProdutos);

            tb_codigo.Clear();
            tb_produto.Clear();
            tb_preço.Clear();
            tb_quantidade.Clear();
            cb_categoria.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cadProdutosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroProdutosDataSet);

            MessageBox.Show("Produto salvo com sucesso!");
        }

        private void bt_adicionar_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = true;
        }

        private void cadProdutosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cadProdutosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroProdutosDataSet);

            MessageBox.Show("Produto salvo com sucesso!");

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;

namespace ProjetoBar
{
    public partial class Relatórios : Form
    {
        public Relatórios()
        {
            InitializeComponent();
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            var menu2 = new Menu2();
            this.Hide();
            menu2.ShowDialog();
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            var menu2 = new Menu2();
            this.Hide();
            menu2.ShowDialog();

        }

        private void loginBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loginBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseLoginDataSet);

        }

        private void Relatórios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroProdutosDataSet.CadProdutos'. Você pode movê-la ou removê-la conforme necessário.
            this.cadProdutosTableAdapter.Fill(this.cadastroProdutosDataSet.CadProdutos);
            // TODO: esta linha de código carrega dados na tabela 'cadastroProdutosDataSet.CadProdutos'. Você pode movê-la ou removê-la conforme necessário.
            this.cadProdutosTableAdapter.Fill(this.cadastroProdutosDataSet.CadProdutos);
            // TODO: esta linha de código carrega dados na tabela 'databaseLoginDataSet.Login'. Você pode movê-la ou removê-la conforme necessário.
            this.loginTableAdapter.Fill(this.databaseLoginDataSet.Login);


            cadProdutosDataGridView.Columns[0].Width = 50;
            cadProdutosDataGridView.Columns[0].HeaderText = "Código";
            cadProdutosDataGridView.Columns[1].Width = 150;
            cadProdutosDataGridView.Columns[1].HeaderText = "Produto";
            cadProdutosDataGridView.Columns[2].Width = 50;
            cadProdutosDataGridView.Columns[2].HeaderText = "Preço";
            cadProdutosDataGridView.Columns[3].Width = 50;
            cadProdutosDataGridView.Columns[3].HeaderText = "Quantidade";
            cadProdutosDataGridView.Columns[4].Width = 100;
            cadProdutosDataGridView.Columns[4].HeaderText = "Categoria";

            loginDataGridView.Columns[0].Width = 50;
            loginDataGridView.Columns[0].HeaderText = "ID";
            loginDataGridView.Columns[1].Width = 150;
            loginDataGridView.Columns[1].HeaderText = "Nome";
            loginDataGridView.Columns[2].Width = 100;
            loginDataGridView.Columns[2].HeaderText = "CPF";
            loginDataGridView.Columns[3].Width = 150;
            loginDataGridView.Columns[3].HeaderText = "Email";
            loginDataGridView.Columns[4].Width = 100;
            loginDataGridView.Columns[4].HeaderText = "Senha";

            maskedTextBox1.Clear();
          //  maskedTextBox1.Mask = @"000\.000\.000\-00";

        }
        //--------------------------------------MOVIMENTO DO APP NA AREA DE TRABALHO
        private bool mover;
        private int cX, cY;

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                mover = false;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                this.Left += e.X - (cX - panel1.Left);
                this.Top += e.Y - (cY - panel1.Top);
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                cX = e.X;
                cY = e.Y;
                mover = true;
            }
        }
        //--------------------------------------MOVIMENTO DO APP NA AREA DE TRABALHO
        private void salvarToolStripButton1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();

            if (loginDataGridView.Rows.Count > 0)
            {
                try
                {
                    XcelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < loginDataGridView.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = loginDataGridView.Columns[i - 1].HeaderText;
                    }
                    //
                    for (int i = 0; i < loginDataGridView.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < loginDataGridView.Columns.Count; j++)
                        {
                            XcelApp.Cells[i + 2, j + 1] = loginDataGridView.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    //
                    XcelApp.Columns.AutoFit();
                    //
                    XcelApp.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                    XcelApp.Quit();
                }
            }
        }

        private void bt_pesquisa_Click(object sender, EventArgs e)
        {
            string strcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\C#\ProjetoBar\CadastroProdutos.accdb";
            string comando = "SELECT * FROM CadProdutos WHERE categoria = @Categoria";

            
            OleDbConnection con = new OleDbConnection(strcon);
            OleDbCommand com = new OleDbCommand(comando, con);

            con.Open();

          //  com.Parameters.AddWithValue("@codigo", OleDbType.Integer).Value = tb_codigo.Text;
         //   com.Parameters.Add("@produto", OleDbType.VarChar).Value = tb_produto.Text;
            com.Parameters.AddWithValue("@categoria", OleDbType.VarChar).Value = tb_categoria.Text;


            com.ExecuteNonQuery();

            try
            {

                if (tb_categoria.Text == "")
                {
                    throw new Exception("Escolha uma das opções e digite o que deseja pesquisar");
                }

                
                else
                {
                   
                    OleDbDataAdapter dados = new OleDbDataAdapter(com);
                    DataSet tabela = new DataSet();
                    dados.Fill(tabela);

                    cadProdutosDataGridView.DataSource = tabela.Tables[0];

                    
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                con.Dispose();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\C#\ProjetoBar\DatabaseLogin.accdb";
            string comando = "SELECT * FROM Login WHERE cpf = @CPF";


            OleDbConnection con = new OleDbConnection(strcon);
            OleDbCommand com = new OleDbCommand(comando, con);

            con.Open();

            
            com.Parameters.AddWithValue("@cpf", OleDbType.VarChar).Value = maskedTextBox1.Text;


            com.ExecuteNonQuery();

            try
            {

                if (maskedTextBox1.Text == string.Empty)
                {
                    MessageBox.Show("Necessário digitar CPF para filtrar");

                    
                }


                else
                {

                    OleDbDataAdapter dados = new OleDbDataAdapter(com);
                    DataSet tabela = new DataSet();
                    dados.Fill(tabela);

                    loginDataGridView.DataSource = tabela.Tables[0];




                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();

            if (cadProdutosDataGridView.Rows.Count > 0)
            {
                try
                {
                    XcelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < cadProdutosDataGridView.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = cadProdutosDataGridView.Columns[i - 1].HeaderText;
                    }
                    //
                    for (int i = 0; i < cadProdutosDataGridView.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < cadProdutosDataGridView.Columns.Count; j++)
                        {
                            XcelApp.Cells[i + 2, j + 1] = cadProdutosDataGridView.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    //
                    XcelApp.Columns.AutoFit();
                    //
                    XcelApp.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                    XcelApp.Quit();
                }
            }
        }
    }
}

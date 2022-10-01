
namespace ProjetoBar
{
    partial class CadastroProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label códigoLabel;
            System.Windows.Forms.Label produtoLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label preçoLabel1;
            System.Windows.Forms.Label categoriaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroProdutos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_preço = new System.Windows.Forms.TextBox();
            this.cadProdutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroProdutosDataSet = new ProjetoBar.CadastroProdutosDataSet();
            this.cb_categoria = new System.Windows.Forms.ComboBox();
            this.cadProdutosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.cadProdutosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.tb_produto = new System.Windows.Forms.TextBox();
            this.tb_quantidade = new System.Windows.Forms.TextBox();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.bt_voltar = new System.Windows.Forms.Button();
            this.cadProdutosTableAdapter = new ProjetoBar.CadastroProdutosDataSetTableAdapters.CadProdutosTableAdapter();
            this.tableAdapterManager = new ProjetoBar.CadastroProdutosDataSetTableAdapters.TableAdapterManager();
            códigoLabel = new System.Windows.Forms.Label();
            produtoLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            preçoLabel1 = new System.Windows.Forms.Label();
            categoriaLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadProdutosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroProdutosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadProdutosBindingNavigator)).BeginInit();
            this.cadProdutosBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // códigoLabel
            // 
            códigoLabel.AutoSize = true;
            códigoLabel.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            códigoLabel.Location = new System.Drawing.Point(50, 56);
            códigoLabel.Name = "códigoLabel";
            códigoLabel.Size = new System.Drawing.Size(119, 33);
            códigoLabel.TabIndex = 74;
            códigoLabel.Text = "Código:";
            // 
            // produtoLabel
            // 
            produtoLabel.AutoSize = true;
            produtoLabel.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            produtoLabel.Location = new System.Drawing.Point(137, 151);
            produtoLabel.Name = "produtoLabel";
            produtoLabel.Size = new System.Drawing.Size(134, 33);
            produtoLabel.TabIndex = 76;
            produtoLabel.Text = "Produto:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantidadeLabel.Location = new System.Drawing.Point(90, 286);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(181, 33);
            quantidadeLabel.TabIndex = 80;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // preçoLabel1
            // 
            preçoLabel1.AutoSize = true;
            preçoLabel1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            preçoLabel1.Location = new System.Drawing.Point(169, 219);
            preçoLabel1.Name = "preçoLabel1";
            preçoLabel1.Size = new System.Drawing.Size(102, 33);
            preçoLabel1.TabIndex = 82;
            preçoLabel1.Text = "Preço:";
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoriaLabel.Location = new System.Drawing.Point(115, 351);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(156, 33);
            categoriaLabel.TabIndex = 83;
            categoriaLabel.Text = "Categoria:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_preço);
            this.panel1.Controls.Add(categoriaLabel);
            this.panel1.Controls.Add(this.cb_categoria);
            this.panel1.Controls.Add(preçoLabel1);
            this.panel1.Controls.Add(this.cadProdutosBindingNavigator);
            this.panel1.Controls.Add(códigoLabel);
            this.panel1.Controls.Add(this.tb_codigo);
            this.panel1.Controls.Add(produtoLabel);
            this.panel1.Controls.Add(this.tb_produto);
            this.panel1.Controls.Add(quantidadeLabel);
            this.panel1.Controls.Add(this.tb_quantidade);
            this.panel1.Controls.Add(this.bt_fechar);
            this.panel1.Controls.Add(this.bt_voltar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 513);
            this.panel1.TabIndex = 0;
            // 
            // tb_preço
            // 
            this.tb_preço.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadProdutosBindingSource, "Preço", true));
            this.tb_preço.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_preço.Location = new System.Drawing.Point(277, 219);
            this.tb_preço.Name = "tb_preço";
            this.tb_preço.Size = new System.Drawing.Size(262, 38);
            this.tb_preço.TabIndex = 85;
            // 
            // cadProdutosBindingSource
            // 
            this.cadProdutosBindingSource.DataMember = "CadProdutos";
            this.cadProdutosBindingSource.DataSource = this.cadastroProdutosDataSet;
            // 
            // cadastroProdutosDataSet
            // 
            this.cadastroProdutosDataSet.DataSetName = "CadastroProdutosDataSet";
            this.cadastroProdutosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cb_categoria
            // 
            this.cb_categoria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadProdutosBindingSource, "Categoria", true));
            this.cb_categoria.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_categoria.FormattingEnabled = true;
            this.cb_categoria.Items.AddRange(new object[] {
            "Refrigerante",
            "Prato",
            "Cerveja",
            "Porção",
            "Drink",
            ""});
            this.cb_categoria.Location = new System.Drawing.Point(277, 348);
            this.cb_categoria.Name = "cb_categoria";
            this.cb_categoria.Size = new System.Drawing.Size(262, 41);
            this.cb_categoria.TabIndex = 84;
            // 
            // cadProdutosBindingNavigator
            // 
            this.cadProdutosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cadProdutosBindingNavigator.BindingSource = this.cadProdutosBindingSource;
            this.cadProdutosBindingNavigator.CountItem = null;
            this.cadProdutosBindingNavigator.DeleteItem = null;
            this.cadProdutosBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.cadProdutosBindingNavigator.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.cadProdutosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.cadProdutosBindingNavigatorSaveItem});
            this.cadProdutosBindingNavigator.Location = new System.Drawing.Point(356, 429);
            this.cadProdutosBindingNavigator.MoveFirstItem = null;
            this.cadProdutosBindingNavigator.MoveLastItem = null;
            this.cadProdutosBindingNavigator.MoveNextItem = null;
            this.cadProdutosBindingNavigator.MovePreviousItem = null;
            this.cadProdutosBindingNavigator.Name = "cadProdutosBindingNavigator";
            this.cadProdutosBindingNavigator.PositionItem = null;
            this.cadProdutosBindingNavigator.Size = new System.Drawing.Size(100, 47);
            this.cadProdutosBindingNavigator.TabIndex = 1;
            this.cadProdutosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // cadProdutosBindingNavigatorSaveItem
            // 
            this.cadProdutosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cadProdutosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cadProdutosBindingNavigatorSaveItem.Image")));
            this.cadProdutosBindingNavigatorSaveItem.Name = "cadProdutosBindingNavigatorSaveItem";
            this.cadProdutosBindingNavigatorSaveItem.Size = new System.Drawing.Size(44, 44);
            this.cadProdutosBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.cadProdutosBindingNavigatorSaveItem.Click += new System.EventHandler(this.cadProdutosBindingNavigatorSaveItem_Click);
            // 
            // tb_codigo
            // 
            this.tb_codigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadProdutosBindingSource, "Código", true));
            this.tb_codigo.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_codigo.Location = new System.Drawing.Point(175, 53);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(96, 40);
            this.tb_codigo.TabIndex = 75;
            // 
            // tb_produto
            // 
            this.tb_produto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadProdutosBindingSource, "Produto", true));
            this.tb_produto.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_produto.Location = new System.Drawing.Point(277, 148);
            this.tb_produto.Name = "tb_produto";
            this.tb_produto.Size = new System.Drawing.Size(262, 40);
            this.tb_produto.TabIndex = 77;
            // 
            // tb_quantidade
            // 
            this.tb_quantidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadProdutosBindingSource, "Quantidade", true));
            this.tb_quantidade.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_quantidade.Location = new System.Drawing.Point(277, 283);
            this.tb_quantidade.Name = "tb_quantidade";
            this.tb_quantidade.Size = new System.Drawing.Size(262, 40);
            this.tb_quantidade.TabIndex = 81;
            // 
            // bt_fechar
            // 
            this.bt_fechar.BackColor = System.Drawing.Color.Transparent;
            this.bt_fechar.BackgroundImage = global::ProjetoBar.Properties.Resources._01;
            this.bt_fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_fechar.ForeColor = System.Drawing.Color.Transparent;
            this.bt_fechar.Location = new System.Drawing.Point(656, 3);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(32, 22);
            this.bt_fechar.TabIndex = 73;
            this.bt_fechar.UseVisualStyleBackColor = false;
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            // 
            // bt_voltar
            // 
            this.bt_voltar.BackColor = System.Drawing.Color.Transparent;
            this.bt_voltar.BackgroundImage = global::ProjetoBar.Properties.Resources._28;
            this.bt_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_voltar.ForeColor = System.Drawing.Color.Transparent;
            this.bt_voltar.Location = new System.Drawing.Point(3, 3);
            this.bt_voltar.Name = "bt_voltar";
            this.bt_voltar.Size = new System.Drawing.Size(32, 22);
            this.bt_voltar.TabIndex = 74;
            this.bt_voltar.UseVisualStyleBackColor = false;
            this.bt_voltar.Click += new System.EventHandler(this.bt_voltar_Click);
            // 
            // cadProdutosTableAdapter
            // 
            this.cadProdutosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CadProdutosTableAdapter = this.cadProdutosTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProjetoBar.CadastroProdutosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // CadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(691, 513);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroProdutos";
            this.Load += new System.EventHandler(this.CadastroProdutos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadProdutosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroProdutosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadProdutosBindingNavigator)).EndInit();
            this.cadProdutosBindingNavigator.ResumeLayout(false);
            this.cadProdutosBindingNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_fechar;
        private System.Windows.Forms.Button bt_voltar;
        private CadastroProdutosDataSet cadastroProdutosDataSet;
        private System.Windows.Forms.BindingSource cadProdutosBindingSource;
        private CadastroProdutosDataSetTableAdapters.CadProdutosTableAdapter cadProdutosTableAdapter;
        private CadastroProdutosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cadProdutosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton cadProdutosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.TextBox tb_produto;
        private System.Windows.Forms.TextBox tb_quantidade;
        private System.Windows.Forms.ComboBox cb_categoria;
        private System.Windows.Forms.TextBox tb_preço;
    }
}
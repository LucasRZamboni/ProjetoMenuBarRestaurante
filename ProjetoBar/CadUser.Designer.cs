
namespace ProjetoBar
{
    partial class CadUser
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label e_mailLabel;
            System.Windows.Forms.Label senhaLabel;
            System.Windows.Forms.Label cPFLabel1;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_voltar = new System.Windows.Forms.Button();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseLoginDataSet = new ProjetoBar.DatabaseLoginDataSet();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.mtb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.loginBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.loginTableAdapter = new ProjetoBar.DatabaseLoginDataSetTableAdapters.LoginTableAdapter();
            this.tableAdapterManager = new ProjetoBar.DatabaseLoginDataSetTableAdapters.TableAdapterManager();
            iDLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            e_mailLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            cPFLabel1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseLoginDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingNavigator)).BeginInit();
            this.loginBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDLabel.Location = new System.Drawing.Point(19, 35);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(41, 25);
            iDLabel.TabIndex = 0;
            iDLabel.Text = "ID:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(100, 134);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(79, 25);
            nomeLabel.TabIndex = 2;
            nomeLabel.Text = "Nome:";
            // 
            // e_mailLabel
            // 
            e_mailLabel.AutoSize = true;
            e_mailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            e_mailLabel.Location = new System.Drawing.Point(95, 225);
            e_mailLabel.Name = "e_mailLabel";
            e_mailLabel.Size = new System.Drawing.Size(85, 25);
            e_mailLabel.TabIndex = 6;
            e_mailLabel.Text = "E-mail:";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            senhaLabel.Location = new System.Drawing.Point(94, 272);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(86, 25);
            senhaLabel.TabIndex = 8;
            senhaLabel.Text = "Senha:";
            // 
            // cPFLabel1
            // 
            cPFLabel1.AutoSize = true;
            cPFLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cPFLabel1.Location = new System.Drawing.Point(116, 180);
            cPFLabel1.Name = "cPFLabel1";
            cPFLabel1.Size = new System.Drawing.Size(64, 25);
            cPFLabel1.TabIndex = 11;
            cPFLabel1.Text = "CPF:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(101, 134);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(79, 25);
            label3.TabIndex = 2;
            label3.Text = "Nome:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_voltar);
            this.panel1.Controls.Add(this.bt_fechar);
            this.panel1.Controls.Add(this.tb_id);
            this.panel1.Controls.Add(this.tb_senha);
            this.panel1.Controls.Add(this.tb_email);
            this.panel1.Controls.Add(this.mtb_cpf);
            this.panel1.Controls.Add(this.tb_nome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(cPFLabel1);
            this.panel1.Controls.Add(this.loginBindingNavigator);
            this.panel1.Controls.Add(iDLabel);
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(nomeLabel);
            this.panel1.Controls.Add(e_mailLabel);
            this.panel1.Controls.Add(senhaLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 420);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
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
            this.bt_voltar.TabIndex = 75;
            this.bt_voltar.UseVisualStyleBackColor = false;
            this.bt_voltar.Click += new System.EventHandler(this.bt_voltar_Click);
            // 
            // bt_fechar
            // 
            this.bt_fechar.BackColor = System.Drawing.Color.Transparent;
            this.bt_fechar.BackgroundImage = global::ProjetoBar.Properties.Resources._01;
            this.bt_fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_fechar.ForeColor = System.Drawing.Color.Transparent;
            this.bt_fechar.Location = new System.Drawing.Point(636, 3);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(32, 22);
            this.bt_fechar.TabIndex = 72;
            this.bt_fechar.UseVisualStyleBackColor = false;
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            // 
            // tb_id
            // 
            this.tb_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource, "ID", true));
            this.tb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(66, 32);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(55, 31);
            this.tb_id.TabIndex = 18;
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "Login";
            this.loginBindingSource.DataSource = this.databaseLoginDataSet;
            // 
            // databaseLoginDataSet
            // 
            this.databaseLoginDataSet.DataSetName = "DatabaseLoginDataSet";
            this.databaseLoginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_senha
            // 
            this.tb_senha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource, "Senha", true));
            this.tb_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_senha.Location = new System.Drawing.Point(186, 269);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(273, 31);
            this.tb_senha.TabIndex = 17;
            // 
            // tb_email
            // 
            this.tb_email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource, "Email", true));
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(186, 222);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(363, 31);
            this.tb_email.TabIndex = 16;
            // 
            // mtb_cpf
            // 
            this.mtb_cpf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource, "CPF", true));
            this.mtb_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_cpf.Location = new System.Drawing.Point(186, 177);
            this.mtb_cpf.Name = "mtb_cpf";
            this.mtb_cpf.Size = new System.Drawing.Size(289, 31);
            this.mtb_cpf.TabIndex = 15;
            // 
            // tb_nome
            // 
            this.tb_nome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource, "Nome", true));
            this.tb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nome.Location = new System.Drawing.Point(185, 131);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(364, 31);
            this.tb_nome.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cadastro de Login";
            // 
            // loginBindingNavigator
            // 
            this.loginBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.loginBindingNavigator.BindingSource = this.loginBindingSource;
            this.loginBindingNavigator.CountItem = null;
            this.loginBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.loginBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.loginBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.loginBindingNavigator.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.loginBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator1,
            this.loginBindingNavigatorSaveItem});
            this.loginBindingNavigator.Location = new System.Drawing.Point(267, 353);
            this.loginBindingNavigator.MoveFirstItem = null;
            this.loginBindingNavigator.MoveLastItem = null;
            this.loginBindingNavigator.MoveNextItem = null;
            this.loginBindingNavigator.MovePreviousItem = null;
            this.loginBindingNavigator.Name = "loginBindingNavigator";
            this.loginBindingNavigator.PositionItem = null;
            this.loginBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.loginBindingNavigator.Size = new System.Drawing.Size(147, 47);
            this.loginBindingNavigator.TabIndex = 1;
            this.loginBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = global::ProjetoBar.Properties.Resources._01;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // loginBindingNavigatorSaveItem
            // 
            this.loginBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.loginBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("loginBindingNavigatorSaveItem.Image")));
            this.loginBindingNavigatorSaveItem.Name = "loginBindingNavigatorSaveItem";
            this.loginBindingNavigatorSaveItem.Size = new System.Drawing.Size(44, 44);
            this.loginBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.loginBindingNavigatorSaveItem.Click += new System.EventHandler(this.loginBindingNavigatorSaveItem_Click);
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LoginTableAdapter = this.loginTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProjetoBar.DatabaseLoginDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // CadUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 420);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadUser";
            this.Load += new System.EventHandler(this.CadUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseLoginDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingNavigator)).EndInit();
            this.loginBindingNavigator.ResumeLayout(false);
            this.loginBindingNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DatabaseLoginDataSet databaseLoginDataSet;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private DatabaseLoginDataSetTableAdapters.LoginTableAdapter loginTableAdapter;
        private DatabaseLoginDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator loginBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton loginBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.MaskedTextBox mtb_cpf;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Button bt_fechar;
        private System.Windows.Forms.Button bt_voltar;
    }
}
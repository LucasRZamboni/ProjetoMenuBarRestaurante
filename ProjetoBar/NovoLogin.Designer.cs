
namespace ProjetoBar
{
    partial class NovoLogin
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
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label e_mailLabel;
            System.Windows.Forms.Label senhaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovoLogin));
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseLoginDataSet = new ProjetoBar.DatabaseLoginDataSet();
            this.loginTableAdapter = new ProjetoBar.DatabaseLoginDataSetTableAdapters.LoginTableAdapter();
            this.tableAdapterManager = new ProjetoBar.DatabaseLoginDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtb_dica = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_novologin = new System.Windows.Forms.CheckBox();
            this.mtb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.loginBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.loginBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            iDLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            e_mailLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseLoginDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingNavigator)).BeginInit();
            this.loginBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDLabel.Location = new System.Drawing.Point(42, 44);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(27, 16);
            iDLabel.TabIndex = 2;
            iDLabel.Text = "ID:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(193, 148);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(48, 16);
            nomeLabel.TabIndex = 4;
            nomeLabel.Text = "Nome:";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cPFLabel.Location = new System.Drawing.Point(205, 115);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(35, 16);
            cPFLabel.TabIndex = 6;
            cPFLabel.Text = "CPF:";
            // 
            // e_mailLabel
            // 
            e_mailLabel.AutoSize = true;
            e_mailLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            e_mailLabel.Location = new System.Drawing.Point(189, 77);
            e_mailLabel.Name = "e_mailLabel";
            e_mailLabel.Size = new System.Drawing.Size(51, 16);
            e_mailLabel.TabIndex = 8;
            e_mailLabel.Text = "E-mail:";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            senhaLabel.Location = new System.Drawing.Point(187, 174);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(53, 16);
            senhaLabel.TabIndex = 10;
            senhaLabel.Text = "Senha:";
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
            // panel1
            // 
            this.panel1.BackgroundImage = global::ProjetoBar.Properties.Resources.neon_2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.rtb_dica);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cb_novologin);
            this.panel1.Controls.Add(this.mtb_cpf);
            this.panel1.Controls.Add(this.bt_fechar);
            this.panel1.Controls.Add(this.loginBindingNavigator);
            this.panel1.Controls.Add(iDLabel);
            this.panel1.Controls.Add(this.tb_id);
            this.panel1.Controls.Add(nomeLabel);
            this.panel1.Controls.Add(this.tb_nome);
            this.panel1.Controls.Add(cPFLabel);
            this.panel1.Controls.Add(e_mailLabel);
            this.panel1.Controls.Add(this.tb_email);
            this.panel1.Controls.Add(senhaLabel);
            this.panel1.Controls.Add(this.tb_senha);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 264);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // rtb_dica
            // 
            this.rtb_dica.Location = new System.Drawing.Point(30, 103);
            this.rtb_dica.Name = "rtb_dica";
            this.rtb_dica.Size = new System.Drawing.Size(316, 143);
            this.rtb_dica.TabIndex = 72;
            this.rtb_dica.Text = "Para criar um login é necessário clicar no botão + (Mais).\n\nAssinalar \"Novo login" +
    "\" para criar mais de um login.\n\nTodos os campos devem ser preenchidos.\n\n\n\nPara f" +
    "echar a dica, clicar nesta janela.\n";
            this.rtb_dica.Visible = false;
            this.rtb_dica.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rtb_dica_MouseClick);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ProjetoBar.Properties.Resources.neon_31;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Image = global::ProjetoBar.Properties.Resources._43;
            this.button1.Location = new System.Drawing.Point(3, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 33);
            this.button1.TabIndex = 7;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_novologin
            // 
            this.cb_novologin.AutoSize = true;
            this.cb_novologin.Location = new System.Drawing.Point(246, 204);
            this.cb_novologin.Name = "cb_novologin";
            this.cb_novologin.Size = new System.Drawing.Size(77, 17);
            this.cb_novologin.TabIndex = 5;
            this.cb_novologin.Text = "Novo login";
            this.cb_novologin.UseVisualStyleBackColor = true;
            // 
            // mtb_cpf
            // 
            this.mtb_cpf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource, "CPF", true));
            this.mtb_cpf.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_cpf.Location = new System.Drawing.Point(246, 113);
            this.mtb_cpf.Name = "mtb_cpf";
            this.mtb_cpf.Size = new System.Drawing.Size(100, 22);
            this.mtb_cpf.TabIndex = 2;
            // 
            // bt_fechar
            // 
            this.bt_fechar.BackColor = System.Drawing.Color.Black;
            this.bt_fechar.BackgroundImage = global::ProjetoBar.Properties.Resources._01;
            this.bt_fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_fechar.ForeColor = System.Drawing.Color.Transparent;
            this.bt_fechar.Location = new System.Drawing.Point(463, 3);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(32, 22);
            this.bt_fechar.TabIndex = 6;
            this.bt_fechar.UseVisualStyleBackColor = false;
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            // 
            // loginBindingNavigator
            // 
            this.loginBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.loginBindingNavigator.BindingSource = this.loginBindingSource;
            this.loginBindingNavigator.CountItem = null;
            this.loginBindingNavigator.DeleteItem = null;
            this.loginBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.loginBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.loginBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.toolStripSeparator1,
            this.loginBindingNavigatorSaveItem});
            this.loginBindingNavigator.Location = new System.Drawing.Point(373, 204);
            this.loginBindingNavigator.MoveFirstItem = null;
            this.loginBindingNavigator.MoveLastItem = null;
            this.loginBindingNavigator.MoveNextItem = null;
            this.loginBindingNavigator.MovePreviousItem = null;
            this.loginBindingNavigator.Name = "loginBindingNavigator";
            this.loginBindingNavigator.PositionItem = null;
            this.loginBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.loginBindingNavigator.Size = new System.Drawing.Size(55, 25);
            this.loginBindingNavigator.TabIndex = 1;
            this.loginBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // loginBindingNavigatorSaveItem
            // 
            this.loginBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.loginBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("loginBindingNavigatorSaveItem.Image")));
            this.loginBindingNavigatorSaveItem.Name = "loginBindingNavigatorSaveItem";
            this.loginBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.loginBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.loginBindingNavigatorSaveItem.Click += new System.EventHandler(this.loginBindingNavigatorSaveItem_Click);
            // 
            // tb_id
            // 
            this.tb_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource, "ID", true));
            this.tb_id.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(75, 42);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(37, 22);
            this.tb_id.TabIndex = 3;
            this.tb_id.TabStop = false;
            // 
            // tb_nome
            // 
            this.tb_nome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource, "Nome", true));
            this.tb_nome.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nome.Location = new System.Drawing.Point(246, 146);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(120, 22);
            this.tb_nome.TabIndex = 3;
            // 
            // tb_email
            // 
            this.tb_email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource, "Email", true));
            this.tb_email.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(246, 75);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(170, 22);
            this.tb_email.TabIndex = 1;
            // 
            // tb_senha
            // 
            this.tb_senha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource, "Senha", true));
            this.tb_senha.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_senha.Location = new System.Drawing.Point(246, 172);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(120, 22);
            this.tb_senha.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Novo Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoBar.Properties.Resources._111_1114675_user_login_person_man_enter_person_login_icon_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(49, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // NovoLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 264);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NovoLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NovoLogin";
            this.Load += new System.EventHandler(this.NovoLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseLoginDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingNavigator)).EndInit();
            this.loginBindingNavigator.ResumeLayout(false);
            this.loginBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private DatabaseLoginDataSet databaseLoginDataSet;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private DatabaseLoginDataSetTableAdapters.LoginTableAdapter loginTableAdapter;
        private DatabaseLoginDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator loginBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton loginBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Button bt_fechar;
        private System.Windows.Forms.MaskedTextBox mtb_cpf;
        private System.Windows.Forms.CheckBox cb_novologin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtb_dica;
    }
}
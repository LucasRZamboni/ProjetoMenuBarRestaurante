
namespace ProjetoBar
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.ErroProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_versenha = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.cb_novologin = new System.Windows.Forms.CheckBox();
            this.bt_entrar = new System.Windows.Forms.Button();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_restrito = new System.Windows.Forms.CheckBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MostrarOcultar = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pb_login1 = new System.Windows.Forms.PictureBox();
            this.pb_login2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErroProvider)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login2)).BeginInit();
            this.SuspendLayout();
            // 
            // ErroProvider
            // 
            this.ErroProvider.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cb_versenha);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bt_cancelar);
            this.panel1.Controls.Add(this.cb_novologin);
            this.panel1.Controls.Add(this.bt_entrar);
            this.panel1.Controls.Add(this.tb_login);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cb_restrito);
            this.panel1.Controls.Add(this.tb_senha);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.MostrarOcultar);
            this.panel1.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel1.Controls.Add(this.pb_login1);
            this.panel1.Controls.Add(this.pb_login2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 347);
            this.panel1.TabIndex = 71;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // cb_versenha
            // 
            this.cb_versenha.AutoSize = true;
            this.cb_versenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cb_versenha.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_versenha.Location = new System.Drawing.Point(378, 227);
            this.cb_versenha.Name = "cb_versenha";
            this.cb_versenha.Size = new System.Drawing.Size(15, 14);
            this.cb_versenha.TabIndex = 66;
            this.cb_versenha.UseVisualStyleBackColor = true;
            this.cb_versenha.CheckedChanged += new System.EventHandler(this.cb_versenha_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chartreuse;
            this.label1.Location = new System.Drawing.Point(318, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "LOGIN";
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_cancelar.BackgroundImage")));
            this.bt_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_cancelar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.ForeColor = System.Drawing.Color.GreenYellow;
            this.bt_cancelar.Location = new System.Drawing.Point(367, 269);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(82, 42);
            this.bt_cancelar.TabIndex = 70;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // cb_novologin
            // 
            this.cb_novologin.AutoSize = true;
            this.cb_novologin.BackColor = System.Drawing.Color.Transparent;
            this.cb_novologin.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_novologin.ForeColor = System.Drawing.Color.Chartreuse;
            this.cb_novologin.Location = new System.Drawing.Point(297, 250);
            this.cb_novologin.Name = "cb_novologin";
            this.cb_novologin.Size = new System.Drawing.Size(79, 15);
            this.cb_novologin.TabIndex = 71;
            this.cb_novologin.Text = "Novo Login";
            this.cb_novologin.UseVisualStyleBackColor = false;
            // 
            // bt_entrar
            // 
            this.bt_entrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_entrar.BackgroundImage")));
            this.bt_entrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_entrar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_entrar.ForeColor = System.Drawing.Color.GreenYellow;
            this.bt_entrar.Location = new System.Drawing.Point(275, 269);
            this.bt_entrar.Name = "bt_entrar";
            this.bt_entrar.Size = new System.Drawing.Size(82, 42);
            this.bt_entrar.TabIndex = 69;
            this.bt_entrar.Text = "Entrar";
            this.bt_entrar.UseVisualStyleBackColor = true;
            this.bt_entrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(297, 192);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(149, 20);
            this.tb_login.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Chartreuse;
            this.label2.Location = new System.Drawing.Point(248, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "E-mail";
            // 
            // cb_restrito
            // 
            this.cb_restrito.AutoSize = true;
            this.cb_restrito.BackColor = System.Drawing.Color.Transparent;
            this.cb_restrito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_restrito.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_restrito.ForeColor = System.Drawing.Color.Chartreuse;
            this.cb_restrito.Location = new System.Drawing.Point(396, 315);
            this.cb_restrito.Name = "cb_restrito";
            this.cb_restrito.Size = new System.Drawing.Size(53, 15);
            this.cb_restrito.TabIndex = 72;
            this.cb_restrito.Text = "Restrito";
            this.cb_restrito.UseVisualStyleBackColor = false;
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(297, 224);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.Size = new System.Drawing.Size(99, 20);
            this.tb_senha.TabIndex = 4;
            this.tb_senha.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Chartreuse;
            this.label3.Location = new System.Drawing.Point(246, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha";
            // 
            // MostrarOcultar
            // 
            this.MostrarOcultar.AutoSize = true;
            this.MostrarOcultar.BackColor = System.Drawing.Color.Transparent;
            this.MostrarOcultar.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostrarOcultar.ForeColor = System.Drawing.Color.Chartreuse;
            this.MostrarOcultar.Location = new System.Drawing.Point(397, 230);
            this.MostrarOcultar.Name = "MostrarOcultar";
            this.MostrarOcultar.Size = new System.Drawing.Size(35, 10);
            this.MostrarOcultar.TabIndex = 68;
            this.MostrarOcultar.Text = "Mostrar";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, -5);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(458, 442);
            this.axWindowsMediaPlayer1.TabIndex = 73;
            // 
            // pb_login1
            // 
            this.pb_login1.BackColor = System.Drawing.Color.Transparent;
            this.pb_login1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_login1.Image = global::ProjetoBar.Properties.Resources.Pixaloop_08_06_2022_22_01_09_76600001;
            this.pb_login1.Location = new System.Drawing.Point(0, 0);
            this.pb_login1.Name = "pb_login1";
            this.pb_login1.Size = new System.Drawing.Size(458, 347);
            this.pb_login1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_login1.TabIndex = 0;
            this.pb_login1.TabStop = false;
            // 
            // pb_login2
            // 
            this.pb_login2.BackColor = System.Drawing.Color.Transparent;
            this.pb_login2.Image = global::ProjetoBar.Properties.Resources._37_373951_login_logo_de_login_removebg_preview;
            this.pb_login2.Location = new System.Drawing.Point(154, 57);
            this.pb_login2.Name = "pb_login2";
            this.pb_login2.Size = new System.Drawing.Size(151, 143);
            this.pb_login2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_login2.TabIndex = 1;
            this.pb_login2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Chartreuse;
            this.label4.Location = new System.Drawing.Point(5, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 74;
            this.label4.Text = "Created By:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Chartreuse;
            this.label5.Location = new System.Drawing.Point(5, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 10);
            this.label5.TabIndex = 75;
            this.label5.Text = "Lucas Zamboni";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Chartreuse;
            this.label6.Location = new System.Drawing.Point(5, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 10);
            this.label6.TabIndex = 76;
            this.label6.Text = "Tiago Massuia";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoBar.Properties.Resources.Pixaloop_08_06_2022_22_01_09_76600001;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(458, 347);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErroProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_login2;
        private System.Windows.Forms.PictureBox pb_login1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MostrarOcultar;
        private System.Windows.Forms.CheckBox cb_versenha;
        private System.Windows.Forms.Button bt_entrar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider ErroProvider;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox cb_novologin;
        private System.Windows.Forms.CheckBox cb_restrito;
        public AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}


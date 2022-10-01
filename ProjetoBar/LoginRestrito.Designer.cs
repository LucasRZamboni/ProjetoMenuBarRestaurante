
namespace ProjetoBar
{
    partial class LoginRestrito
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_entrar = new System.Windows.Forms.Button();
            this.pb_login2 = new System.Windows.Forms.PictureBox();
            this.MostrarOcultar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.cb_versenha = new System.Windows.Forms.CheckBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ErroProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErroProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BackgroundImage = global::ProjetoBar.Properties.Resources._3275396_vazio_podium_with_line_gradiente_neon_square_frame_vetor2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bt_cancelar);
            this.panel1.Controls.Add(this.bt_entrar);
            this.panel1.Controls.Add(this.pb_login2);
            this.panel1.Controls.Add(this.MostrarOcultar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_login);
            this.panel1.Controls.Add(this.cb_versenha);
            this.panel1.Controls.Add(this.tb_senha);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 386);
            this.panel1.TabIndex = 72;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProjetoBar.Properties.Resources._37_373951_login_logo_de_login_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(53, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt_cancelar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.Location = new System.Drawing.Point(142, 342);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(75, 23);
            this.bt_cancelar.TabIndex = 70;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // bt_entrar
            // 
            this.bt_entrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt_entrar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_entrar.Location = new System.Drawing.Point(41, 342);
            this.bt_entrar.Name = "bt_entrar";
            this.bt_entrar.Size = new System.Drawing.Size(75, 23);
            this.bt_entrar.TabIndex = 69;
            this.bt_entrar.Text = "Entrar";
            this.bt_entrar.UseVisualStyleBackColor = true;
            this.bt_entrar.Click += new System.EventHandler(this.bt_entrar_Click);
            // 
            // pb_login2
            // 
            this.pb_login2.BackColor = System.Drawing.Color.Transparent;
            this.pb_login2.Image = global::ProjetoBar.Properties.Resources.istockphoto_1072514576_170667a_removebg_preview;
            this.pb_login2.Location = new System.Drawing.Point(53, 72);
            this.pb_login2.Name = "pb_login2";
            this.pb_login2.Size = new System.Drawing.Size(151, 143);
            this.pb_login2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_login2.TabIndex = 1;
            this.pb_login2.TabStop = false;
            // 
            // MostrarOcultar
            // 
            this.MostrarOcultar.AutoSize = true;
            this.MostrarOcultar.BackColor = System.Drawing.Color.Transparent;
            this.MostrarOcultar.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostrarOcultar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MostrarOcultar.Location = new System.Drawing.Point(185, 296);
            this.MostrarOcultar.Name = "MostrarOcultar";
            this.MostrarOcultar.Size = new System.Drawing.Size(32, 10);
            this.MostrarOcultar.TabIndex = 68;
            this.MostrarOcultar.Text = "Mostrar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(50, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Restricted";
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(81, 255);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(100, 20);
            this.tb_login.TabIndex = 3;
            // 
            // cb_versenha
            // 
            this.cb_versenha.AutoSize = true;
            this.cb_versenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cb_versenha.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_versenha.Location = new System.Drawing.Point(164, 293);
            this.cb_versenha.Name = "cb_versenha";
            this.cb_versenha.Size = new System.Drawing.Size(15, 14);
            this.cb_versenha.TabIndex = 66;
            this.cb_versenha.UseVisualStyleBackColor = true;
            this.cb_versenha.CheckedChanged += new System.EventHandler(this.cb_versenha_CheckedChanged);
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(81, 290);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.Size = new System.Drawing.Size(100, 20);
            this.tb_senha.TabIndex = 4;
            this.tb_senha.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(33, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(38, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Login";
            // 
            // ErroProvider
            // 
            this.ErroProvider.ContainerControl = this;
            // 
            // LoginRestrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 386);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginRestrito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginRestrito";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErroProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_entrar;
        private System.Windows.Forms.PictureBox pb_login2;
        private System.Windows.Forms.Label MostrarOcultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.CheckBox cb_versenha;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider ErroProvider;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
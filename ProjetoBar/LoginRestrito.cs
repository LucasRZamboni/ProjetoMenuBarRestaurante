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
    public partial class LoginRestrito : Form
    {
        public LoginRestrito()
        {
            InitializeComponent();

            ToolTip toolTip1 = new ToolTip();// tooltip para mostrar mensagem quando posição do mouse em cima de botão
            toolTip1.AutoPopDelay = 1000;
            toolTip1.InitialDelay = 600;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(this.tb_login, "digitar login");
            toolTip1.SetToolTip(this.tb_senha, "digitar senha");
            toolTip1.SetToolTip(this.cb_versenha, "mostrar/ocultar senha");
            toolTip1.SetToolTip(this.bt_entrar, "fazer login");
            toolTip1.SetToolTip(this.bt_cancelar, "cancelar login");
            

        }

        private void bt_entrar_Click(object sender, EventArgs e)
        {
            try
            {

                //--------------------------------------BOLA DE ERRO AO LADO DO LOGIN
                if (tb_login.Text == "")
                {

                    ErroProvider.SetError(tb_login, "Login não digitado ou Login inválido!!");
                    tb_login.Focus();
                    
                }
                else
                {

                    ErroProvider.Clear();

                }
                //--------------------------------------BOLA DE ERRO AO LADO DA SENHA
                if (tb_senha.Text == "")
                {

                    ErroProvider.SetError(tb_senha, "Senha não digitada ou Senha inválida!");
                    tb_senha.Focus();
                    
                }
                else
                {

                    ErroProvider.Clear();

                }
                //--------------------------------------SENHA E LOGIN ADM - - SENHA SIMPLES(TROCAVEL)
                if (tb_login.Text == "Administrador" && tb_senha.Text == "123")
                {
                    pictureBox1.Visible = true;

                    MessageBox.Show("Acesso Concedido!!", "Bem vindo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    var menu2 = new Menu2();
                    this.Hide();
                    menu2.ShowDialog();

                    
                }
                else
                {
                    MessageBox.Show("Acesso negado!!", "Erro!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //--------------------------------------CANCELA E VOLTA PRO LOGIN NORMAL
        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            var login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        //--------------------------------------VER OU OCULTAR SENHA
        private void cb_versenha_CheckedChanged(object sender, EventArgs e)
        {
            //--------------------------------------SE VER SENHA TICADO, DESATIVA CARACTERE DE SENHA
            if (cb_versenha.Checked == true)
            {
                tb_senha.UseSystemPasswordChar = false;

                MostrarOcultar.Text = "Ocultar";
            }
            //--------------------------------------SE NÃO, MANTEM COM CARACTERE
            else
            {
                tb_senha.UseSystemPasswordChar = true;

                MostrarOcultar.Text = "Mostrar";
            }
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
    }
}

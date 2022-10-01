using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ProjetoBar
{
    public partial class Login : Form
    {

        

        public Login()
        {
            InitializeComponent();

            tb_login.Clear();
            tb_senha.Clear();


            // tooltip para mostrar mensagem quando posição do mouse em cima de botão
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 1000;
            toolTip1.InitialDelay = 600;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(this.tb_senha, "Digitar senha");
            toolTip1.SetToolTip(this.tb_login, "Digitar login");
            toolTip1.SetToolTip(this.bt_cancelar, "Cancelar Login");
            toolTip1.SetToolTip(this.bt_entrar, "Efetuar Login");

        }


        //--------------------------------------VISUALIZAÇÃO DA SENHA
        private void cb_versenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_versenha.Checked == true)
            {
                tb_senha.UseSystemPasswordChar = false;

                MostrarOcultar.Text = "Ocultar";
            }
            else
            {
                tb_senha.UseSystemPasswordChar = true;

                MostrarOcultar.Text = "Mostrar";
            }
        }


        //--------------------------------------FECHA O APP E CANCELA A AUTENTICAÇÃO
        private void button2_Click(object sender, EventArgs e)
        {
            Autenticação.cancelar();


            Application.Exit();
        }


        //--------------------------------------VERIFICA A EXISTENCIA DO LOGIN E SENHA NO BANCO DE DADOS
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (cb_restrito.Checked == true)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    var loginrestrito = new LoginRestrito();
                    this.Hide();
                    loginrestrito.ShowDialog();
                    
                }


                string query = "SELECT * FROM Login WHERE Email=@email AND Senha=@senha";

                Conexão conexão = new Conexão();
                conexão.conectar();


                OleDbCommand cmd = new OleDbCommand(query, conexão.cn);

                cmd.Parameters.AddWithValue("@email", tb_login.Text);
                cmd.Parameters.AddWithValue("@senha", tb_senha.Text);

                

                OleDbDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Autenticação.login(dr["email"].ToString(), dr["senha"].ToString());

                    MessageBox.Show("Login efetuado com sucesso", "Bem Vindo(a)!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ALLVARS.email2 = tb_login.Text;
                    axWindowsMediaPlayer1.Ctlcontrols.stop();

                    var menu = new Menu();
                    this.Hide();
                    menu.ShowDialog();
                }
                else if (cb_novologin.Checked == true)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    var novologin = new NovoLogin();
                    this.Hide();
                    novologin.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Login ou senha incorretos", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (tb_login.Text == "")
                {

                    ErroProvider.SetError(tb_login, "Login não digitado ou Login inválido!!");
                    tb_login.Focus();
                    return;
                }
                else
                {

                    ErroProvider.Clear();

                }

                if (tb_senha.Text == "")
                {

                    ErroProvider.SetError(tb_senha, "Senha não digitada ou Senha inválida!");
                    tb_senha.Focus();
                    return;
                }
                else
                {

                    ErroProvider.Clear();

                }

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Login_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
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

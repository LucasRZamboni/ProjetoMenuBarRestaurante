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
    public partial class NovoLogin : Form
    {
        public NovoLogin()
        {
            InitializeComponent();

            // tooltip para mostrar mensagem quando posição do mouse em cima de botão
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 1000;
            toolTip1.InitialDelay = 600;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(this.tb_senha, "Digite sua senha");
            toolTip1.SetToolTip(this.tb_nome, "Nome será usado como Login");
            toolTip1.SetToolTip(this.bt_fechar, "Fechar");
            toolTip1.SetToolTip(this.tb_email, "Digite seu E-mail");
            toolTip1.SetToolTip(this.mtb_cpf, "Digite o seu CPF");

            


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

        //--------------------------------------SALVA O LOGIN
        private void loginBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                //--------------------------------------SE NADA PREENCHIDO, MOSTRA MENSAGEM
                if (tb_senha.Text == "" || tb_nome.Text == "" || tb_email.Text == "" || mtb_cpf.Text == "")
                {
                    MessageBox.Show("Há campos não preenchidos", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //--------------------------------------SE NÃO, VALIDA A ENTRADA
                else
                {
                    this.Validate();
                    this.loginBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.databaseLoginDataSet);

                    

                    MessageBox.Show("Novo login criado com sucesso", "Login Criado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //--------------------------------------SE ENTRTADA VALIDA E NOVO LOGIN SELECIONADO, POSSIBILIDADE DE ADD MAIS LOGINS
                    if (cb_novologin.Checked == false)
                    {
                        var login = new Login();
                        this.Hide();
                        login.ShowDialog();
                    }



                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!!");
            }
        }

        //--------------------------------------INICIAR TUDO VAZIO
        private void NovoLogin_Load(object sender, EventArgs e)
        {
            

            tb_email.Text = string.Empty;
            tb_nome.Text = string.Empty;
            tb_senha.Text = string.Empty;
            tb_id.Text = string.Empty;
            mtb_cpf.Text = string.Empty;
            mtb_cpf.Mask = @"000\.000\.000\-00";

        }

        //--------------------------------------VOLTA PARA A TELA LOGIN
        private void bt_fechar_Click(object sender, EventArgs e)
        {
            var login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        //--------------------------------------MOSTRA A DICA
        private void button1_Click(object sender, EventArgs e)
        {
            rtb_dica.Visible = true;
        }

        //--------------------------------------OCULTA A DICA
        private void rtb_dica_MouseClick(object sender, MouseEventArgs e)
        {
            rtb_dica.Visible = false;
        }

       
    }
}

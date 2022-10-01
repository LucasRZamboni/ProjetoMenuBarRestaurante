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
    public partial class Pratos : Form
    {
        public Pratos()
        {
            InitializeComponent();

            ToolTip toolTip1 = new ToolTip();// tooltip para mostrar mensagem quando posição do mouse em cima de botão
            toolTip1.AutoPopDelay = 1000;
            toolTip1.InitialDelay = 600;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(this.textBox6, "quantidade feijoada");
            toolTip1.SetToolTip(this.textBox6, "quantidade macarrão");
            toolTip1.SetToolTip(this.textBox6, "quantidade parmegiana");
            toolTip1.SetToolTip(this.textBox6, "quantidade feijão tropeiro");
            toolTip1.SetToolTip(this.textBox6, "quantidade selfservice");
            toolTip1.SetToolTip(this.button1, "salvar pedido");
            toolTip1.SetToolTip(this.bt_voltar, "Voltar");

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

        //--------------------------------------VOLTA PARA O MENU PRINCIPAL
        private void bt_voltar_Click(object sender, EventArgs e)
        {
            var menu = new Menu();
            this.Hide();
            menu.ShowDialog();
        }


        //--------------------------------------FINALIZA A ESCOLHA DOS PRATOS
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ALLVARS.qtdFeijoada = int.Parse(textBox6.Text);
                ALLVARS.qtdMacarrão = int.Parse(textBox7.Text);
                ALLVARS.qtdParmegiana = int.Parse(textBox8.Text);
                ALLVARS.qtdFeijãoTropeiro = int.Parse(textBox9.Text);
                ALLVARS.qtdSelfService = int.Parse(textBox10.Text);


                //--------------------------------------SE NADA FOI ESCOLHIDO, MOSTRA MENSAGEM DIZENDO
                if (ALLVARS.qtdFeijoada == 0 && ALLVARS.qtdMacarrão == 0 && ALLVARS.qtdParmegiana == 0 && ALLVARS.qtdFeijãoTropeiro == 0 && ALLVARS.qtdSelfService == 0)
                {
                    MessageBox.Show("Nenhum prato foi escolhido", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }

                //--------------------------------------SE ALGO FOI ESCOLHIDO, MOSTRA MENSAGEM SALVO
                else
                {
                    MessageBox.Show("Salvo com sucesso", "SALVO!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao salvar", "Erro!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //--------------------------------------APÓS CLICAR EM FAZER PEDIDO, VOLTA PRO MENU PRINCIPAL
            var menu = new Menu();
            this.Hide();
            menu.ShowDialog();
        }

        
    }
}

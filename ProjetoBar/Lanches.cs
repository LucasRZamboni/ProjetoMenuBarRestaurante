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
    public partial class Lanches : Form
    {
        public Lanches()
        {
            InitializeComponent();

            ToolTip toolTip1 = new ToolTip();// tooltip para mostrar mensagem quando posição do mouse em cima de botão
            toolTip1.AutoPopDelay = 1000;
            toolTip1.InitialDelay = 600;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(this.textBox6, "quantidade x-burguer");
            toolTip1.SetToolTip(this.textBox6, "quantidade x-salada");
            toolTip1.SetToolTip(this.textBox6, "quantidade x-milho");
            toolTip1.SetToolTip(this.textBox6, "quantidade x-picanha");
            toolTip1.SetToolTip(this.textBox6, "quantidade x-frango");
            toolTip1.SetToolTip(this.button1, "salvar pedido");
            toolTip1.SetToolTip(this.bt_voltar, "Voltar");

        }


        //--------------------------------------FINALIZA A ESCOLHA DOS LANCHES
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ALLVARS.qtdBurguer = int.Parse(textBox6.Text);
                ALLVARS.qtdSalada = int.Parse(textBox7.Text);
                ALLVARS.qtdMilho = int.Parse(textBox8.Text);
                ALLVARS.qtdPicanha = int.Parse(textBox9.Text);
                ALLVARS.qtdX_Frango = int.Parse(textBox10.Text);


                //--------------------------------------SE NADA FOI ESCOLHIDO, MOSTRA MENSAGEM DIZENDO
                if (ALLVARS.qtdBurguer == 0 && ALLVARS.qtdSalada == 0 && ALLVARS.qtdMilho == 0 && ALLVARS.qtdPicanha == 0 && ALLVARS.qtdX_Frango == 0)
                {
                    MessageBox.Show("Nenhum lanche foi escolhido", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }

                //--------------------------------------SE ALGO FOI ESCOLHIDO, MOSTRA MENSAGEM SALVO
                else
                {
                    MessageBox.Show("Salvo com sucesso", "SALVO!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //--------------------------------------APÓS CLICAR EM FAZER PEDIDO, VOLTA PRO MENU PRINCIPAL
            var menu = new Menu();
            this.Hide();
            menu.ShowDialog();
        }

        //--------------------------------------VOLTA PRO MENU PRINCIPAL
        private void bt_voltar_Click(object sender, EventArgs e)
        {
            var menu = new Menu();
            this.Hide();
            menu.ShowDialog();
        }

        //--------------------------------------MOVIMENTO DO APP NA AREA DE TRABALHO
        private int cX, cY;
        private bool mover;

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

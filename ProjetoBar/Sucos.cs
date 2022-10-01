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
    public partial class Sucos : Form
    {
        public Sucos()
        {
            InitializeComponent();

            ToolTip toolTip1 = new ToolTip();// tooltip para mostrar mensagem quando posição do mouse em cima de botão
            toolTip1.AutoPopDelay = 1000;
            toolTip1.InitialDelay = 600;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(this.textBox6, "quantidade suco laranja");
            toolTip1.SetToolTip(this.textBox6, "quantidade suco maracuja");
            toolTip1.SetToolTip(this.textBox6, "quantidade suco kiwi");
            toolTip1.SetToolTip(this.textBox6, "quantidade suco limão");
            toolTip1.SetToolTip(this.textBox6, "quantidade suco manga");
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


        //--------------------------------------FINALIZA A ESCOLHA DOS LANCHES
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ALLVARS.qtdLaranja = int.Parse(textBox6.Text);
                ALLVARS.qtdMaracuja = int.Parse(textBox7.Text);
                ALLVARS.qtdKiwi = int.Parse(textBox8.Text);
                ALLVARS.qtdLimão = int.Parse(textBox9.Text);
                ALLVARS.qtdManga = int.Parse(textBox10.Text);


                //--------------------------------------SE NADA FOI ESCOLHIDO, MOSTRA MENSAGEM DIZENDO
                if (ALLVARS.qtdLaranja == 0 && ALLVARS.qtdMaracuja == 0 && ALLVARS.qtdKiwi == 0 && ALLVARS.qtdLimão == 0 && ALLVARS.qtdManga == 0)
                {
                    MessageBox.Show("Nenhum suco foi escolhido", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }

                //--------------------------------------SE ALGO FOI ESCOLHIDO, MOSTRA MENSAGEM SALVO
                else
                {
                    MessageBox.Show("Salvo com sucesso", "SALVO!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //--------------------------------------APÓS CLICAR EM FAZER PEDIDO, VOLTA PRO MENU PRINCIPAL
            var bebidas = new Bebidas();
            this.Hide();
            bebidas.ShowDialog();
        }


        //--------------------------------------VOLTA PRO MENU PRINCIPAL
        private void bt_voltar_Click(object sender, EventArgs e)
        {
            var bebidas = new Bebidas();
            this.Hide();
            bebidas.ShowDialog();
        }
    }
}

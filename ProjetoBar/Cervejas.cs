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
    public partial class Cervejas : Form
    {
        public Cervejas()
        {
            InitializeComponent();


            ToolTip toolTip1 = new ToolTip();// tooltip para mostrar mensagem quando posição do mouse em cima de botão
            toolTip1.AutoPopDelay = 1000;
            toolTip1.InitialDelay = 600;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(this.textBox6, "quantidade amstel");
            toolTip1.SetToolTip(this.textBox6, "quantidade stella");
            toolTip1.SetToolTip(this.textBox6, "quantidade budweiser");
            toolTip1.SetToolTip(this.textBox6, "quantidade heinekein");
            toolTip1.SetToolTip(this.textBox6, "quantidade corona");
            toolTip1.SetToolTip(this.button1, "salvar pedido");
            toolTip1.SetToolTip(this.bt_voltar, "Voltar");

        }

        //--------------------------------------FINALIZA A ESCOLHA DAS CERVEJAS
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                ALLVARS.qtdAmstel = int.Parse(textBox6.Text);
                ALLVARS.qtdStella = int.Parse(textBox7.Text);
                ALLVARS.qtdBudweiser = int.Parse(textBox8.Text);
                ALLVARS.qtdHeinekein = int.Parse(textBox9.Text);
                ALLVARS.qtdCorona = int.Parse(textBox10.Text);

                //--------------------------------------SE NADA FOI ESCOLHIDO, MOSTRA MENSAGEM DIZENDO
                if (ALLVARS.qtdAmstel == 0 && ALLVARS.qtdStella == 0 && ALLVARS.qtdBudweiser == 0 && ALLVARS.qtdHeinekein ==0 && ALLVARS.qtdCorona == 0)
                {
                    MessageBox.Show("Nenhuma cerveja foi escolhida", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Question);
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

            //--------------------------------------APÓS CLICAR EM FAZER PEDIDO, VOLTA PRO MENU BEBIDAS
            var bebidas = new Bebidas();
            this.Hide();
            bebidas.ShowDialog();

        }

        //--------------------------------------VOLTA PARA O MENU BEBIDAS
        private void bt_voltar_Click(object sender, EventArgs e)
        {
            var bebidas = new Bebidas();
            this.Hide();
            bebidas.ShowDialog();
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

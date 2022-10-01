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
    public partial class Porções : Form
    {
        public Porções()
        {
            InitializeComponent();

            ToolTip toolTip1 = new ToolTip();// tooltip para mostrar mensagem quando posição do mouse em cima de botão
            toolTip1.AutoPopDelay = 1000;
            toolTip1.InitialDelay = 600;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(this.textBox6, "quantidade peixe à milanesa");
            toolTip1.SetToolTip(this.textBox6, "quantidade batata frita");
            toolTip1.SetToolTip(this.textBox6, "quantidade frango à milanesa");
            toolTip1.SetToolTip(this.textBox6, "quantidade calabresa");
            toolTip1.SetToolTip(this.textBox6, "quantidade provolone à milanesa");
            toolTip1.SetToolTip(this.button1, "salvar pedido");
            toolTip1.SetToolTip(this.bt_voltar, "Voltar");
        }


        //--------------------------------------VOLTA PARA O MENU PRINCIPAL
        private void bt_voltar_Click(object sender, EventArgs e)
        {
            var menu = new Menu();
            this.Hide();
            menu.ShowDialog();
        }

        //--------------------------------------FINALIZA A ESCOLHA DAS PORÇÕES
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ALLVARS.qtdPeixe = int.Parse(textBox6.Text);
                ALLVARS.qtdBatata = int.Parse(textBox7.Text);
                ALLVARS.qtdFrango = int.Parse(textBox8.Text);
                ALLVARS.qtdCalabresa = int.Parse(textBox9.Text);
                ALLVARS.qtdProvolone = int.Parse(textBox10.Text);


                //--------------------------------------SE NADA FOI ESCOLHIDO, MOSTRA MENSAGEM DIZENDO
                if (ALLVARS.qtdPeixe == 0 && ALLVARS.qtdBatata == 0 && ALLVARS.qtdFrango == 0 && ALLVARS.qtdCalabresa == 0 && ALLVARS.qtdProvolone == 0)
                {
                    MessageBox.Show("Nenhuma porção foi escolhida", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }

                //--------------------------------------SE ALGO FOI ESCOLHIDO, MOSTRA MENSAGEM SALVO
                else
                {
                    MessageBox.Show("Salvo com sucesso", "SALVO!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Erro!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //--------------------------------------APÓS CLICAR EM FAZER PEDIDO, VOLTA PRO MENU PRINCIPAL
            var menu = new Menu();
            this.Hide();
            menu.ShowDialog();
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

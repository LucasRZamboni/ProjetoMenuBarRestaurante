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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            ToolTip toolTip1 = new ToolTip();// tooltip para mostrar mensagem quando posição do mouse em cima de botão
            toolTip1.AutoPopDelay = 1000;
            toolTip1.InitialDelay = 600;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(this.button1, "Menu bebidas");
            toolTip1.SetToolTip(this.button2, "Menu pratos");
            toolTip1.SetToolTip(this.button3, "Menu drinks");
            toolTip1.SetToolTip(this.button4, "Menu lanches");
            toolTip1.SetToolTip(this.button5, "fechar pedido");
            toolTip1.SetToolTip(this.bt_fechar, "fechar");
            toolTip1.SetToolTip(this.bt_voltar, "Voltar");
        }



        //--------------------------------------VOLTA PARA TELA LOGIN
        private void bt_voltar_Click(object sender, EventArgs e)
        {
            var login = new Login();
            this.Hide();
            login.Show();
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

        //--------------------------------------ABRE MENU BEBIDAS
        private void button1_Click(object sender, EventArgs e)
        {
            var bebidas = new Bebidas();
            this.Hide();
            bebidas.ShowDialog();
        }
        //--------------------------------------ABRE MENU PRATOS
        private void button2_Click(object sender, EventArgs e)
        {
            var pratos = new Pratos();
            this.Hide();
            pratos.ShowDialog();
        }
        //--------------------------------------FECHA A CONTA(FECHA PEDIDO)
        private void button5_Click(object sender, EventArgs e)
        {
            FechaConta fechaconta = new FechaConta();
            this.Hide();
            fechaconta.ShowDialog();
        }

        //--------------------------------------ABRE MENU PORÇÕES
        private void button3_Click(object sender, EventArgs e)
        {
            var porções = new Porções();
            this.Hide();
            porções.ShowDialog();
        }

        //--------------------------------------ABRE MENU LANCHES
        private void button4_Click(object sender, EventArgs e)
        {
            var lanches = new Lanches();
            this.Hide();
            lanches.ShowDialog();
        }

 

        //--------------------------------------FECHA O APP
        private void bt_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

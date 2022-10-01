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
    public partial class Bebidas : Form
    {
        public Bebidas()
        {
            InitializeComponent();
        }

    
        //--------------------------------------VOLTA MENU PRINCIPAL
        private void bt_voltar_Click(object sender, EventArgs e)
        {
            var menu = new Menu();
            this.Hide();
            menu.ShowDialog();
        }

        //--------------------------------------FECHA O APP
        private void bt_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        //--------------------------------------ABRE MENU REFRIGERANTES
        private void button1_Click(object sender, EventArgs e)
        {
            var refri = new Refrigerante();
            this.Hide();
            refri.ShowDialog();
        }
        //--------------------------------------ABRE MENU SUCOS
        private void button2_Click(object sender, EventArgs e)
        {
            var sucos = new Sucos();
            this.Hide();
            sucos.ShowDialog();
        }
        //--------------------------------------ABRE MENU CERVEJAS
        private void button3_Click(object sender, EventArgs e)
        {
            var cervejas = new Cervejas();
            this.Hide();
            cervejas.ShowDialog();
        }

        //--------------------------------------ABRE MENU DRINKS
        private void button4_Click(object sender, EventArgs e)
        {
            var drinks = new Drinks();
            this.Hide();
            drinks.ShowDialog();
        }

        
    }
}

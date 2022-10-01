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
    public partial class Menu2 : Form
    {
        public Menu2()
        {
            InitializeComponent();
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
        private void bt_relatorios_Click(object sender, EventArgs e)
        {
            var relatorios = new Relatórios();
            this.Hide();
            relatorios.ShowDialog();
        }

        private void bt_cadprod_Click(object sender, EventArgs e)
        {
            var cadprod = new CadastroProdutos();
            this.Hide();
            cadprod.ShowDialog();
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            var login = new LoginRestrito();
            this.Hide();
            login.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var edituser = new EditUser();
            this.Hide();
            edituser.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var editprod = new EditProd();
            this.Hide();
            editprod.ShowDialog();
        }

        private void bt_cadlogin_Click(object sender, EventArgs e)
        {
            var caduser = new CadUser();
            this.Hide();
            caduser.ShowDialog();
        }

    }
}

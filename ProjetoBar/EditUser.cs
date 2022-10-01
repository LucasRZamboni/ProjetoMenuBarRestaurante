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
    public partial class EditUser : Form
    {
        public EditUser()
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
        private void bt_voltar_Click(object sender, EventArgs e)
        {
            var menu2 = new Menu2();
            this.Hide();
            menu2.ShowDialog();

        }
        private void bt_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loginBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseLoginDataSet);

        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'databaseLoginDataSet.Login'. Você pode movê-la ou removê-la conforme necessário.
            this.loginTableAdapter.Fill(this.databaseLoginDataSet.Login);


            loginDataGridView.Columns[0].Width = 50;
            loginDataGridView.Columns[0].HeaderText = "ID";
            loginDataGridView.Columns[1].Width = 70;
            loginDataGridView.Columns[1].HeaderText = "Nome";
            loginDataGridView.Columns[2].Width = 100;
            loginDataGridView.Columns[2].HeaderText = "CPF";
            loginDataGridView.Columns[3].Width = 150;
            loginDataGridView.Columns[3].HeaderText = "Email";
            loginDataGridView.Columns[4].Width = 70;
            loginDataGridView.Columns[4].HeaderText = "Senha";

        }

        private void bt_voltar_Click_1(object sender, EventArgs e)
        {
            var menu2 = new Menu2();
            this.Hide();
            menu2.ShowDialog();
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

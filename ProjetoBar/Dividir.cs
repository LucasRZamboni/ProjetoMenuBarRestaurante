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
    public partial class Dividir : Form
    {
        public Dividir()
        {
            InitializeComponent();

        }
        
        private void bt_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float pagar;
            float total0;
            int dividir;
            dividir = int.Parse(tb_dividir.Text);
            total0 = float.Parse(tb_total.Text);
            pagar = total0 / dividir;


            tb_valorpagar.Text = pagar.ToString("C2");
        }

        private void Dividir_Load(object sender, EventArgs e)
        {
            tb_total.Text = ALLVARS.fecharConta.ToString();
        }
    }
}

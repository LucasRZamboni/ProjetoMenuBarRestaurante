using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjetoBar
{
    public partial class LeituraTXT : Form
    {

        public static StringReader leitor = null;


        public LeituraTXT()
        {
            InitializeComponent();
        }

        

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            var fechaconta = new FechaConta();
            this.Hide();
            fechaconta.ShowDialog();
        }

        private void LeituraTXT_Load(object sender, EventArgs e)
        {
            
            StreamReader leituratxt = new StreamReader("Pedido mesa nº" + ArquivoTXT.mesa + " " + " Cliente " + ArquivoTXT.nome + ".txt");
            richTextBox1.Text = leituratxt.ReadToEnd();
            //leituratxt.Close();

            

        }

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

        private void Imprimir()
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        
        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            char[] param = { '\n' };

            if (printDialog1.PrinterSettings.PrintRange == System.Drawing.Printing.PrintRange.Selection)
            {
                lines = richTextBox1.SelectedText.Split(param);
            }
            else
            {
                lines = richTextBox1.Text.Split(param);
            }

            int i = 0;
            char[] trimParam = { '\r' };
            foreach (string s in lines)
            {
                lines[i++] = s.TrimEnd(trimParam);
            }
        }

        private int linesPrinted;
        private string[] lines;

        private void OnPrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                int x = e.MarginBounds.Left;
                int y = e.MarginBounds.Top;
                Brush brush = new SolidBrush(richTextBox1.ForeColor);

                while (linesPrinted < lines.Length)
                {
                    e.Graphics.DrawString(lines[linesPrinted++],
                        richTextBox1.Font, brush, x, y);
                    y += 15;
                    if (y >= e.MarginBounds.Bottom)
                    {
                        e.HasMorePages = true;
                        return;
                    }
                }

                linesPrinted = 0;
                e.HasMorePages = false;

            }
            catch (Exception)
            {
                MessageBox.Show("erro");
            }
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            Imprimir();
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

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            visualizaImpressao();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ALLVARS.mensagem = richTextBox1.Text;


            SendEmail.enviaremail();
        }

        private void visualizaImpressao()
        {
            //visualiza a impressao
            try
            {
                string strTexto = this.richTextBox1.Text;
                leitor = new StringReader(strTexto);
                PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
                var prn = printPreviewDialog1;
                prn.Document = printDocument1;
                prn.Text = "Visualizando a impressão";
                prn.WindowState = FormWindowState.Maximized;
                prn.PrintPreviewControl.Zoom = 1;
                prn.FormBorderStyle = FormBorderStyle.Fixed3D;
                prn.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

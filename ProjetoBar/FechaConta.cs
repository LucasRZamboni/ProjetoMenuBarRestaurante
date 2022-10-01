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
using System.Diagnostics;

namespace ProjetoBar
{
    public partial class FechaConta : Form
    {

        

        public FechaConta()
        {
            InitializeComponent();

            

            textBox6.Text = ALLVARS.qtdCoca.ToString();
            textBox7.Text = ALLVARS.qtdCocaZero.ToString();
            textBox8.Text = ALLVARS.qtdKuat.ToString();
            textBox9.Text = ALLVARS.qtdFanta.ToString();
            textBox10.Text = ALLVARS.qtdSprite.ToString();

            //---------------------------------------------------
            textBox16.Text = ALLVARS.qtdAmstel.ToString();
            textBox17.Text = ALLVARS.qtdStella.ToString();
            textBox18.Text = ALLVARS.qtdBudweiser.ToString();
            textBox19.Text = ALLVARS.qtdHeinekein.ToString();
            textBox20.Text = ALLVARS.qtdCorona.ToString();
            //---------------------------------------------------
            textBox26.Text = ALLVARS.qtdLaranja.ToString();
            textBox27.Text = ALLVARS.qtdMaracuja.ToString();
            textBox28.Text = ALLVARS.qtdKiwi.ToString();
            textBox29.Text = ALLVARS.qtdLimão.ToString();
            textBox30.Text = ALLVARS.qtdManga.ToString();
            //---------------------------------------------------
            textBox36.Text = ALLVARS.qtdCaipirinha.ToString();
            textBox37.Text = ALLVARS.qtdMartini.ToString();
            textBox38.Text = ALLVARS.qtdPiñaColada.ToString();
            textBox39.Text = ALLVARS.qtdCaipirosca.ToString();
            textBox40.Text = ALLVARS.qtdMojito.ToString();
            //---------------------------------------------------
            textBox46.Text = ALLVARS.qtdFeijoada.ToString();
            textBox47.Text = ALLVARS.qtdMacarrão.ToString();
            textBox48.Text = ALLVARS.qtdParmegiana.ToString();
            textBox49.Text = ALLVARS.qtdFeijãoTropeiro.ToString();
            textBox50.Text = ALLVARS.qtdSelfService.ToString();
            //---------------------------------------------------
            textBox56.Text = ALLVARS.qtdPeixe.ToString();
            textBox57.Text = ALLVARS.qtdBatata.ToString();
            textBox58.Text = ALLVARS.qtdFrango.ToString();
            textBox59.Text = ALLVARS.qtdCalabresa.ToString();
            textBox60.Text = ALLVARS.qtdProvolone.ToString();
            //---------------------------------------------------
            textBox66.Text = ALLVARS.qtdBurguer.ToString();
            textBox67.Text = ALLVARS.qtdSalada.ToString();
            textBox68.Text = ALLVARS.qtdMilho.ToString();
            textBox69.Text = ALLVARS.qtdPicanha.ToString();
            textBox70.Text = ALLVARS.qtdX_Frango.ToString();

            //---------------------------------------------------


            ToolTip toolTip1 = new ToolTip();// tooltip para mostrar mensagem quando posição do mouse em cima de botão
            toolTip1.AutoPopDelay = 1000;
            toolTip1.InitialDelay = 600;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(this.radioButton1, " 3% de desconto");
            toolTip1.SetToolTip(this.radioButton2, " 15% de acréscimo");
            toolTip1.SetToolTip(this.radioButton3, " 5% de desconto");
            toolTip1.SetToolTip(this.radioButton4, " 5% de desconto");
            toolTip1.SetToolTip(this.tb_subtotal, "Valor sem taxa serviço");
            toolTip1.SetToolTip(this.tb_subtotal2, " 10% taxa de serviço");
            toolTip1.SetToolTip(this.tb_fecharConta, "Valor total a pagar");

            toolTip1.SetToolTip(this.tb_refrigerantes, "Valor total Refrigerantes");
            toolTip1.SetToolTip(this.tb_cervejas, "Valor total Cervejas");
            toolTip1.SetToolTip(this.tb_sucos, "Valor total Sucos");
            toolTip1.SetToolTip(this.tb_drinks, "Valor total Drinks");
            toolTip1.SetToolTip(this.tb_pratos, "Valor total Pratos");
            toolTip1.SetToolTip(this.tb_porções, "Valor total Porções");
            toolTip1.SetToolTip(this.tb_lanches, "Valor total Lanches");

            toolTip1.SetToolTip(this.tb_mesa, "Numero da mesa");
            toolTip1.SetToolTip(this.tb_nome, "Nome do cliente");

            toolTip1.SetToolTip(this.button1, "Finalizar pedido");
            toolTip1.SetToolTip(this.button2, "Abrir calculadora");
            toolTip1.SetToolTip(this.button3, "Imprimir nota fiscal");


        }

        //--------------------------------------FECHA O APP
        private void bt_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //--------------------------------------FINALIZAR PEDIDO
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //--------------------------------------CALCULOS
                //---------------------------------------------------REFRIGERANTES
                ALLVARS.valorCoca = ALLVARS.Coca * ALLVARS.qtdCoca;
                ALLVARS.valorCocaZero = ALLVARS.CocaZero * ALLVARS.qtdCocaZero;
                ALLVARS.valorKuat = ALLVARS.Kuat * ALLVARS.qtdKuat;
                ALLVARS.valorFanta = ALLVARS.Fanta * ALLVARS.qtdFanta;
                ALLVARS.valorSprite = ALLVARS.Sprite * ALLVARS.qtdSprite;

                ALLVARS.valorTotalRefri = ALLVARS.valorCoca + ALLVARS.valorCocaZero + ALLVARS.valorKuat + ALLVARS.valorFanta + ALLVARS.valorSprite;

                //---------------------------------------------------CERVEJAS
                ALLVARS.valorAmstel = ALLVARS.Amstel * ALLVARS.qtdAmstel;
                ALLVARS.valorStella = ALLVARS.Stella * ALLVARS.qtdStella;
                ALLVARS.valorBudweiser = ALLVARS.Budweiser * ALLVARS.qtdBudweiser;
                ALLVARS.valorHeinekein = ALLVARS.Heinekein * ALLVARS.qtdHeinekein;
                ALLVARS.valorCorona = ALLVARS.Corona * ALLVARS.qtdCorona;

                ALLVARS.valorTotalCervejas = ALLVARS.valorAmstel + ALLVARS.valorStella + ALLVARS.valorBudweiser + ALLVARS.valorHeinekein + ALLVARS.valorCorona;

                //---------------------------------------------------Sucos
                ALLVARS.valorLaranja = ALLVARS.Laranja * ALLVARS.qtdLaranja;
                ALLVARS.valorMaracuja = ALLVARS.Maracuja * ALLVARS.qtdMaracuja;
                ALLVARS.valorKiwi = ALLVARS.Kiwi * ALLVARS.qtdKiwi;
                ALLVARS.valorLimão = ALLVARS.Limão * ALLVARS.qtdLimão;
                ALLVARS.valorManga = ALLVARS.Manga * ALLVARS.qtdManga;

                ALLVARS.valorTotalSucos = ALLVARS.valorLaranja + ALLVARS.valorMaracuja + ALLVARS.valorKiwi + ALLVARS.valorLimão + ALLVARS.valorManga;

                //---------------------------------------------------Drinks
                ALLVARS.valorCaipirinha = ALLVARS.Caipirinha * ALLVARS.qtdCaipirinha;
                ALLVARS.valorMartini = ALLVARS.Martini * ALLVARS.qtdMartini;
                ALLVARS.valorPiñaColada = ALLVARS.PiñaColada * ALLVARS.qtdPiñaColada;
                ALLVARS.valorCaipirosca = ALLVARS.Caipirosca * ALLVARS.qtdCaipirosca;
                ALLVARS.valorMojito = ALLVARS.Mojito * ALLVARS.qtdMojito;

                ALLVARS.valorTotalDrinks = ALLVARS.valorCaipirinha + ALLVARS.valorMartini + ALLVARS.valorPiñaColada + ALLVARS.valorCaipirosca + ALLVARS.valorMojito;

                //---------------------------------------------------Pratos
                ALLVARS.valorFeijoada = ALLVARS.Feijoada * ALLVARS.qtdFeijoada;
                ALLVARS.valorMacarrão = ALLVARS.Macarrão * ALLVARS.qtdMacarrão;
                ALLVARS.valorParmegiana = ALLVARS.Parmegiana * ALLVARS.qtdParmegiana;
                ALLVARS.valorFeijãoTropeiro = ALLVARS.FeijãoTropeiro * ALLVARS.qtdFeijãoTropeiro;
                ALLVARS.valorSelfService = ALLVARS.SelfService * ALLVARS.qtdSelfService;

                ALLVARS.valorTotalPratos = ALLVARS.valorFeijoada + ALLVARS.valorMacarrão + ALLVARS.valorParmegiana + ALLVARS.valorFeijãoTropeiro + ALLVARS.valorSelfService;

                //---------------------------------------------------Porções
                ALLVARS.valorPeixe = ALLVARS.Peixe * ALLVARS.qtdPeixe;
                ALLVARS.valorBatata = ALLVARS.Batata * ALLVARS.qtdBatata;
                ALLVARS.valorFrango = ALLVARS.Frango * ALLVARS.qtdFrango;
                ALLVARS.valorCalabresa = ALLVARS.Calabresa * ALLVARS.qtdCalabresa;
                ALLVARS.valorProvolone = ALLVARS.Provolone * ALLVARS.qtdProvolone;

                ALLVARS.valorTotalPorções = ALLVARS.valorPeixe + ALLVARS.valorBatata + ALLVARS.valorFrango + ALLVARS.valorCalabresa + ALLVARS.valorProvolone;

                //---------------------------------------------------Lanches
                ALLVARS.valorBurguer = ALLVARS.Burguer * ALLVARS.qtdBurguer;
                ALLVARS.valorMilho = ALLVARS.Milho * ALLVARS.qtdMilho;
                ALLVARS.valorSalada = ALLVARS.Salada * ALLVARS.qtdSalada;
                ALLVARS.valorPicanha = ALLVARS.Picanha * ALLVARS.qtdPicanha;
                ALLVARS.valorX_Frango = ALLVARS.X_Frango * ALLVARS.qtdX_Frango;

                ALLVARS.valorTotalLanches = ALLVARS.valorBurguer + ALLVARS.valorMilho + ALLVARS.valorSalada + ALLVARS.valorPicanha + ALLVARS.valorX_Frango;

                //---------------------------------------------------
                ALLVARS.subtotal = ALLVARS.valorTotalCervejas + ALLVARS.valorTotalRefri + ALLVARS.valorTotalSucos + ALLVARS.valorTotalPratos + ALLVARS.valorTotalPorções + ALLVARS.valorTotalLanches + ALLVARS.valorTotalDrinks;

                ALLVARS.subtotal2 = ALLVARS.taxaserviço * ALLVARS.subtotal;

                //---------------------------------------------------REFRIGERANTES
                tb_refrigerantes.Text = ALLVARS.valorTotalRefri.ToString("C2");
                //---------------------------------------------------CERVEJAS
                tb_cervejas.Text = ALLVARS.valorTotalCervejas.ToString("C2");
                //---------------------------------------------------SUCOS
                tb_sucos.Text = ALLVARS.valorTotalSucos.ToString("C2");
                //---------------------------------------------------DRINKS
                tb_drinks.Text = ALLVARS.valorTotalDrinks.ToString("C2");
                //---------------------------------------------------PRATOS
                tb_pratos.Text = ALLVARS.valorTotalPratos.ToString("C2");
                //---------------------------------------------------PORÇÕES
                tb_porções.Text = ALLVARS.valorTotalPorções.ToString("C2");
                //---------------------------------------------------LANCHES
                tb_lanches.Text = ALLVARS.valorTotalLanches.ToString("C2");

                //---------------------------------------------------
                tb_subtotal.Text = ALLVARS.subtotal.ToString("C2");
                tb_subtotal2.Text = ALLVARS.subtotal2.ToString("C2");


                //--------------------------------------OPÇÕES DE PAGAMENTO E CALCULOS
                if (radioButton1.Checked == true)
                {
                    ALLVARS.fecharConta = (ALLVARS.subtotal + ALLVARS.subtotal2) - ((ALLVARS.subtotal + ALLVARS.subtotal2) * ALLVARS.cartDebit);

                    tb_fecharConta.Text = ALLVARS.fecharConta.ToString("C2");
                }
                else if (radioButton2.Checked == true)
                {
                    ALLVARS.fecharConta = ((ALLVARS.subtotal + ALLVARS.subtotal2) * ALLVARS.cartCred)+(ALLVARS.subtotal + ALLVARS.subtotal2);

                    tb_fecharConta.Text = ALLVARS.fecharConta.ToString("C2");
                }
                else if (radioButton3.Checked == true)
                {
                    ALLVARS.fecharConta = (ALLVARS.subtotal + ALLVARS.subtotal2) - ((ALLVARS.subtotal + ALLVARS.subtotal2) * ALLVARS.dinheiro);

                    tb_fecharConta.Text = ALLVARS.fecharConta.ToString("C2");
                }
                else if (radioButton4.Checked == true)
                {
                    ALLVARS.fecharConta = (ALLVARS.subtotal + ALLVARS.subtotal2) - ((ALLVARS.subtotal + ALLVARS.subtotal2) * ALLVARS.pix);

                    tb_fecharConta.Text = ALLVARS.fecharConta.ToString("C2");
                }
                else
                {
                    MessageBox.Show("Nessessário escolher opção de pagamento", "ATENÇÃO!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (tb_mesa.Text == "")
                {

                    errorProvider1.SetError(tb_mesa, "Numero da mesa não preenchido ou valor inválido");
                    tb_mesa.Focus();
                    return;
                }
                else
                {

                    errorProvider1.Clear();

                }

                if (tb_nome.Text == "")
                {

                    errorProvider1.SetError(tb_nome, "Nome do cliente não preenchido ou nome inválido");
                    tb_nome.Focus();
                    return;
                }
                else
                {

                    errorProvider1.Clear();

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!!", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            try
            {

                //--------------------------------------CONVERSÃO E LIGAÇÃO DE VARIAVEL COM TEXTBOX
                ArquivoTXT.mesa = tb_mesa.Text;
                ArquivoTXT.nome = tb_nome.Text;

                ArquivoTXT.RefriCoca = int.Parse(textBox6.Text);
                ArquivoTXT.RefriCocaZero = int.Parse(textBox7.Text);
                ArquivoTXT.RefriKuat = int.Parse(textBox8.Text);
                ArquivoTXT.RefriFanta = int.Parse(textBox9.Text);
                ArquivoTXT.RefriSprite = int.Parse(textBox10.Text);
                ArquivoTXT.TotalRefrigerantes = tb_refrigerantes.Text;

                ArquivoTXT.CervAmstel = int.Parse(textBox16.Text);
                ArquivoTXT.CervStella= int.Parse(textBox17.Text);
                ArquivoTXT.CervBudweiser = int.Parse(textBox18.Text);
                ArquivoTXT.CervHeinekein = int.Parse(textBox19.Text);
                ArquivoTXT.CervCorona = int.Parse(textBox20.Text);
                ArquivoTXT.TotalCervejas = tb_cervejas.Text;

                ArquivoTXT.SucoLaranja = int.Parse(textBox26.Text);
                ArquivoTXT.SucoMaracuja = int.Parse(textBox27.Text);
                ArquivoTXT.SucoKiwi = int.Parse(textBox28.Text);
                ArquivoTXT.SucoLimão = int.Parse(textBox29.Text);
                ArquivoTXT.SucoManga = int.Parse(textBox30.Text);
                ArquivoTXT.TotalSucos = tb_sucos.Text;

                ArquivoTXT.DrinkCaipirinha = int.Parse(textBox36.Text);
                ArquivoTXT.DrinkMartini = int.Parse(textBox37.Text);
                ArquivoTXT.DrinkPiñaColada = int.Parse(textBox38.Text);
                ArquivoTXT.DrinkCaipirosca = int.Parse(textBox39.Text);
                ArquivoTXT.DrinkMojito = int.Parse(textBox40.Text);
                ArquivoTXT.TotalDrinks = tb_drinks.Text;

                ArquivoTXT.PratoFeijoada = int.Parse(textBox46.Text);
                ArquivoTXT.PratoMacarrão = int.Parse(textBox47.Text);
                ArquivoTXT.PratoParmegiana = int.Parse(textBox48.Text);
                ArquivoTXT.PratoFeijãoTropeiro = int.Parse(textBox49.Text);
                ArquivoTXT.PratoSelfService = int.Parse(textBox50.Text);
                ArquivoTXT.TotalPratos = tb_pratos.Text;

                ArquivoTXT.PorçãoPeixe = int.Parse(textBox56.Text);
                ArquivoTXT.PorçãoBatata= int.Parse(textBox57.Text);
                ArquivoTXT.PorçãoFrango = int.Parse(textBox58.Text);
                ArquivoTXT.PorçãoCalabresa = int.Parse(textBox59.Text);
                ArquivoTXT.PorçãoProvolone = int.Parse(textBox60.Text);
                ArquivoTXT.TotalPorções = tb_porções.Text;

                ArquivoTXT.LancheBurguer = int.Parse(textBox66.Text);
                ArquivoTXT.LancheSalada = int.Parse(textBox67.Text);
                ArquivoTXT.LancheMilho = int.Parse(textBox68.Text);
                ArquivoTXT.LanchePicanha = int.Parse(textBox69.Text);
                ArquivoTXT.LancheX_Frango = int.Parse(textBox70.Text);
                ArquivoTXT.TotalLanches = tb_lanches.Text;

                ArquivoTXT.txtsubtotal = tb_subtotal.Text;
                ArquivoTXT.txtsubtotal2 = tb_subtotal2.Text;
                ArquivoTXT.txtcartDebit = radioButton1.Checked;
                ArquivoTXT.txtcartCred = radioButton2.Checked;
                ArquivoTXT.txtdinheiro = radioButton3.Checked;
                ArquivoTXT.txtpix = radioButton4.Checked;
                ArquivoTXT.txtfecharConta = tb_fecharConta.Text;


                //--------------------------------------PUXA O CODIGO DE GERAR ARQUIVO TXT
                ArquivoTXT.TXT();

                //--------------------------------------MENSAGEM PEDIDO E RECIBO GERADO
                MessageBox.Show("Pedido gerado com sucesso \nRecibo gerado", "Mensagem!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ALLVARS.qtdCoca = 0;
            ALLVARS.qtdCocaZero = 0;
            ALLVARS.qtdKuat = 0;
            ALLVARS.qtdFanta = 0;
            ALLVARS.qtdSprite = 0;

            //---------------------------------------------------
            ALLVARS.qtdAmstel = 0;
            ALLVARS.qtdStella = 0;
            ALLVARS.qtdBudweiser = 0;
            ALLVARS.qtdHeinekein = 0;
            ALLVARS.qtdCorona = 0;
            //---------------------------------------------------
            ALLVARS.qtdLaranja = 0;
            ALLVARS.qtdMaracuja = 0;
            ALLVARS.qtdKiwi = 0;
            ALLVARS.qtdLimão = 0;
            ALLVARS.qtdManga = 0;
            //---------------------------------------------------
            ALLVARS.qtdCaipirinha = 0;
            ALLVARS.qtdMartini = 0;
            ALLVARS.qtdPiñaColada = 0;
            ALLVARS.qtdCaipirosca = 0;
            ALLVARS.qtdMojito = 0;
            //---------------------------------------------------
            ALLVARS.qtdFeijoada = 0;
            ALLVARS.qtdMacarrão = 0;
            ALLVARS.qtdParmegiana = 0;
            ALLVARS.qtdFeijãoTropeiro = 0;
            ALLVARS.qtdSelfService = 0;
            //---------------------------------------------------
            ALLVARS.qtdPeixe = 0;
            ALLVARS.qtdBatata = 0;
            ALLVARS.qtdFrango = 0;
            ALLVARS.qtdCalabresa = 0;
            ALLVARS.qtdProvolone = 0;
            //---------------------------------------------------
            ALLVARS.qtdBurguer = 0;
            ALLVARS.qtdSalada = 0;
            ALLVARS.qtdMilho = 0;
            ALLVARS.qtdPicanha = 0;
            ALLVARS.qtdX_Frango = 0;
        }


        //--------------------------------------VOLTA MENU PRINCIPAL
        private void bt_voltar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
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

        private void button3_Click(object sender, EventArgs e)
        {
            //--------------------------------------ABRE NOTA FISCAL
            var leitura = new LeituraTXT();
            this.Hide();
            leitura.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //---------------------------------------------------


            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";

            //---------------------------------------------------
            textBox16.Text = "0";
            textBox17.Text = "0";
            textBox18.Text = "0";
            textBox19.Text = "0";
            textBox20.Text = "0";
            //---------------------------------------------------
            textBox26.Text = "0";
            textBox27.Text = "0";
            textBox28.Text = "0";
            textBox29.Text = "0";
            textBox30.Text = "0";
            //---------------------------------------------------
            textBox36.Text = "0";
            textBox37.Text = "0";
            textBox38.Text = "0";
            textBox39.Text = "0";
            textBox40.Text = "0";
            //---------------------------------------------------
            textBox46.Text = "0";
            textBox47.Text = "0";
            textBox48.Text = "0";
            textBox49.Text = "0";
            textBox50.Text = "0";
            //---------------------------------------------------
            textBox56.Text = "0";
            textBox57.Text = "0";
            textBox58.Text = "0";
            textBox59.Text = "0";
            textBox60.Text = "0";
            //---------------------------------------------------
            textBox66.Text = "0";
            textBox67.Text = "0";
            textBox68.Text = "0";
            textBox69.Text = "0";
            textBox70.Text = "0";

            //---------------------------------------------------

            ALLVARS.qtdCoca = 0;
            ALLVARS.qtdCocaZero = 0;
            ALLVARS.qtdKuat = 0;
            ALLVARS.qtdFanta = 0;
            ALLVARS.qtdSprite = 0;

            //---------------------------------------------------
            ALLVARS.qtdAmstel = 0;
            ALLVARS.qtdStella = 0;
            ALLVARS.qtdBudweiser = 0;
            ALLVARS.qtdHeinekein = 0;
            ALLVARS.qtdCorona = 0;
            //---------------------------------------------------
            ALLVARS.qtdLaranja = 0;
            ALLVARS.qtdMaracuja = 0;
            ALLVARS.qtdKiwi = 0;
            ALLVARS.qtdLimão = 0;
            ALLVARS.qtdManga = 0;
            //---------------------------------------------------
            ALLVARS.qtdCaipirinha = 0;
            ALLVARS.qtdMartini = 0;
            ALLVARS.qtdPiñaColada = 0;
            ALLVARS.qtdCaipirosca = 0;
            ALLVARS.qtdMojito = 0;
            //---------------------------------------------------
            ALLVARS.qtdFeijoada = 0;
            ALLVARS.qtdMacarrão = 0;
            ALLVARS.qtdParmegiana = 0;
            ALLVARS.qtdFeijãoTropeiro = 0;
            ALLVARS.qtdSelfService = 0;
            //---------------------------------------------------
            ALLVARS.qtdPeixe = 0;
            ALLVARS.qtdBatata = 0;
            ALLVARS.qtdFrango = 0;
            ALLVARS.qtdCalabresa = 0;
            ALLVARS.qtdProvolone = 0;
            //---------------------------------------------------
            ALLVARS.qtdBurguer = 0;
            ALLVARS.qtdSalada = 0;
            ALLVARS.qtdMilho = 0;
            ALLVARS.qtdPicanha = 0;
            ALLVARS.qtdX_Frango = 0;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var dividir = new Dividir();
            
            dividir.ShowDialog();
        }

        //--------------------------------------MOVIMENTO DO APP NA AREA DE TRABALHO

        //--------------------------------------ABRE CALCULADORA DO WINDOWS
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("Calc.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!!");
            }
        }
    }
}

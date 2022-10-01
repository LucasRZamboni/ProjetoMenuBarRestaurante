using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjetoBar
{
     class ArquivoTXT
    {

        //---------------------VARIAVEIS LOCAIS DE ATRIBUIÇÃO NO TXT------------------------------
        public static string mesa;
        public static string nome;

        //---------------------------------------------------REFRIGERANTES
        public static string TotalRefrigerantes;
        public static int RefriCoca, RefriCocaZero, RefriKuat, RefriFanta, RefriSprite;
        //---------------------------------------------------REFRIGERANTES

        //---------------------------------------------------CERVEJAS
        public static string TotalCervejas;
        public static int CervAmstel, CervStella, CervBudweiser, CervHeinekein, CervCorona;
        //---------------------------------------------------CERVEJAS

        //---------------------------------------------------SUCOS
        public static string TotalSucos;
        public static int SucoLaranja, SucoMaracuja, SucoKiwi, SucoLimão, SucoManga;
        //---------------------------------------------------SUCOS

        //---------------------------------------------------DRINKS
        public static string TotalDrinks;
        public static int DrinkCaipirinha, DrinkMartini, DrinkPiñaColada, DrinkCaipirosca, DrinkMojito;
        //---------------------------------------------------DRINKS

        //---------------------------------------------------PRATOS
        public static string TotalPratos;
        public static int PratoFeijoada, PratoMacarrão, PratoParmegiana, PratoFeijãoTropeiro, PratoSelfService;
        //---------------------------------------------------PRATOS

        //---------------------------------------------------PORÇÕES
        public static string TotalPorções;
        public static int PorçãoPeixe, PorçãoBatata, PorçãoFrango, PorçãoCalabresa, PorçãoProvolone;
        //---------------------------------------------------PORÇÕES

        //---------------------------------------------------LANCHES
        public static string TotalLanches;
        public static int LancheBurguer, LancheSalada, LancheMilho, LanchePicanha, LancheX_Frango;
        //---------------------------------------------------LANCHES

        //---------------------------------------------------TOTAIS
        public static string txtfecharConta, txtsubtotal, txtsubtotal2;
        public static bool txtcartDebit, txtcartCred, txtpix, txtdinheiro;
        //---------------------------------------------------TOTAIS

        //---------------------VARIAVEIS LOCAIS DE ATRIBUIÇÃO NO TXT------------------------------

        public static void TXT()
        {
            //---------------------------------------------------DATA
            string Date = DateTime.Now.ToString("dd/MM/yyyy");

            // Cria arquivo com numero da mesa + nome do cliente (.txt extenção de texto)
            StreamWriter objArquivo = new StreamWriter("Pedido mesa nº" + mesa + " " + " Cliente " + nome + ".txt");
            //--------------------------------------Area de edição do texto----------------------------------------------
            // editando o arquivo de TEXTO--------------------------------------
            objArquivo.WriteLine("════════════════════Restaurant Bar═══════════════════");
            objArquivo.WriteLine("═════════════════════════════════════════════════════");
            objArquivo.WriteLine("\n");
            objArquivo.WriteLine("Pedido mesa nº | " + mesa + " | " + "══════════════════════" + "Data: " + Date);

            objArquivo.WriteLine("Cliente: " + nome);
            objArquivo.WriteLine("═════════════════════════════════════════════════════");

            objArquivo.WriteLine("\n");

            //--------------------------------------Se total refrigerante diferente de 0, mostra o(os) refrigerante(s)
            if (TotalRefrigerantes != "R$ 0,00")
            {
                objArquivo.WriteLine("Refrigerante(s): ");
                if (RefriCoca > 0)
                {
                    objArquivo.WriteLine("Coca-Cola: " + RefriCoca + " (R$ 5,00)");
                }
                if (RefriCocaZero > 0)
                {
                    objArquivo.WriteLine("Coca-Cola Zero: " + RefriCocaZero + " (R$ 5,00)");
                }
                if (RefriKuat > 0)
                {
                    objArquivo.WriteLine("Kuat: " + RefriKuat + " (R$ 4,30)");
                }
                if (RefriFanta > 0)
                {
                    objArquivo.WriteLine("Fanta: " + RefriFanta + " (R$ 4,00)");
                }
                if (RefriSprite > 0)
                {
                    objArquivo.WriteLine("Sprite: " + RefriSprite + " (R$ 4,50)");
                }

                objArquivo.WriteLine("═════════════════════════════════════════════════════");
                objArquivo.WriteLine("Total Refrigerante(s): " + TotalRefrigerantes);
                objArquivo.WriteLine("═════════════════════════════════════════════════════");
                objArquivo.WriteLine("\n");
            }
            //--------------------------------------Se total cervejas diferente de 0, mostra a(as) cerveja(s)
            if (TotalCervejas != "R$ 0,00")
            {
                objArquivo.WriteLine("Cerveja(s): ");
                if (CervAmstel > 0)
                {
                    objArquivo.WriteLine("Amstel: " + CervAmstel + " (R$ 6,50)");
                }
                if (CervStella > 0)
                {
                    objArquivo.WriteLine("Stella: " + CervStella + " (R$ 7,50)");
                }
                if (CervBudweiser > 0)
                {
                    objArquivo.WriteLine("Budwiser: " + CervBudweiser + " (R$ 7,00)");
                }
                if (CervHeinekein > 0)
                {
                    objArquivo.WriteLine("Heinekein: " + CervHeinekein + " (R$ 8,00)");
                }
                if (CervCorona > 0)
                {
                    objArquivo.WriteLine("Corona: " + CervCorona + " (R$ 8,50)");
                }

                objArquivo.WriteLine("═════════════════════════════════════════════════════");
                objArquivo.WriteLine("Total Cerveja(s): " + TotalCervejas);
                objArquivo.WriteLine("═════════════════════════════════════════════════════");
                objArquivo.WriteLine("\n");
            }
            //--------------------------------------Se total suco diferente de 0, mostra o(os) suco(s)
            if (TotalSucos != "R$ 0,00")
            {
                objArquivo.WriteLine("Sucos(s): ");
                if (SucoLaranja > 0)
                {
                    objArquivo.WriteLine("Suco de Laranja: " + SucoLaranja + " (R$ 6,50)");
                }
                if (SucoMaracuja > 0)
                {
                    objArquivo.WriteLine("Suco de Maracujá: " + SucoMaracuja + " (R$ 7,00)");
                }
                if (SucoKiwi > 0)
                {
                    objArquivo.WriteLine("Suco de Kiwi: " + SucoKiwi + " (R$ 8,50)");
                }
                if (SucoLimão > 0)
                {
                    objArquivo.WriteLine("Suco de Limão: " + SucoLimão + " (R$ 6,00)");
                }
                if (SucoManga > 0)
                {
                    objArquivo.WriteLine("Suco de Manga: " + SucoManga + " (R$ 7,50)");
                }

                objArquivo.WriteLine("═════════════════════════════════════════════════════");
                objArquivo.WriteLine("Total Suco(s): " + TotalSucos);
                objArquivo.WriteLine("═════════════════════════════════════════════════════");
                objArquivo.WriteLine("\n");
            }
            //--------------------------------------Se total drinks diferente de 0, mostra o(os) drink(s)
            if (TotalDrinks != "R$ 0,00")
            {
                objArquivo.WriteLine("Drink(s): ");
                if (DrinkCaipirinha > 0)
                {
                    objArquivo.WriteLine("Caipirinha: " + DrinkCaipirinha + " (R$ 12,00)");
                }
                if (DrinkMartini > 0)
                {
                    objArquivo.WriteLine("Martini: " + DrinkMartini + " (R$ 9,00)");
                }
                if (DrinkPiñaColada > 0)
                {
                    objArquivo.WriteLine("Piña Colada: " + DrinkPiñaColada + " (R$ 13,00)");
                }
                if (DrinkCaipirosca > 0)
                {
                    objArquivo.WriteLine("Caipirosca: " + DrinkCaipirosca + " (R$ 15,00)");
                }
                if (DrinkMojito > 0)
                {
                    objArquivo.WriteLine("Mojito: " + DrinkMojito + " (R$ 14,00)");
                }

                objArquivo.WriteLine("═════════════════════════════════════════════════════");
                objArquivo.WriteLine("Total Drink(s): " + TotalDrinks);
                objArquivo.WriteLine("═════════════════════════════════════════════════════");
                objArquivo.WriteLine("\n");
            }
            //--------------------------------------Se total pratos diferente de 0, mostra o(os) prato(s)
            if (TotalPratos != "R$ 0,00")
            {
                objArquivo.WriteLine("Prato(s): ");
                if (PratoFeijoada > 0)
                {
                    objArquivo.WriteLine("Feijoada: " + PratoFeijoada + " (R$ 30,90)");
                }
                if (PratoMacarrão > 0)
                {
                    objArquivo.WriteLine("Macarrão: " + PratoMacarrão + " (R$ 28,50)");
                }
                if (PratoParmegiana > 0)
                {
                    objArquivo.WriteLine("Parmegiana: " + PratoParmegiana + " (R$ 32,00)");
                }
                if (PratoFeijãoTropeiro > 0)
                {
                    objArquivo.WriteLine("Feijão Tropeiro: " + PratoFeijãoTropeiro + " (R$ 37,00)");
                }
                if (PratoSelfService > 0)
                {
                    objArquivo.WriteLine("Self Service: " + PratoSelfService + " (R$ 29,90)");
                }

                objArquivo.WriteLine("═════════════════════════════════════════════════════");
                objArquivo.WriteLine("Total Prato(s): " + TotalPratos);
                objArquivo.WriteLine("═════════════════════════════════════════════════════");
                objArquivo.WriteLine("\n");
            }
            //--------------------------------------Se total porções diferente de 0, mostra a(as) porções(s)
            if (TotalPorções != "R$ 0,00")
            {
                objArquivo.WriteLine("Porção(ões): ");
                if (PorçãoPeixe > 0)
                {
                    objArquivo.WriteLine("Peixe à milanesa: " + PorçãoPeixe + " (R$ 35,00)");
                }
                if (PorçãoBatata > 0)
                {
                    objArquivo.WriteLine("Batata frita: " + PorçãoBatata + " (R$ 29,90)");
                }
                if (PorçãoFrango > 0)
                {
                    objArquivo.WriteLine("Frango à milanesa: " + PorçãoFrango + " (R$ 32,50)");
                }
                if (PorçãoCalabresa > 0)
                {
                    objArquivo.WriteLine("Calabresa: " + PorçãoCalabresa + " (R$ 28,70)");
                }
                if (PorçãoProvolone > 0)
                {
                    objArquivo.WriteLine("Provolone à milanesa: " + PorçãoProvolone + " (R$ 33,50)");
                }

                objArquivo.WriteLine("═════════════════════════════════════════════════════");
                objArquivo.WriteLine("Total Porção(ões): " + TotalPorções);
                objArquivo.WriteLine("═════════════════════════════════════════════════════");
                objArquivo.WriteLine("\n");
            }
            //--------------------------------------Se total lanches diferente de 0, mostra o(os) lanche(s)
            if (TotalLanches != "R$ 0,00")
            {
                objArquivo.WriteLine("Lanche(s): ");
                if (LancheBurguer > 0)
                {
                    objArquivo.WriteLine("Hamburguer: " + LancheBurguer + " (R$ 27,00)");
                }
                if (LancheSalada > 0)
                {
                    objArquivo.WriteLine("X-Salada: " + LancheSalada + " (R$ 25,00)");
                }
                if (LancheMilho > 0)
                {
                    objArquivo.WriteLine("X-Milho: " + LancheMilho + " (R$ 25,50)");
                }
                if (LanchePicanha > 0)
                {
                    objArquivo.WriteLine("X-Picanha: " + LanchePicanha + " (R$ 32,00)");
                }
                if (LancheX_Frango > 0)
                {
                    objArquivo.WriteLine("X-Frango: " + LancheX_Frango + " (R$ 29,00)");
                }

                objArquivo.WriteLine("═════════════════════════════════════════════════════");
                objArquivo.WriteLine("Total Lanche(s): " + TotalLanches);
                objArquivo.WriteLine("═════════════════════════════════════════════════════");
                objArquivo.WriteLine("\n");

            }

            objArquivo.WriteLine("═════════════════════════════════════════════════════");
            objArquivo.WriteLine("Subtotal : " + txtsubtotal);
            objArquivo.WriteLine("Taxa serviço (10%) : " + txtsubtotal2);
            objArquivo.WriteLine("═════════════════════════════════════════════════════");

            objArquivo.WriteLine("Forma de pagamento: ");
            if (txtcartDebit == true)
            {
                objArquivo.WriteLine("Cartão de debito (Desconto de 3%)");
            }
            if (txtcartCred == true)
            {
                objArquivo.WriteLine("Cartão de crédito (Acrescimo de 15%)");
            }
            if (txtpix == true)
            {
                objArquivo.WriteLine("PIX (Desconto de 5%)");
            }
            if (txtdinheiro == true)
            {
                objArquivo.WriteLine("Dinehiro (Desconto de 5%)");
            }

            objArquivo.WriteLine("═════════════════════════════════════════════════════");

            objArquivo.WriteLine("Total : " + txtfecharConta);

            objArquivo.WriteLine("═════════════════════════════════════════════════════");

            // fim da edição do arquivo de TEXTO--------------------------------------

            objArquivo.Close();
            // fecha o arquivo txt--------------------------------------

        }

       

     }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBar
{
    class ALLVARS
    {
        //---------------------------------------------------REFRIGERANTES

        public static int qtdCoca, qtdCocaZero, qtdKuat, qtdFanta, qtdSprite;

        public static float valorCoca, valorCocaZero, valorKuat, valorFanta, valorSprite, valorTotalRefri;
        public static float Coca = 5, CocaZero = 5, Kuat = 4.3f, Fanta = 4, Sprite = 4.5f;
        //---------------------------------------------------CERVEJAS

        public static int qtdAmstel, qtdStella, qtdBudweiser, qtdHeinekein, qtdCorona;

        public static float valorAmstel, valorStella, valorBudweiser, valorHeinekein, valorCorona, valorTotalCervejas;
        public static float Amstel = 6.5f, Stella = 7.5f, Budweiser = 7, Heinekein = 8, Corona = 8.5f;
        //---------------------------------------------------SUCOS

        public static int qtdLaranja, qtdMaracuja, qtdKiwi, qtdLimão, qtdManga;

        public static float valorLaranja, valorMaracuja, valorKiwi, valorLimão, valorManga, valorTotalSucos;
        public static float Laranja = 6.5f, Maracuja = 7, Kiwi = 8.5f, Limão = 6, Manga = 7.5f;
        //---------------------------------------------------DRINKS

        public static int qtdCaipirinha, qtdMartini, qtdPiñaColada, qtdCaipirosca, qtdMojito;

        public static float valorCaipirinha, valorMartini, valorPiñaColada, valorCaipirosca, valorMojito, valorTotalDrinks;
        public static float Caipirinha = 12, Martini = 9, PiñaColada = 13, Caipirosca = 15, Mojito = 14;
        //---------------------------------------------------PRATOS

        public static int qtdFeijoada, qtdMacarrão, qtdParmegiana, qtdFeijãoTropeiro, qtdSelfService;

        public static float valorFeijoada, valorMacarrão, valorParmegiana, valorFeijãoTropeiro, valorSelfService, valorTotalPratos;
        public static float Feijoada = 30.9f, Macarrão = 28.5f, Parmegiana = 32, FeijãoTropeiro = 37, SelfService = 29.90f;
        //---------------------------------------------------PORÇÕES

        public static int qtdPeixe, qtdBatata, qtdFrango, qtdCalabresa, qtdProvolone;

        public static float valorPeixe, valorBatata, valorCalabresa, valorFrango, valorProvolone, valorTotalPorções;
        public static float Peixe = 35, Batata = 29.9f, Frango = 32.5f, Calabresa = 28.7f, Provolone = 33.5f;
        //---------------------------------------------------LANCHES

        public static int qtdBurguer, qtdSalada, qtdMilho, qtdPicanha, qtdX_Frango;

        public static float valorBurguer, valorSalada, valorMilho, valorPicanha, valorX_Frango, valorTotalLanches;
        public static float Burguer = 27, Salada = 25, Milho = 25.5f, Picanha = 32, X_Frango = 29;
        //---------------------------------------------------TOTAIS

        public static float fecharConta, subtotal, taxaserviço = 0.1f, subtotal2, cartDebit = 0.03f, cartCred = 0.15f, pix = 0.05f, dinheiro = 0.05f;



        //---------------------------------------------------enviar email

        public static string email1 = "projetolp001@yahoo.com";
        public static string email2;
        public static string senha = "xbxontqeshzgonvy";
        public static string mensagem;

    }

}

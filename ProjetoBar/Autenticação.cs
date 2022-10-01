using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBar
{
    class Autenticação
    {
        static string email;
        static string senha;

        //--------------------------------------AUTENTICAÇÃO DE LOGIN
        public static void login(string email1, string senha1)
        {
            email = email1;
            senha = senha1;
        }

        public static void cancelar()
        {
            email = null;
            senha = null;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace ProjetoBar
{
    class Conexão
    {
        //--------------------------------------TIPO DE CONEXÃO
        public OleDbConnection cn = new OleDbConnection();


        //--------------------------------------LOCAL DA CONEXÃO(ONDE LOCALIZA O BANCO DE DADOS)
        public void conectar()
        {
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\C#\ProjetoBar\DatabaseLogin.accdb";
            cn.Open();
        }


        //--------------------------------------FECHA A CONEXÃO
        
        public void desconectar()
        {
            cn.Close();
        }
        

    }
}

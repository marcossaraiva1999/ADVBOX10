using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADVBOX
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();

        //Construtor
        public Conexao()
        {
            con.ConnectionString = @"Data Source=laptop-01k5lkeh\sqlexpress;Initial Catalog=comandosoft;Integrated Security=True";
        }
        public SqlConnection conectar()
        {

                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                return con;
            
        }

        public void descontectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SwingSuit
{
    static class Conector
    {

        public static MySqlConnectionStringBuilder builder;

        public static String conexion()
        {



            builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "root";
            builder.Database = "banador";
            
          
           

            return builder.ToString();
        }

    }
}
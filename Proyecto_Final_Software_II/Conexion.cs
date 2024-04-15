using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_Final_Software_II
{
    class Conexion
    {
       public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("SERVER = DESKTOP-VIITSAH\SEBASTIAN;DATABASE;BdEscuela;Integrate Security=true");
            cn.Open();
            return cn;
        }

    } 
    
    
}
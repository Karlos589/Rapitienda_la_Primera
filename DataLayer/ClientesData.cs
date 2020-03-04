using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataLayer
{
    public class ClientesData
    {
        public static bool ProbarConexion()
        {
            using (SqlConnection conex = new SqlConnection
                (ConfigurationManager.ConnectionStrings["Conex_Rapitienda"].ConnectionString))
            {
                conex.Open();
                if (conex.State == ConnectionState.Open)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
            
    }
}

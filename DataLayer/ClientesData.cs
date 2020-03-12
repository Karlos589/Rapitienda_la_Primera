using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;
using Entities;


namespace DataLayer
{
    public class ClientesData
    {
        public static MySqlConnection ConexionBD()
        {
             MySqlConnection conex = new MySqlConnection
             ("Server=127.0.0.1;"+
             "Database=bdRapitienda;" +
             "Uid=root;"+
             "Pwd=;"+
             "SslMode=None");
            return conex;
        }

        public static bool GuardarCliente(ClientesEntity cliente)
        {
            MySqlConnection conex = ConexionBD();
            conex.Open();
            string sql = @"INSERT INTO tbcliente
                         (TipoDocumento, NumeroDocumento, PrimerNombre,
                          SegundoNombre,PrimerApellido, SegundoApellido,Direccion,Email,Telefono,FechaNacimiento)
                           VALUES
                           (
                            @TipoDocumento,@NumeroDocumento,@PrimerNombre,
                            @SegundoNombre,@PrimerApellido,@SegundoApellido,
                            @Direccion,@Email,@Telefono,@FechaNacimiento )";

            MySqlCommand cmd = new MySqlCommand(sql, conex);

            cmd.Parameters.AddWithValue("@TipoDocumento",cliente.TipoDocumento);
            cmd.Parameters.AddWithValue("@NumeroDocumento", cliente.Documento);
            cmd.Parameters.AddWithValue("@PrimerNombre", cliente.PrimerNombre);
            cmd.Parameters.AddWithValue("@SegundoNombre", cliente.SegundoNombre);
            cmd.Parameters.AddWithValue("@PrimerApellido", cliente.PrimerApellido);
            cmd.Parameters.AddWithValue("@SegundoApellido", cliente.SegundoApellido);
            cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);
            cmd.Parameters.AddWithValue("@Email", cliente.email);
            cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
            cmd.Parameters.AddWithValue("@FechaNacimiento", cliente.FechaNacimiento);

            int NumeroFilas = Convert.ToInt32(cmd.ExecuteNonQuery());
            if (NumeroFilas > 0)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        public static List<ClientesEntity> ObtenerClientes()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataLayer;

namespace BussinesLayer
{
    public class ClientesBusiness
    {
        
        public static bool GuardarCliente(ClientesEntity cliente)
        {
            return ClientesData.GuardarCliente(cliente);
        }
    }
}

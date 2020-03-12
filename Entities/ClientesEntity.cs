using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ClientesEntity
    {
        public int idCliente { get; set; }
        public string TipoDocumento { get; set; }
        public string Documento { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Direccion { get; set; }
        public string email { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
       
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClienteRenta_ADO;
using ClienteRenta_BE;

namespace ClienteRenta_BL
{
    public class ClienteBL
    {
        ClienteADO objClienteADO = new ClienteADO();

        public DataTable ListarCliente()
        {
            return objClienteADO.ListarCliente();
        }

        public ClienteBE ConsultarCliente(String strCodigo)
        {
            return objClienteADO.ConsultarCliente(strCodigo);
        }
        public Boolean InsertarCliente(ClienteBE objClienteBE)
        {
            return objClienteADO.InsertarCliente(objClienteBE);
        }
        public Boolean EditarCliente(ClienteBE objClienteBE)
        {
            return objClienteADO.EditarCliente(objClienteBE);
        }
    }
}

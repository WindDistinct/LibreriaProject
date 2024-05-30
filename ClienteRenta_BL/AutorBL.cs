using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClienteRenta_ADO;
using ClienteRenta_BE;
using Libreria_BE;
namespace ClienteRenta_BL
{
    public class AutorBL
    {
        AutorADO objAutorADO = new AutorADO();

        public DataTable ListarAutor()
        {
            return objAutorADO.ListarAutor();
        }

        public AutorBE ConsultarAutor(String strCodigo)
        {
            return objAutorADO.ConsultarAutor(strCodigo);
        }
        public Boolean InsertarAutor(AutorBE objAutorBE)
        {
            return objAutorADO.InsertarAutor(objAutorBE);
        }
        public Boolean EditarAutor(AutorBE objAutorBE)
        {
            return objAutorADO.EditarAutor(objAutorBE);
        }
    }
}
    
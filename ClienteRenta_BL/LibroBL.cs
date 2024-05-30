using Libreria_ADO;
using Libreria_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_BL
{
    public class LibroBL
    {
        LibroADO objLibroADO = new LibroADO();

        public DataTable ListarLibro()
        {
            return objLibroADO.ListarLibro();
        }

        public LibroBE ConsultarLibro(String strCodigo)
        {
            return objLibroADO.ConsultarLibro(strCodigo);
        }
        public Boolean InsertarLibro(LibroBE objLibroBE)
        {
            return objLibroADO.InsertarLibro(objLibroBE);
        }
        public Boolean EditarLibro(LibroBE objLibroBE)
        {
            return objLibroADO.EditarLibro(objLibroBE);
        }
    }
}

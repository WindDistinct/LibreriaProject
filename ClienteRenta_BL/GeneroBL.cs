using Libreria_ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_BL
{
    public class GeneroBL
    {
        GeneroADO objGeneroADO = new GeneroADO();

        public DataTable ListarGenero()
        {
            return objGeneroADO.ListarGenero();
        }
    }
}

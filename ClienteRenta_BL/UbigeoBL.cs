using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria_BE;
using Libreria_ADO;

namespace Libreria_BL
{
    public class UbigeoBL
    {
        UbigeoADO objUbigeoADO = new UbigeoADO();

        public DataTable ListarUbigeo()
        {
            return objUbigeoADO.ListarUbigeo();
        }
    }
}

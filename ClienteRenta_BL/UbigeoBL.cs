using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClienteRenta_ADO;

namespace ClienteRenta_BL
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

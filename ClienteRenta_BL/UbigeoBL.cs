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

        public DataTable Ubigeo_Region()
        {
            return objUbigeoADO.Ubigeo_Region();
        }
        public DataTable Ubigeo_ProvinciasRegion(String strIdRegion)
        {
            return objUbigeoADO.Ubigeo_ProvinciasRegion(strIdRegion);
        }
        public DataTable Ubigeo_DistritosProvinciaRegion(String strIdRegion, String strIdProvincia)
        {
            return objUbigeoADO.Ubigeo_DistritosProvinciaRegion(strIdRegion, strIdProvincia);
        }
    }
}

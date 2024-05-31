using Libreria_ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_BL
{
    public class EditorialBL
    {
        EditorialADO objEditorialADO = new EditorialADO();

        public DataTable ListarEditorial()
        {
            return objEditorialADO.ListarEditorial();
        }
    }
}

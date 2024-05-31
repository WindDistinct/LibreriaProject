using Libreria_ADO;
using Libreria_BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_BL
{
    public class PersonalBL
    {
        PersonalADO objPersonalADO = new PersonalADO();

        public PersonalBE ValidarUsuario(String user, String pass)
        {
            return objPersonalADO.ValidarUsuario(user,pass);
        }
    }
}

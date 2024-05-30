using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_BE
{
    public class AutorBE
    {public Int16 aut_id { get;set;}
        public String aut_nom { get;set;}
        public String aut_ape { get;set;}
        public Byte[] aut_foto { get;set;}
        public String aut_pais { get;set;}
        public String aut_user_reg { get; set;}
        public DateTime aut_fec_reg { get; set;}
        public String aut_user_mod { get; set;}
        public DateTime aut_fec_mod { get; set;}
        public Boolean aut_state { get; set;}

    }
}

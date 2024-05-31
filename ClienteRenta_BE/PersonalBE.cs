using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_BE
{
    public class PersonalBE
    {
        public String per_nom { get; set; }
        public String per_ape_pat { get; set; }
        public String per_ape_mat { get; set; }
        public String per_dir { get; set; }
        public Int16 ubg_id { get; set; }
        public String per_tel { get; set; }
        public String per_dni { get; set; }
        public String per_mail { get; set; }
        public String per_pass { get; set; }
        public byte[] per_foto { get; set; }
        public DateTime per_fec_ing { get; set; }
        public String per_user_reg { get; set; }
        public DateTime per_fec_reg { get; set; }
        public String per_user_mod { get; set; }
        public String per_fec_mod { get; set; }
        public Boolean per_state { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteRenta_BE
{
    public class ClienteBE
    {
        public Int16 cli_id {  get; set; }
        public String cli_nom { get; set; }
        public String cli_ape {  get; set; }
        public String cli_dir { get; set; }
        public String cli_tel { get; set; }
        public String cli_mail { get; set; }
        public String cli_dni { get; set; }
        public Int16 ubg_id { get; set; }
        public DateTime cli_fec_nac { get; set; }
        public Char cli_sex { get; set; }
        public Byte[] cli_foto { get; set; }
        public Int16 cli_memb_tipo { get; set; }
        public DateTime cli_memb_cad {  get; set; }
        public String cli_user_reg { get; set; }
        public DateTime cli_fec_reg { get; set; }
        public String cli_user_mod { get; set; }
        public DateTime cli_fec_mod { get; set; }
        public Boolean cli_state {  get; set; }

    }
}

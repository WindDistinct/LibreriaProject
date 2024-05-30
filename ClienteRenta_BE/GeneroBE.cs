using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_BE
{
    public class GeneroBE
    {
        public Int16 gen_id {  get; set; }
        public String gen_desc { get; set; }
        public String gen_user_reg {  get; set; }
        public DateTime gen_fec_reg { get; set; }
        public String gen_user_mod { get; set; }
        public DateTime gen_fec_mod {  get; set; }
    }
}

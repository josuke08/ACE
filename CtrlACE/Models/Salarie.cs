using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CtrlACE.Models
{
    public class Salarie
    {
        private String id { get; set; }
        public String nom { get; set; }
        public String prenom { get; set; }
        public String fonction { get; set; }
        public Double salaire { get; set; }
        public String departementId { get; set; }
    }
}

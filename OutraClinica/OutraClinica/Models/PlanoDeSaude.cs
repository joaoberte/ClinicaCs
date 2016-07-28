using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OutraClinica.Models
{
    public class PlanoDeSaude
    {
        public int PlanoDeSaudeID { get; set; }

        public string nome { get; set; }

        public virtual ICollection<Consulta> Consultas { get; set; }
    }
}
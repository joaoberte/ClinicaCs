using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OutraClinica.Models
{
    public class Consulta
    {
        public int ConsultaID { get; set; }

        public DateTime Data { get; set; }

        public DateTime Hora { get; set; }

        public int PlanoDeSaudeID { get; set; }
        public virtual PlanoDeSaude PlanoDeSaude { get; set; }

        public int PacienteID { get; set; }
        public virtual Paciente Paciente { get; set; }

        public int MedicoID { get; set; }
        public virtual Medico Medico { get; set; }
    }
}
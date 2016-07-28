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
        public PlanoDeSaude PlanoDeSaude { get; set; }

        public int PacienteID { get; set; }
        public Paciente Paciente { get; set; }
    }
}
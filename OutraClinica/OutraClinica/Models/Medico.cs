using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OutraClinica.Models
{
    public class Medico : Funcionario
    {
        public string especialidades { get; set; }
    }
}
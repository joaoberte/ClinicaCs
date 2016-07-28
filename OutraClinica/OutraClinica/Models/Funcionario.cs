using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OutraClinica.Models
{
    public class Funcionario
    {
        public int FuncionarioID { get; set; }

        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string rg { get; set; }

        public string endereco { get; set; }

        public string login { get; set; }

        public string senha { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicos
{
    public class InserirPacienteDTO
    {
        public string Nome { get; set; }

        public string Cpf {  get; set; }

        public DateTime DataNascimento { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public string? Endereco { get; set; }
    }
}

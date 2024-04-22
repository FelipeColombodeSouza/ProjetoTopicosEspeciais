using Entidades;

namespace Servicos
{
    public class InserirAtendimentoDTO
    {
        public string? Descricao { get; set; }

        public decimal Valor { get; set; }

        public DateTime DataConsulta { get; set; }

        public int CodigoPaciente { get; set; }

        public int CodigoProfissional { get; set; }
    }
}

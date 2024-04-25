using Entidades;

namespace Servicos
{
    public class EditarAtendimentoDTO 
    {
        public string Descricao { get; set; }

        public DateTime? DataConsulta { get; set; }

        public int? CodigoProfissional { get; set; }
    }
}

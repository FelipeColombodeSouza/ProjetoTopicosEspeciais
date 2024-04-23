using Entidades;
using Repositorio;

namespace Servicos
{
    public interface IServAtendimento
    {
        void Inserir(InserirAtendimentoDTO inserirAtendimentoDto);
    }

    public class ServAtendimento : IServAtendimento
    {
        private IRepoAtendimento _repoAtendimento;

        public ServAtendimento(IRepoAtendimento repoAtendimento)
        {
            _repoAtendimento = repoAtendimento;
        }

        public void Inserir(InserirAtendimentoDTO inserirAtendimentoDto)
        {
            var atendimento = new Atendimento();

            atendimento.Descricao = inserirAtendimentoDto?.Descricao;
            atendimento.Valor = inserirAtendimentoDto.Valor;
            atendimento.DataConsulta = inserirAtendimentoDto.DataConsulta;
            atendimento.CodigoPaciente = inserirAtendimentoDto.CodigoPaciente;
            atendimento.CodigoProfissional = inserirAtendimentoDto.CodigoProfissional;
            atendimento.Status = EnumConsultaStatus.Agendado;

            _repoAtendimento.Inserir(atendimento);
        }
    }
}

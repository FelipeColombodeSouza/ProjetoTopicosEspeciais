using Entidades;
using Repositorio;
using System.Linq;

namespace Servicos
{
    public interface IServAtendimento
    {
        void Inserir(InserirAtendimentoDTO inserirAtendimentoDto);
        void Editar(int id, EditarAtendimentoDTO editarAtendimentoDto);
        List<Atendimento> BuscarTodos();
        Atendimento BuscarPorId(int id);
        void Remover(int id);
        List<Atendimento> BuscarHistoricoPaciente(int id);
        List<Atendimento> BuscarHistoricoProfissional(int id);
        void IniciarAtendimento(int id);
        void FinalizarAtendimento(int id);
        void CancelarAtendimento(int id);
    }

    public class ServAtendimento : IServAtendimento
    {
        private IRepoAtendimento _repoAtendimento;
        private IServPaciente _servPaciente;
        private IServProfissional _servProfissional;

        public ServAtendimento(IRepoAtendimento repoAtendimento, IServPaciente servPaciente, IServProfissional servProfissional)
        {
            _repoAtendimento = repoAtendimento;
            _servPaciente = servPaciente;
            _servProfissional = servProfissional;
        }

        public void Inserir(InserirAtendimentoDTO inserirAtendimentoDto)
        {

            ValidaDadosInserirAtendimento(inserirAtendimentoDto);

            var atendimento = new Atendimento();

            atendimento.Descricao = inserirAtendimentoDto.Descricao;
            atendimento.Valor = inserirAtendimentoDto.Valor;
            atendimento.DataConsulta = inserirAtendimentoDto.DataConsulta;
            atendimento.CodigoPaciente = inserirAtendimentoDto.CodigoPaciente;
            atendimento.CodigoProfissional = inserirAtendimentoDto.CodigoProfissional;
            atendimento.Status = EnumConsultaStatus.Agendado;

            _repoAtendimento.Inserir(atendimento);
        }

        public void ValidaDadosInserirAtendimento(InserirAtendimentoDTO inserirAtendimentoDto)
        {
            var profissional = _servProfissional.BuscarPorId(inserirAtendimentoDto.CodigoProfissional);

            var paciente = _servPaciente.BuscarPorId(inserirAtendimentoDto.CodigoPaciente);

            if (profissional == null)
            {
                throw new Exception("Profissional inválido.");
            }

            if (paciente == null)
            {
                throw new Exception("Paciente inválido.");
            }

            var AtendimentosProfissional = _repoAtendimento.BuscarHistoricoProfissional(profissional.Id);
            IEnumerable<Atendimento> AtendProfData = Enumerable.Where(AtendimentosProfissional, n => n.DataConsulta == inserirAtendimentoDto.DataConsulta);
            if(AtendProfData.Count() >= 1)
            {
                throw new Exception("Já existe um atendimento para o profissional " + profissional.Nome + " na data: " + AtendProfData.First().DataConsulta.ToString());
            }

            var AtendimentosPaciente = _repoAtendimento.BuscarHistoricoPaciente(paciente.Id);
            IEnumerable<Atendimento> AtendPaciData = Enumerable.Where(AtendimentosPaciente, n => n.DataConsulta == inserirAtendimentoDto.DataConsulta);
            if (AtendPaciData.Count() >= 1)
            {
                throw new Exception("Já existe um atendimento para o paciente " + paciente.Nome + " na data: " + AtendPaciData.First().DataConsulta.ToString());
            }

        }

        public void Editar(int id, EditarAtendimentoDTO editarAtendimentoDto)
        {
            var atendimento = _repoAtendimento.BuscarPorId(id);

            if(atendimento != null)
            {
                atendimento.Descricao = editarAtendimentoDto.Descricao;
                atendimento.DataConsulta = editarAtendimentoDto.DataConsulta ?? atendimento.DataConsulta;
                atendimento.CodigoProfissional = editarAtendimentoDto.CodigoProfissional ?? atendimento.CodigoProfissional;

                _repoAtendimento.Editar(atendimento);
            }
            else
            {
                throw new Exception("Atendimento não encontrado.");
            }
        }

        public List<Atendimento> BuscarTodos()
        {
            var atendimentos = _repoAtendimento.BuscarTodos();

            return atendimentos;
        }

        public Atendimento BuscarPorId(int id)
        {
            var atendimento = _repoAtendimento.BuscarPorId(id);

            return atendimento;
        }

        public void Remover(int id)
        {
            if (id != null)
            {
                var atendimento = _repoAtendimento.BuscarPorId(id);

                if(atendimento != null)
                {
                _repoAtendimento.Remover(atendimento);

                }else
                {
                    throw new Exception("Atendimento não encontrado.");
                }


            }
            else
            {
                throw new Exception("Código inválido.");
            }


        }

        public List<Atendimento> BuscarHistoricoPaciente(int id)
        {
            var paciente = _servPaciente.BuscarPorId(id);

            if (paciente != null)
            {
                var historicoPaciente = _repoAtendimento.BuscarHistoricoPaciente(paciente.Id);

                return historicoPaciente;
            }
            else
            {
                throw new Exception("Paciente não encontrado.");

            }

        }

        public List<Atendimento> BuscarHistoricoProfissional(int id)
        {
            var profissional = _servProfissional.BuscarPorId(id);

            if (profissional != null)
            {
                var historicoProfissional = _repoAtendimento.BuscarHistoricoPaciente(profissional.Id);

                return historicoProfissional;
            }
            else
            {
                throw new Exception("Profissional não encontrado.");

            }

        }

        public void IniciarAtendimento(int id)
        {
            var atendimento = _repoAtendimento.BuscarPorId(id);

            if(atendimento != null)
            {
                atendimento.Status = EnumConsultaStatus.EmAndamento;
                _repoAtendimento.Editar(atendimento);

            }else
            {
                throw new Exception("Atendimento não encontrado");
            }
        }

        public void FinalizarAtendimento(int id)
        {
            var atendimento = _repoAtendimento.BuscarPorId(id);

            if (atendimento != null)
            {
                atendimento.Status = EnumConsultaStatus.Finalizada;
                _repoAtendimento.Editar(atendimento);
            }
            else
            {
                throw new Exception("Atendimento não encontrado");
            }
        }

        public void CancelarAtendimento(int id)
        {
            var atendimento = _repoAtendimento.BuscarPorId(id);

            if (atendimento != null)
            {
                atendimento.Status = EnumConsultaStatus.Cancelada;
                _repoAtendimento.Editar(atendimento);
            }
            else
            {
                throw new Exception("Atendimento não encontrado");
            }
        }
    }
}

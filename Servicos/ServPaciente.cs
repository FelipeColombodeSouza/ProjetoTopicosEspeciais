using Entidades;
using Repositorio;

namespace Servicos
{

    public interface IServPaciente
    {
        void Inserir(InserirPacienteDTO inserirPacienteDto);
    }

    public class ServPaciente: IServPaciente
    {
        private IRepoPaciente  _repoPaciente;

        public ServPaciente(IRepoPaciente repoPaciente)
        {
            _repoPaciente = repoPaciente;
        }

        public void Inserir(InserirPacienteDTO pacienteDto)
        {
            var paciente = new Paciente();
            paciente.Nome = pacienteDto.Nome;
            paciente.Cpf = pacienteDto.Cpf;
            paciente.DataNascimento = pacienteDto.DataNascimento;
            paciente.Telefone = pacienteDto.Telefone;
            paciente.Endereco = pacienteDto.Endereco;

            _repoPaciente.Inserir(paciente);
        }
    }
}

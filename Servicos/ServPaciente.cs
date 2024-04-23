using Entidades;
using Repositorio;

namespace Servicos
{

    public interface IServPaciente
    {
        void Inserir(InserirPacienteDTO inserirPacienteDto);
        void Editar(int id, EditarPacienteDTO editarPacienteDto);
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
            paciente.Email = pacienteDto.Email;
            paciente.Telefone = pacienteDto.Telefone;
            paciente.Endereco = pacienteDto.Endereco;

            _repoPaciente.Inserir(paciente);
        }

        public void Editar(int id, EditarPacienteDTO editarPacienteDto)
        {
            var paciente = _repoPaciente.BuscarPorId(id);

            paciente.Nome = editarPacienteDto.Nome;
            paciente.Email = editarPacienteDto.Email;
            paciente.Telefone = editarPacienteDto.Telefone;
            paciente.Endereco = editarPacienteDto.Endereco;

            _repoPaciente.Editar(paciente);
        }
    }
}

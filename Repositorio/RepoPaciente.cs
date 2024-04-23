using Entidades;

namespace Repositorio
{
    public interface IRepoPaciente
    {
        void Inserir(Paciente paciente);
        void Editar(Paciente paciente);
        List<Paciente> BuscarTodos();
        Paciente BuscarPorId(int id);
        void Remover(Paciente paciente);
    }
    public class RepoPaciente : IRepoPaciente
    {
        private DataContext _dataContext;

        public RepoPaciente(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Inserir(Paciente paciente)
        {

            _dataContext.Add(paciente);

            _dataContext.SaveChanges();
        }

        public void Editar(Paciente paciente)
        {
            _dataContext.SaveChanges();
        }

        public List<Paciente> BuscarTodos()
        {
            var pacientes = _dataContext.Paciente.ToList();

            return pacientes;
        }

        public Paciente BuscarPorId(int id)
        {
            var paciente = _dataContext.Paciente.Where(p => p.Id == id).FirstOrDefault();

            return paciente;
        }

        public void Remover(Paciente paciente)
        {
            _dataContext.Remove(paciente);

            _dataContext.SaveChanges();
        }

    }
}

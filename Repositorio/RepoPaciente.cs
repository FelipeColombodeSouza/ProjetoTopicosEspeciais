using Entidades;

namespace Repositorio
{
    public interface IRepoPaciente
    {
        void Inserir(Paciente paciente);
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

    }
}

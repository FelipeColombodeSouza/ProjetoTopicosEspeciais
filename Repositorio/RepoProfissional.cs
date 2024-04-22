using Entidades;

namespace Repositorio
{
    public interface IRepoProfissional
    {
        void Inserir(Profissional profissional);
    }
    public class RepoProfissional : IRepoProfissional
    {
        private DataContext _dataContext;

        public RepoProfissional(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Inserir(Profissional profissional)
        {
            _dataContext.Add(profissional);

            _dataContext.SaveChanges();
        }

    }
}

using Entidades;

namespace Repositorio
{
    public interface IRepoProfissional
    {
        void Inserir(Profissional profissional);
        void Editar(Profissional profissional);
        List<Profissional> BuscarTodos();
        Profissional BuscarPorId(int id);
        void Remover(Profissional profissional);
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

        public void Editar(Profissional profissional)
        {
            _dataContext.SaveChanges();
        }

        public List<Profissional> BuscarTodos()
        {
            var profissionais = _dataContext.Profissional.ToList();

            return profissionais;
        }

        public Profissional BuscarPorId(int id)
        {
            var profissional = _dataContext.Profissional.Where(p => p.Id == id).FirstOrDefault();

            return profissional;
        }

        public void Remover(Profissional profissional)
        {
            _dataContext.Remove(profissional);  

            _dataContext.SaveChanges();
        }

    }
}

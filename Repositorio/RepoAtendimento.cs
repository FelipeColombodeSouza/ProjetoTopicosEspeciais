using Entidades;

namespace Repositorio
{
    public interface IRepoAtendimento
    {
        void Inserir(Atendimento atendimento);
    }
    public class RepoAtendimento : IRepoAtendimento
    {
        private DataContext _dataContext;

        public RepoAtendimento(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Inserir(Atendimento atendimento)
        {
            _dataContext.Add(atendimento);

            _dataContext.SaveChanges();
        }

    }
}

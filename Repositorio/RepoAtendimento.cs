using Entidades;

namespace Repositorio
{
    public interface IRepoAtendimento
    {
        void Inserir(Atendimento atendimento);
        void Editar(Atendimento atendimento);
        List<Atendimento> BuscarTodos();
        Atendimento BuscarPorId(int id);
        void Remover(Atendimento atendimento);
        List<Atendimento> BuscarHistoricoPaciente(int id);
        List<Atendimento> BuscarHistoricoProfissional(int id);
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

        public void Editar(Atendimento atendimento)
        {
            _dataContext.SaveChanges();
        }

        public List<Atendimento> BuscarTodos()
        {
            var atendimentos = _dataContext.Atendimento.ToList();

            return atendimentos;
        }

        public Atendimento BuscarPorId(int id)
        {
            var atendimento = _dataContext.Atendimento.Where(p =>  p.Id == id).FirstOrDefault();

            return atendimento;
        }

        public void Remover(Atendimento atendimento)
        {
            _dataContext.Remove(atendimento);

            _dataContext.SaveChanges();
        }

        public List<Atendimento> BuscarHistoricoPaciente(int id)
        {
            var atendimentosPaciente = _dataContext.Atendimento.Where(p => p.CodigoPaciente == id).ToList();

            return atendimentosPaciente;
        }

        public List<Atendimento> BuscarHistoricoProfissional(int id)
        {
            var atendimentosPaciente = _dataContext.Atendimento.Where(p => p.CodigoProfissional == id).ToList();

            return atendimentosPaciente;
        }

    }
}

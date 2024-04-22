using Entidades;
using Repositorio;
using Servicos.DTO;

namespace Servicos
{
    public interface IServProfissional
    {
        void Inserir(ProfissionalDTO inserirProfissionalDto);
        void Editar(int id, ProfissionalDTO inserirProfissionalDto);
        List<Profissional> BuscarTodos();
        Profissional BuscarPorId(int id);
        void Remover(int id);
    }
    public class ServProfissional : IServProfissional
    {
        private IRepoProfissional _repoProfissional;

        public ServProfissional(IRepoProfissional repoProfissional)
        {
            _repoProfissional = repoProfissional;
        }

        public void Inserir(ProfissionalDTO inserirProfissionalDto)
        {
            var profissional = new Profissional();

            profissional.Nome = inserirProfissionalDto.Nome;
            profissional.Endereco = inserirProfissionalDto.Endereco;
            profissional.Crm = inserirProfissionalDto.Crm;

            _repoProfissional.Inserir(profissional);
        }

        public void Editar(int id, ProfissionalDTO editarProfissionalDto)
        {
            var profissional = _repoProfissional.BuscarPorId(id);

            profissional.Nome = editarProfissionalDto.Nome;
            profissional.Endereco = editarProfissionalDto.Endereco;
            profissional.Crm = editarProfissionalDto.Crm;

            _repoProfissional.Editar(profissional);
        }

        public List<Profissional> BuscarTodos()
        {
            var profissionais = _repoProfissional.BuscarTodos();    

            return profissionais;
        }

        public Profissional BuscarPorId(int id)
        {
            var profissional = _repoProfissional.BuscarPorId(id);

            return profissional;
        }

        public void Remover(int id)
        {
            var profissional = _repoProfissional.BuscarTodos().Where(p => p.Id == id).FirstOrDefault();

            _repoProfissional.Remover(profissional);
        }
    }
}

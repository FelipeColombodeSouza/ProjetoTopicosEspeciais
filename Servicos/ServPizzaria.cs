using Entidades;
using Repositorio;

namespace Servicos
{/*
    public interface IServPizzaria
    {
        void Inserir(InserirPizzariaDTO inserirPizzariaDto);
        void Editar(int id, EditarPizzariaDTO editarPizzariaDto);
        List<Pizzaria> BuscarTodos();
        Pizzaria BuscarPorId(int id);
        void Remover(int id);

        void AtualizarInformacoesDaPromocao(int id, DateTime dataVigenciaPromocao, decimal valorPromocao);
    }

    public class ServPizzaria : IServPizzaria
    {
        private IRepoPizzaria _repoPizzaria;

        public ServPizzaria(IRepoPizzaria repoPizzaria)
        {
            _repoPizzaria = repoPizzaria;
        }

        public void Inserir(InserirPizzariaDTO inserirPizzariaDto)
        {
            var pizzaria = new Pizzaria();

            pizzaria.Nome = inserirPizzariaDto.Nome;
            pizzaria.Telefone = inserirPizzariaDto.Telefone;
            pizzaria.Endereco = inserirPizzariaDto.Endereco;

            ValidacoesAntesDeInserir(pizzaria);

            _repoPizzaria.Inserir(pizzaria);
        }

        public void ValidacoesAntesDeInserir(Pizzaria pizzaria)
        {
            if (pizzaria.Nome.Length < 40)
            {
                throw new Exception("Nome inválido. Deve possuir no mínimo 40 caracteres.");
            }
        }

        public void Editar(int id, EditarPizzariaDTO editarPizzariaDto)
        {
            var pizzaria = _repoPizzaria.BuscarPorId(id);

            pizzaria.Nome = editarPizzariaDto.Nome;
            pizzaria.Telefone = editarPizzariaDto.Telefone;
            pizzaria.Endereco = editarPizzariaDto.Endereco;

            _repoPizzaria.Editar(pizzaria);
        }

        public List<Pizzaria> BuscarTodos()
        {
            var pizzarias = _repoPizzaria.BuscarTodos();

            return pizzarias;
        }

        public Pizzaria BuscarPorId(int id)
        {
            var pizzaria = _repoPizzaria.BuscarPorId(id);

            return pizzaria;
        }


        public void Remover(int id)
        {
            var pizzaria = _repoPizzaria.BuscarTodos().Where(p => p.Id == id).FirstOrDefault();

            _repoPizzaria.Remover(pizzaria);
        }

        public void AtualizarInformacoesDaPromocao(int id, DateTime dataVigenciaPromocao, decimal valorPromocao)
        {
            var pizzaria = _repoPizzaria.BuscarTodos().Where(p => p.Id == id).FirstOrDefault();

            pizzaria.DataVigenciaPromover = dataVigenciaPromocao;
            pizzaria.ValorPromover = valorPromocao;
        }
    }*/
}

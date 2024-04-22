using Entidades;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicos
{/*
    public interface IServPromover
    {
        void Inserir(InserirPromoverDTO inserirDto);

        void Efetivar(int id);
    }

    public class ServPromover : IServPromover
    {
        private IRepoPromover _repoPromover;
        private IServPizzaria _servPizzaria;

        public ServPromover(IRepoPromover repoPromover, IServPizzaria servPizzaria)
        {
            _repoPromover = repoPromover;
            _servPizzaria = servPizzaria;
        }

        public void Inserir(InserirPromoverDTO inserirDto)
        {
            var promover = new Promover();

            promover.Descricao = inserirDto.Descricao;
            promover.DataVigencia = inserirDto.DataVigencia;
            promover.CodigoPizzaria = inserirDto.CodigoPizzaria;
            promover.Valor = inserirDto.Valor;

            _repoPromover.Inserir(promover);
        }

        public void Efetivar(int id)
        {
            var promover = _repoPromover.BuscarPorId(id);

            promover.Status = EnumStatusPromover.Efetivado;

            _servPizzaria.AtualizarInformacoesDaPromocao(promover.CodigoPizzaria, promover.DataVigencia, promover.Valor);

            _repoPromover.SalvarEfetivacao();
        }
    }*/
}

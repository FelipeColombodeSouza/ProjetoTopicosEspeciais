using Microsoft.AspNetCore.Mvc;
using Servicos;

namespace Apresentacao
{
    [Route("api/[Controller]")]
    [ApiController]
    public class AtendimentoController: ControllerBase
    {
        private IServAtendimento _servAtendimento;

        public AtendimentoController(IServAtendimento servAtendimento)
        {
            _servAtendimento = servAtendimento;
        }

        [Route("/api/[controller]/Inserir")]
        [HttpPost]
        public ActionResult Inserir(InserirAtendimentoDTO inserirAtendimentoDTO)
        {
            try
            {
                _servAtendimento.Inserir(inserirAtendimentoDTO);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Route("/api/[controller]/Editar/{id}")]
        [HttpPut]
        public ActionResult Editar(int id, [FromBody]EditarAtendimentoDTO editarAtendimentoDto)
        {
            try
            {
                _servAtendimento.Editar(id, editarAtendimentoDto);

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Route("/api/[controller]/BuscarTodos")]
        [HttpGet]
        public ActionResult BuscarTodos() {
            try
            {
                var atendimentos = _servAtendimento.BuscarTodos();

                return Ok(atendimentos);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Route("/api/[controller]/BuscarPorId/{id}")]
        [HttpGet]
        public ActionResult BuscarPorId(int id)
        {
            try
            {
                var atendimento = _servAtendimento.BuscarPorId(id);

                return Ok(atendimento);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Route("/api/[controller]/Remover/{id}")]
        [HttpDelete]
        public ActionResult Remover(int id)
        {
            try
            {
                _servAtendimento.Remover(id);

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Route("/api/[controller]/HistoricoPaciente/{id}")]
        [HttpGet]
        public ActionResult BuscarHistoricoPaciente(int id)
        {
            try
            {
                var historicoPaciente = _servAtendimento.BuscarHistoricoPaciente(id);

                return Ok(historicoPaciente);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Route("/api/[controller]/HistoricoProfissional/{id}")]
        [HttpGet]
        public ActionResult BuscarHistoricoProfissional(int id)
        {
            try
            {
                var historicoProfissional = _servAtendimento.BuscarHistoricoProfissional(id);

                return Ok(historicoProfissional);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Route("/api/[controller]/IniciarAtendimento/{id}")]
        [HttpPut]
        public ActionResult IniciarAtendimento(int id)
        {
            try
            {
                _servAtendimento.IniciarAtendimento(id);

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Route("/api/[controller]/FinalizarAtendimento/{id}")]
        [HttpPut]
        public ActionResult FinalizarAtendimento(int id)
        {
            try
            {
                _servAtendimento.FinalizarAtendimento(id);

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Route("/api/[controller]/CancelarAtendimento/{id}")]
        [HttpPut]
        public ActionResult CancelarAtendimento(int id)
        {
            try
            {
                _servAtendimento.CancelarAtendimento(id);

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}

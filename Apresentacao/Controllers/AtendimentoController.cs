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

    }
}

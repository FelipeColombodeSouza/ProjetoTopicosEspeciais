using Microsoft.AspNetCore.Mvc;
using Servicos;

namespace Apresentacao
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ProfissionalController : ControllerBase
    {
        private IServProfissional _servProfissional;    

        public ProfissionalController(IServProfissional servProfissional)
        {
            _servProfissional = servProfissional;
        }

        [Route("/api/[controller]/Inserir")]
        [HttpPost]
        public ActionResult Inserir(ProfissionalDTO inserirProfissionalDto)
        {
            try
            {
                _servProfissional.Inserir(inserirProfissionalDto);

                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);   
            }
        }

        [Route("/api/[controller]/Editar/{id}")]
        [HttpPut]
        public IActionResult Editar(int id, [FromBody]ProfissionalDTO editarProfissionalDto)
        {
            try
            {
                _servProfissional.Editar(id, editarProfissionalDto);

                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [Route("/api/[controller]/BuscarTodos")]
        [HttpGet]
        public IActionResult BuscarTodos()
        {
            try
            {
                var profissionais = _servProfissional.BuscarTodos();

                var profissionaisRedux = profissionais.Select(p =>
                new
                {
                    Id = p.Id,
                    Nome = p.Nome,
                    Crm = p.Crm,
                }).ToList();    

                return Ok(profissionais);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [Route("/api/[controller]/BuscarPorId/{id}")]
        [HttpGet]
        public IActionResult BuscarPorId(int id)
        {
            try
            {
                var profissional = _servProfissional.BuscarPorId(id);

                return Ok(profissional);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [Route("/api/[controller]/Remover/{id}")]
        [HttpDelete]
        public IActionResult Remover(int id)
        {
            try
            {
               _servProfissional.Remover(id);

                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}

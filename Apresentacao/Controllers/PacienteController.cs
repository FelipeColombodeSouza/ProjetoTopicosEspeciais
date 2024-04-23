using Microsoft.AspNetCore.Mvc;
using Servicos;

namespace Apresentacao
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PacienteController: ControllerBase
    {
        private IServPaciente _servPaciente;

        public PacienteController(IServPaciente servPaciente)
        {
            _servPaciente = servPaciente;
        }

        [Route("/api/[controller]/Inserir")]
        [HttpPost]
        public ActionResult Inserir(InserirPacienteDTO inserirPacienteDTO)
        {
            try
            {
                _servPaciente.Inserir(inserirPacienteDTO);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Route("/api/[controller]/Editar/{id}")]
        [HttpPut]
        public IActionResult Editar(int id , [FromBody]EditarPacienteDTO editarPacienteDto)
        {
            try
            {
                _servPaciente.Editar(id, editarPacienteDto);

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}

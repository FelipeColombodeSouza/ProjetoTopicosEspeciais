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

        [Route("/api/[controller]/BuscarTodos")]
        [HttpGet]
        public IActionResult BuscarTodos() {
            try
            {
                var pacientes = _servPaciente.BuscarTodos();

                /* 
                var pacientesRedux = pacientes.Select(p => new
                {
                    Id = p.Id,
                    Nome = p.Nome,
                    Cpf = p.Cpf,
                    DataNascimento = p.DataNascimento,
                }).ToList();
                */

                return Ok(pacientes);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Route("/api/[controller]/BuscarPorId/{id}")]
        [HttpGet]
        public IActionResult BuscarPorId(int id) {
            try
            {
                var paciente = _servPaciente.BuscarPorId(id);

                return Ok(paciente);

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
                _servPaciente.Remover(id);

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}

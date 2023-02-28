using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using training_dotnet6_api.Repositories;

namespace training_dotnet6_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContatoController : ControllerBase
    {
        private readonly IContatoRepository _contatoRepository;
        public ContatoController(IContatoRepository contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var contatos = _contatoRepository.GetAll();
                if (!contatos.Any())
                    return NoContent();

                return Ok(contatos);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Problem();
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var contato = _contatoRepository.GetById(id);
                if (contato is null)
                    return NoContent();

                return Ok(contato);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Problem();
            }
        }
    }
}

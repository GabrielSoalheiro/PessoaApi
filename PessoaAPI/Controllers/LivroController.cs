using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PessoaAPI.Model;
using PessoaAPI.Business;

namespace PessoaAPI.Controllers
{

    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class LivroController : ControllerBase
    {
        private readonly ILogger<LivroController> _logger;

        private ILivroBusiness _livroBusiness;

        public LivroController(ILogger<LivroController> logger, ILivroBusiness livroBusiness)
        {
            _logger = logger;
            _livroBusiness = livroBusiness;
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_livroBusiness.FindAll());
        }


        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var book = _livroBusiness.FindByID(id);
            if (book == null) return NotFound();
            return Ok(book);
        }


        [HttpPost]
        public IActionResult Post([FromBody] Livro livro)
        {
            if (livro == null) return BadRequest();
            return Ok(_livroBusiness.Create(livro));
        }


        [HttpPut]
        public IActionResult Put([FromBody] Livro livro)
        {
            if (livro == null) return BadRequest();
            return Ok(_livroBusiness.Update(livro));
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _livroBusiness.Delete(id);
            return NoContent();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using PessoaAPI.Model;
using PessoaAPI.Services;

namespace PessoaAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PessoaController : ControllerBase
{

    private readonly ILogger<PessoaController> _logger;

    // Declaração do serviço utilizado
    private IPessoaService _pessoaService;

    // Injeção de uma instância de IPessoaService
    // ao criar uma instância de PessoaController
    public PessoaController(ILogger<PessoaController> logger, IPessoaService pessoaService)
    {
        _logger = logger;
        _pessoaService = pessoaService;
    }

    // Mapeia solicitações GET para https://localhost:{port}/api/pessoa
    // Get sem parâmetros para FindAll -> Pesquisar tudo
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_pessoaService.FindAll());
    }

    // Mapeia solicitações GET para https://localhost:{port}/api/pessoa/{id}
    // recebendo um ID como no Caminho da Solicitação
    // Get sem parâmetros para FindById -> Pesquisar por ID
    [HttpGet("{id}")]
    public IActionResult Get(long id)
    {
        var pessoa = _pessoaService.FindByID(id);
        if (pessoa == null) return NotFound();
        return Ok(pessoa);
    }

    // Mapeia solicitações POST para https://localhost:{port}/api/pessoa/
    // [FromBody] consome o objeto JSON enviado no corpo da solicitação
    [HttpPost]
    public IActionResult Post([FromBody] Pessoa pessoa)
    {
        if (pessoa == null) return BadRequest();
        return Ok(_pessoaService.Create(pessoa));
    }

    // Mapeia solicitações PUT para https://localhost:{port}/api/pessoa/
    // [FromBody] consome o objeto JSON enviado no corpo da solicitação
    [HttpPut]
    public IActionResult Put([FromBody] Pessoa pessoa)
    {
        if (pessoa == null) return BadRequest();
        return Ok(_pessoaService.Update(pessoa));
    }

    // Mapeia solicitações DELETE para https://localhost:{port}/api/pessoa/{id}
    // recebendo um ID como no Caminho da Solicitação
    [HttpDelete("{id}")]
    public IActionResult Delete(long id)
    {
        _pessoaService.Delete(id);
        return NoContent();
    }
}

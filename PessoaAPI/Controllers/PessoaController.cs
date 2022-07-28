using Microsoft.AspNetCore.Mvc;
using PessoaAPI.Business;
using PessoaAPI.Business.Implementations;
using PessoaAPI.Model;

namespace PessoaAPI.Controllers;
//Versionando a nossa API - Instalar o Microsoft.AspNetCore.Mvc.Versioning.
[ApiVersion("1")]//Adiciona a versão da Rota
[ApiController]
[Route("api/[controller]/v{version:apiVersion}")]//E adiciona a rota. (Efetuar na classe Program)
public class PessoaController : ControllerBase
{

    private readonly ILogger<PessoaController> _logger;

    // Declaração do serviço utilizado
    private IPessoaBusiness _pessoaBusiness;

    // Injeção de uma instância de IPessoaBusinessImplementation
    // ao criar uma instância de PessoaController
    public PessoaController(ILogger<PessoaController> logger, IPessoaBusiness pessoaBusiness)
    {
        _logger = logger;
        _pessoaBusiness = pessoaBusiness;
    }

    // Mapeia solicitações GET para https://localhost:{port}/api/pessoa
    // Get sem parâmetros para FindAll -> Pesquisar tudo
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_pessoaBusiness.FindAll());
    }

    // Mapeia solicitações GET para https://localhost:{port}/api/pessoa/{id}
    // recebendo um ID como no Caminho da Solicitação
    // Get sem parâmetros para FindById -> Pesquisar por ID
    [HttpGet("{id}")]
    public IActionResult Get(long id)
    {
        var pessoa = _pessoaBusiness.FindByID(id);
        if (pessoa == null) return NotFound();
        return Ok(pessoa);
    }

    // Mapeia solicitações POST para https://localhost:{port}/api/pessoa/
    // [FromBody] consome o objeto JSON enviado no corpo da solicitação
    [HttpPost]
    public IActionResult Post([FromBody] Pessoa pessoa)
    {
        if (pessoa == null) return BadRequest();
        return Ok(_pessoaBusiness.Create(pessoa));
    }

    // Mapeia solicitações PUT para https://localhost:{port}/api/pessoa/
    // [FromBody] consome o objeto JSON enviado no corpo da solicitação
    [HttpPut]
    public IActionResult Put([FromBody] Pessoa pessoa)
    {
        if (pessoa == null) return BadRequest();
        return Ok(_pessoaBusiness.Update(pessoa));
    }

    // Mapeia solicitações DELETE para https://localhost:{port}/api/pessoa/{id}
    // recebendo um ID como no Caminho da Solicitação
    [HttpDelete("{id}")]
    public IActionResult Delete(long id)
    {
        _pessoaBusiness.Delete(id);
        return NoContent();
    }
}

using Microsoft.AspNetCore.Mvc;
using Salao.Models;

namespace Salao.Controllers;

[ApiController]
[Route("[controller]")]
public class SalaoController : ControllerBase
{
    List<Cliente> clientes = new();
    [HttpGet()]
    [Route("Listar")]
    public IActionResult Listar()
    {
        return Ok(clientes);
    }
    [HttpPost()]
    [Route("Inserir")]
    public IActionResult Inserir(Cliente cliente)
    {
        clientes.Add(cliente);
        return Created ("", cliente);
    }
}

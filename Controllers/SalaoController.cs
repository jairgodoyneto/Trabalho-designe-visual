using Microsoft.AspNetCore.Mvc;
using Salao.Models;

namespace Salao.Controllers;

[ApiController]
[Route("[controller]")]
public class SalaoController : ControllerBase
{
    private static List<Cliente> clientes = new();
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
    [HttpGet()]
    [Route("Buscar/{nome}")]
    public IActionResult Buscar([FromRoute] string nome)
    {
        Cliente cliente = clientes.Find(x => x.Nome == nome);
        if (cliente is not null)
        {
            return Ok(cliente);
        }
        else
        {
            return NotFound();
        }
    }
}

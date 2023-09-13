using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Salao.Data;
using Salao.Models;

namespace Salao.Controllers;

[ApiController]
[Route("[controller]")]
public class SalaoController : ControllerBase
{
    /*
    [HttpPost()]
    [Route("Inserir Cliente")]
    public IActionResult InserirCliente(Cliente cliente)
    {
        clientes.Add(cliente);
        todos.Add(cliente);
        return Created ("", cliente);
    }
    [HttpGet()]
    [Route("Buscar Cliente/{nome}")]
    public IActionResult BuscarCliente([FromRoute] string nome)
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

    [HttpPost()]
    [Route("Inserir Barbeiro")]
    public IActionResult InserirBarbeiro( Barbeiro barbeiro)
    {
        barbeiros.Add(barbeiro);
        todos.Add(barbeiro);
        return Created("",barbeiro);
    }
    [HttpPost()]
    [Route("Inserir Gerente")]
    public IActionResult InserirGerente( Gerente gerente)
    {
        gerentes.Add(gerente);
        todos.Add(gerente);
        return Created("",gerente);
    }
    [HttpGet()]
    [Route("Listar Gerente")]
    public IActionResult ListarGerentes()
    {
        return Ok(gerentes);
    }
    [HttpPost()]
    [Route("Inserir Atendimento")]
    public IActionResult InserirAtendimento(Atendimento atendimento)
    {
        return Created("",atendimento);
    }
    */
}

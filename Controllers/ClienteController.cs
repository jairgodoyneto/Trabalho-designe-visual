using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Salao.Data;
using Salao.Models;

namespace Salao.Controllers;
public class ClienteController :ControllerBase
{
    private SalaoDbContext? _context;
    public ClienteController(SalaoDbContext context)
    {
        _context = context;
    }
    [HttpGet()]
    [Route("Listar Clientes")]
    public async Task<ActionResult<IEnumerable<Cliente>>> ListarClientes()
    {
        if (_context.Cliente is null)
            return NotFound();
        return await _context.Cliente.ToListAsync();
    }
    [HttpGet()]
    [Route("buscar/{id}")]
    public async Task<ActionResult<Cliente>> Buscar([FromRoute] int id)
    {
        if (_context.Cliente is null)
            return NotFound();
        Cliente cliente;
        if ((cliente= await _context.Cliente.FindAsync(id)) is null)
            return NotFound();
        return cliente;
    }
    [HttpPost()]
    [Route("inserir Cliente")]
    public IActionResult Cadastrar(Cliente cliente)
    {
        _context.Add(cliente);
        _context.SaveChanges();
        return Created("",cliente);
    }
}

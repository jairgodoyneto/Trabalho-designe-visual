using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Salao.Data;
using Salao.Models;

namespace Salao.Controllers;
[ApiController]
[Route("[controller]")]
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
        if (_context is null) return NotFound();
        if (_context.Cliente is null)
            return NotFound();
        return await _context.Cliente.ToListAsync();
    }
    [HttpGet()]
    [Route("buscar Cliente/{id}")]
    public async Task<ActionResult<Cliente>> Buscar([FromRoute] int id)
    {
        if (_context is null) return NotFound();
        if (_context.Cliente is null) return NotFound();
        Cliente? cliente = await _context.Cliente.FindAsync(id);
        if (cliente is null)
            return NotFound();
        return cliente;
    }
    [HttpPost()]
    [Route("inserirCliente")]
    public IActionResult Cadastrar(Cliente cliente)
    {
        _context.Add(cliente);
        _context.SaveChanges();
        return Created("",cliente);
    }
    [HttpPut()]
    [Route("alterar Cliente")]
    public async Task<ActionResult> Alterar(Cliente cliente)
    {
        if (_context is null) return NotFound();
        if (_context.Cliente is null) return NotFound();
        var clienteTemp = await _context.Cliente.FindAsync(cliente.ClienteId);
        if(clienteTemp is null) return NotFound();
        _context.Cliente.Update(cliente);
        await _context.SaveChangesAsync();
        return Ok();
    }
    [HttpPatch()]
    [Route("mudar Cliente")]
    public async Task<ActionResult> MudarDescricao(Cliente cliente)
    {
        if(_context is null) return NotFound();
        if(_context.Cliente is null) return NotFound();
        var clienteTemp = await _context.Cliente.FindAsync(cliente.ClienteId);
        if( clienteTemp is null) return NotFound();
        await _context.SaveChangesAsync();
        return Ok();
    }
    [HttpDelete()]
    [Route("excluir cliente/{id}")]
    public async Task<ActionResult> Excluir(int id)
    {
        if (_context is null) return NotFound();
        if (_context.Cliente is null) return NotFound();
        var clienteTemp = await _context.Cliente.FindAsync(id);
        if(clienteTemp is null) return NotFound();
        _context.Remove(clienteTemp);
        await _context.SaveChangesAsync();
        return Ok();
    }
} 

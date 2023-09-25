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
        if (_context is null) return NotFound();
        if (_context.Cliente is null)
            return NotFound();
        return await _context.Cliente.ToListAsync();
    }
    [HttpGet()]
    [Route("buscar/{id}")]
    public async Task<ActionResult<Cliente>> Buscar([FromRoute] int id)
    {
        if (_context is null) return NotFound();
        if (_context.Cliente is null) return NotFound();
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
    [HttpPut()]
    [Route("alterar")]
    public async Task<ActionResult> Alterar(Cliente cliente)
    {
        if (_context is null) return NotFound();
        if (_context.Cliente is null) return NotFound();
        var clienteTemp = await _context.Cliente.FindAsync(cliente.Id);
        if(clienteTemp is null) return NotFound();
        _context.Cliente.Update(cliente);
        await _context.SaveChangesAsync();
        return Ok();
    }
    [HttpPatch()]
    [Route("mudarSenha/{id}")]
    public async Task<ActionResult> MudarSenha(int id, [FromForm] string senha)
    {
        if (_context is null) return NotFound();
        if (_context.Cliente is null) return NotFound();
        var clienteTemp = await _context.Cliente.FindAsync(id);
        if(clienteTemp is null) return NotFound();
        clienteTemp.Senha = senha;
        await _context.SaveChangesAsync();
        return Ok();        
    }
    [HttpDelete()]
    [Route("excluir/{id}")]
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

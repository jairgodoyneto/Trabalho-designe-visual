using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Salao.Data;
using Salao.Models;
using Microsoft.OpenApi.Models;
using System.Security.Cryptography;
namespace Salao.Controllers;

[ApiController]
[Route("[controller]")]
public class BarbeiroController : ControllerBase
{
    private SalaoDbContext? _context;

    public BarbeiroController(SalaoDbContext context)
    {
        _context = context;
    }
    [HttpGet()]
    [Route("Listar Barbeiro")]
    public async Task<ActionResult<IEnumerable<Barbeiro>>> ListarBarbeiro()
    {
        if (_context.Barbeiro is null)return NotFound();
        return await _context.Barbeiro.ToListAsync();
    }
    [HttpGet()]
    [Route("buscar barbeiro/{id}")]
    public async Task<ActionResult<Barbeiro>> Buscar([FromRoute] int id)
    {
        if (_context.Barbeiro is null)return NotFound();
        Barbeiro? barbeiro = await _context.Barbeiro.FindAsync(id);
        if (barbeiro is null)return NotFound();
        return barbeiro;
    }
    [HttpPost()]
    [Route("inserir Barbeiro")]
    public IActionResult Cadastrar(Barbeiro barbeiro)
    {
        _context.Add(barbeiro);
        _context.SaveChanges();
        return Created("",barbeiro);
    }
    [HttpDelete()]
    [Route("excluir barbeiro/{id}")]
    public async Task<ActionResult> Excluir(int id)
    {
        if (_context is null) return NotFound();
        if (_context.Barbeiro is null) return NotFound();
        var barbeiroTemp = await _context.Barbeiro.FindAsync(id);
        if(barbeiroTemp is null) return NotFound();
        _context.Remove(barbeiroTemp);
        await _context.SaveChangesAsync();
        return Ok();
    }
    [HttpPatch()]
    [Route("mudar Barbeiro")]
    public async Task<ActionResult> MudarBarbeiro(Barbeiro barbeiro)
    {
        if(_context is null) return BadRequest();
        if(_context.Barbeiro is null) return BadRequest();
        var BarbeiroTemp = await _context.Barbeiro.FindAsync(barbeiro.Id);
        if(BarbeiroTemp is null) return BadRequest();
        BarbeiroTemp.Nome= barbeiro.Nome;
        BarbeiroTemp.Email= barbeiro.Email;
        BarbeiroTemp.Cpf= barbeiro.Cpf;
        BarbeiroTemp.Unidadeid= barbeiro.Unidadeid;
        await _context.SaveChangesAsync();
        return Ok();        
    }
}

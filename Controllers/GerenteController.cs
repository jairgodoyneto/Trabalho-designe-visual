using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Salao.Data;
using Salao.Models;

namespace Salao.Controllers;

[ApiController]
[Route("[controller]")]

public class GerenteController : ControllerBase
{
    private SalaoDbContext? _context;
    public GerenteController(SalaoDbContext context)
    {
        _context = context;
    }
    [HttpPost]
    [Route("Cadastrar gerente")]
    public IActionResult Cadastrar(Gerente gerente)
    {
        _context.Add(gerente);
        _context.SaveChanges();
        return Created("",gerente);
    }
    [HttpGet()]
    [Route("Listar gerentes")]
    public async Task<ActionResult<IEnumerable<Gerente>>> Listar()
    {
        if (_context is null) return NotFound();
        if (_context.Gerente is null)
            return NotFound();
        return await _context.Gerente.ToListAsync();
    }
    [HttpPut()]
    [Route("alterar gerente")]
    public async Task<ActionResult> Alterar(Gerente gerente)
    {
        if (_context is null) return NotFound();
        if (_context.Gerente is null) return NotFound();
        var gerenteTemp = await _context.Gerente.FindAsync(gerente);
        if(gerenteTemp is null) return NotFound();
        _context.Gerente.Update(gerente);
        await _context.SaveChangesAsync();
        return Ok();
    }   
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Salao.Data;
using Salao.Models;

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
        if (_context.Barbeiro is null)
            return NotFound();
        return await _context.Barbeiro.ToListAsync();
    }
    [HttpGet()]
    [Route("buscar/{id}")]
    public async Task<ActionResult<Barbeiro>> Buscar([FromRoute] int id)
    {
        if (_context.Barbeiro is null)
            return NotFound();
        Barbeiro barbeiro;
        if ((Barbeiro= await _context.Barbeiro.FindAsync(id)) is null)
            return NotFound();
        return Barbeiro;
    }
    [HttpPost()]
    [Route("inserir Barbeiro")]
    public IActionResult Cadastrar(Barbeiro Barbeiro)
    {
        _context.Add(Barbeiro);
        _context.SaveChanges();
        return Created("",Barbeiro);
    }

}

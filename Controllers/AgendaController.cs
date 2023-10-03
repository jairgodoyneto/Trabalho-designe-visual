using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Salao.Data;
using Salao.Models;

namespace Salao.Controllers;

[ApiController]
[Route("[controller]")]

public class AgendaController : ControllerBase
{
    private SalaoDbContext? _context;
    public AgendaController(SalaoDbContext context)
    {
        _context = context;
    }
    [HttpPost]
    [Route("Cadastrar agenda")]
    public IActionResult Cadastrar(Agenda agenda)
    {
        _context.Add(agenda);
        _context.SaveChanges();
        return Created("",agenda);
    }
    [HttpGet()]
    [Route("Listar agendas")]
    public async Task<ActionResult<IEnumerable<Agenda>>> Listar()
    {
        if (_context is null) return NotFound();
        if (_context.Agenda is null)
            return NotFound();
        return await _context.Agenda.ToListAsync();
    }
    [HttpPut()]
    [Route("alterar")]
    public async Task<ActionResult> Alterar(Agenda agenda)
    {
        if (_context is null) return NotFound();
        if (_context.Agenda is null) return NotFound();
        var agendaTemp = await _context.Agenda.FindAsync(agenda);
        if(agendaTemp is null) return NotFound();
        _context.Agenda.Update(agenda);
        await _context.SaveChangesAsync();
        return Ok();
    }   
}
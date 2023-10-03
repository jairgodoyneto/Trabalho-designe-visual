using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Salao.Data;
using Salao.Models;

namespace Salao.Controllers;

[ApiController]
[Route("[controller]")]

public class UnidadeAtendimentoController : ControllerBase
{
    private SalaoDbContext? _context;
    public UnidadeAtendimentoController(SalaoDbContext context)
    {
        _context = context;
    }
    [HttpPost]
    [Route("Cadastrar Unidade atendimento")]
    public IActionResult Cadastrar(UnidadeAtendimento unidade)
    {
        _context.Add(unidade);
        _context.SaveChanges();
        return Created("",unidade);
    }
    [HttpGet()]
    [Route("Listar Unidades")]
    public async Task<ActionResult<IEnumerable<UnidadeAtendimento>>> Listar()
    {
        if (_context is null) return NotFound();
        if (_context.UnidadeAtendimento is null)
            return NotFound();
        return await _context.UnidadeAtendimento.ToListAsync();
    }
    [HttpPut()]
    [Route("alterar")]
    public async Task<ActionResult> Alterar(UnidadeAtendimento unidade)
    {
        if (_context is null) return NotFound();
        if (_context.UnidadeAtendimento is null) return NotFound();
        var unidadeTemp = await _context.UnidadeAtendimento.FindAsync(unidade);
        if(unidadeTemp is null) return NotFound();
        _context.UnidadeAtendimento.Update(unidade);
        await _context.SaveChangesAsync();
        return Ok();
    }   
}
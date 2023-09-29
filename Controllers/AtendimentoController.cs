using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Salao.Data;
using Salao.Models;

[ApiController]
[Route("[controller]")]

public class AtendimentoController : ControllerBase
{
    private SalaoDbContext? _context;
    public AtendimentoController(SalaoDbContext context)
    {
        _context = context;
    }
    [HttpPost()]
    [Route("Novo_Atendimento")]
    public IActionResult Cadastrar(AtendimentoAgendado atendimento)
    {
        _context.Add(atendimento);
        _context.SaveChanges();
        return Created("",atendimento);
    }
    [HttpGet()]
    [Route("Recuperar atendimentos")]
    public async Task<ActionResult<IEnumerable<AtendimentoAgendado>>> ListarAtendimentos()
    {
        if (_context.Barbeiro is null)
            return NotFound();
        return await _context.AtendimentoAgendado.ToListAsync();
    }
}
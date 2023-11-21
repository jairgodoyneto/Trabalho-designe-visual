using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Salao.Data;
[ApiController]
[Route("[controller]")]
public class ServicoController : ControllerBase
{
    private SalaoDbContext? _context;
    public ServicoController(SalaoDbContext context)
    {
        _context = context;
    }
    [HttpGet()]
    [Route("Listar Horarios")]
    public async Task<ActionResult<IEnumerable<HorarioLivre>>> ListarHorarioLivres()
    {
        if (_context is null) return NotFound();
        if (_context.HorarioLivre is null)
            return NotFound();
        return await _context.HorarioLivre.ToListAsync();
    }
    [HttpGet()]
    [Route("buscar Horario/{id}")]
    public async Task<ActionResult<HorarioLivre>> Buscar([FromRoute] int id)
    {
        if (_context is null) return NotFound();
        if (_context.HorarioLivre is null) return NotFound();
        HorarioLivre? horarioLivre = await _context.HorarioLivre.FindAsync(id);
        if (horarioLivre is null)
            return NotFound();
        return horarioLivre;
    }
    [HttpPost()]
    [Route("inserir Horario")]
    public IActionResult Cadastrar(HorarioLivre horarioLivre)
    {
        _context.Add(horarioLivre);
        _context.SaveChanges();
        return Created("",horarioLivre);
    }
    [HttpPatch()]
    [Route("Alterar Horario")]
    public async Task<ActionResult> MudarDescricao(HorarioLivre horarioLivre)
    {
        if(_context is null) return NotFound();
        if(_context.HorarioLivre is null) return NotFound();
        var horarioLivreTemp = await _context.HorarioLivre.FindAsync(horarioLivre.Id);
        if( horarioLivreTemp is null) return NotFound();
        await _context.SaveChangesAsync();
        return Ok();
    }
    [HttpDelete()]
    [Route("excluir Horario/{id}")]
    public async Task<ActionResult> Excluir(int id)
    {
        if (_context is null) return NotFound();
        if (_context.HorarioLivre is null) return NotFound();
        var horarioLivreTemp = await _context.HorarioLivre.FindAsync(id);
        if(horarioLivreTemp is null) return NotFound();
        _context.Remove(horarioLivreTemp);
        await _context.SaveChangesAsync();
        return Ok();
    }
}
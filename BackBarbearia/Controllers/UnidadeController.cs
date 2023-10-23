using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Salao.Data;
using Salao.Models;
namespace Salao.Controllers;

public class UnidadeController : ControllerBase
{
    private SalaoDbContext? _context;

    public UnidadeController(SalaoDbContext context)
    {
        _context = context;
    }

    [HttpGet()]
    [Route("Listar unidades")]
    public async Task<ActionResult<IEnumerable<UnidadeAtendimento>>> Listar()
    {
        if (_context is null) return NotFound();
        if (_context.UnidadeAtendimento is null)return NotFound();
        return await _context.UnidadeAtendimento.ToListAsync();
    }
    [HttpGet()]
    [Route("buscar unidade/{id}")]
    public async Task<ActionResult<UnidadeAtendimento>> Buscar([FromRoute] int id)
    {
        if (_context is null) return NotFound();
        if (_context.UnidadeAtendimento is null) return NotFound();
        UnidadeAtendimento? UnidadeAtendimento = await _context.UnidadeAtendimento.FindAsync(id);
        if (UnidadeAtendimento is null)
            return NotFound();
        return UnidadeAtendimento;
    }
    [HttpPost()]
    [Route("inserir Unidade/{id}")]
    public async Task<IActionResult> Cadastrar([FromRoute] List<int> id, string endereco, int cep)
    {
        UnidadeAtendimento unidadeAtendimento = new();
        foreach (var x in id)
        {
            if(_context.Barbeiro == null) return NotFound("Barbeiro vazio");
            Barbeiro? barbeiro=await _context.Barbeiro.FindAsync(x);
            if(barbeiro == null)
            {
                return NotFound("Barbeiro não encontrado");
            }
            unidadeAtendimento.Funcionarios.Add(barbeiro);
        }
        unidadeAtendimento.Cep = cep;
        unidadeAtendimento.Endereco=endereco;
        _context.Add(unidadeAtendimento);
        _context.SaveChanges();
        return Created("",unidadeAtendimento);
    }
    [HttpPut()]
    [Route("alterar unidade atendimento")]
    public async Task<ActionResult> Alterar(UnidadeAtendimento UnidadeAtendimento)
    {
        if (_context is null) return NotFound();
        if (_context.UnidadeAtendimento is null) return NotFound();
        var UnidadeAtendimentoTemp = await _context.UnidadeAtendimento.FindAsync(UnidadeAtendimento.UnidadeId);
        if(UnidadeAtendimentoTemp is null) return NotFound();
        _context.UnidadeAtendimento.Update(UnidadeAtendimento);
        await _context.SaveChangesAsync();
        return Ok();
    }
    [HttpDelete()]
    [Route("excluir unidade/{id}")]
    public async Task<ActionResult> Excluir(int id)
    {
        if (_context is null) return NotFound();
        if (_context.UnidadeAtendimento is null) return NotFound();
        var UnidadeAtendimentoTemp = await _context.UnidadeAtendimento.FindAsync(id);
        if(UnidadeAtendimentoTemp is null) return NotFound();
        _context.Remove(UnidadeAtendimentoTemp);
        await _context.SaveChangesAsync();
        return Ok();
    }
}
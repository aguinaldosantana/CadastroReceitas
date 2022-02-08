using AutoMapper;
using CadastroReceitas.Data;
using CadastroReceitas.Data.DTos;
using CadastroReceitas.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CadastroReceitas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DespesasController : ControllerBase
    {
        private DespesaContext _context;
        private IMapper _mapper;

        public DespesasController(DespesaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpPost]
        public IActionResult DespesaPost([FromBody] CreateDespesaDto despesaDto)
        {
            DespesaModel despesa = _mapper.Map<DespesaModel>(despesaDto);
            _context.Despesas.Add(despesa);
            _context.SaveChanges();
            return CreatedAtAction(nameof(DespesaGetById), new { Id = despesa.Id }, despesa);
        }

        [HttpGet]
        public IEnumerable<DespesaModel> DespesaGet()
        {
            return _context.Despesas;
        }

        [HttpGet("{id}")]
        public IActionResult DespesaGetById(int id)
        {
            DespesaModel despesa = _context.Despesas.FirstOrDefault(filme => filme.Id == id);
            if (despesa != null)
            {
                ReadReceitaDto receitaDto = _mapper.Map<ReadReceitaDto>(despesa);
                return Ok(despesa);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateById(int id, [FromBody] DespesaModel despesaDto)
        {
            DespesaModel despesa = _context.Despesas.FirstOrDefault(filme => filme.Id == id);
            if (despesa == null)
            {
                return NotFound();
            }
            _mapper.Map(despesa, despesaDto);
            _context.SaveChanges();
            return NoContent();
        }

        public IActionResult DeleteById(int id)
        {
            DespesaModel despesa = _context.Despesas.FirstOrDefault(filme => filme.Id == id);
            if (despesa == null)
            {
                return NotFound();
            }
            _context.Remove(despesa);
            _context.SaveChanges();
            return NoContent();
        }
    }
}

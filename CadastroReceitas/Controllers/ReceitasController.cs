using AutoMapper;
using CadastroReceitas.Data;
using CadastroReceitas.Data.DTos;
using CadastroReceitas.Models;
using CadastroReceitas.Profiles;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CadastroReceitas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReceitasController : ControllerBase
    {
        private ReceitaContext _context;
        private IMapper _mapper;

        public ReceitasController(ReceitaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult ReceitaPost([FromBody] CreateReceitaDto receitaDto)
        {
            ReceitaModel receita = _mapper.Map<ReceitaModel>(receitaDto);
            _context.Receitas.Add(receita);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ReceitaGetById), new {Id = receita.Id}, receita);
        }

        [HttpGet]
        public IEnumerable<ReceitaModel> ReceitaGet()
        {
            return _context.Receitas;
        }

        [HttpGet("{id}")]
        public IActionResult ReceitaGetById(int id)
        {
            ReceitaModel receita = _context.Receitas.FirstOrDefault(filme => filme.Id == id);
            if (receita != null)
            {
                ReadReceitaDto receitaDto = _mapper.Map<ReadReceitaDto>(receita);
                return Ok(receita);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateById(int id, [FromBody] ReceitaProfile receitaNovaDto)
        {
            ReceitaModel receita = _context.Receitas.FirstOrDefault(filme => filme.Id == id);
            if (receita == null)
            {
                return NotFound();
            }
            _mapper.Map(receita, receitaNovaDto);
            _context.SaveChanges();
            return NoContent();
        }

        public IActionResult DeleteById(int id)
        {
            ReceitaModel receita = _context.Receitas.FirstOrDefault(filme => filme.Id == id);
            if (receita == null)
            {
                return NotFound();
            }
            _context.Remove(receita);
            _context.SaveChanges();
            return NoContent();
        }

    }
}

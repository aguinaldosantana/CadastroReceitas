using System;
using System.ComponentModel.DataAnnotations;

namespace CadastroReceitas.Data.DTos
{
    public class ReadReceitaDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo descrição obrigatório")]
        [StringLength(30, ErrorMessage = "Descrição não pode ultrapassar 50 caracteres")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Campo valor obrigatório")]
        public double Valor { get; set; }
        [Required(ErrorMessage = "Campo data obrigatório")]
        public DateTime? Data { get; set; }
        public DateTime? HoraDaConsulta { get; set; }

    }
}

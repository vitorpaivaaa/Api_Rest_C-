using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDBZ.models
{
    public class Personagem
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é um campo obrigatorio")]
        [MaxLength(50, ErrorMessage = "Nome precisa ter no maximo 50 caracteres")]
        public String Nome { get; set; }

            [Required(ErrorMessage = "tipo é um campo obrigatorio")]
        [MaxLength(50, ErrorMessage = "tipo precisa ter no maximo 50 caracteres")]
        public String Tipo { get; set; }
    }
}
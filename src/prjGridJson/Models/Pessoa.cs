using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace prjGridJson.Models
{
    public class Pessoa
    {
        public int PessoaId { get; set; }
        [Required]
        public string Nome { get; set; }
        public DateTime DataNasc { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Cep { get; set; }

        public virtual List<Curso> Cursos { get; set; }
        
    }

}
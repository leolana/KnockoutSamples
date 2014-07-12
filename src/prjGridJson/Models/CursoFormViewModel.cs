using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages.Html;
using System.Web.Mvc;

namespace prjGridJson.Models
{
    public class CursoFormViewModel
    {
        public int PessoaId { get; set; }

        public SelectList Pessoas { get; set; }

        //public void LoadAlunos()
        //{
        //    IEnumerable<Pessoa> alunos = new List<Pessoa>();
        //    using (var context = new PessoaContext())
        //    {
        //        alunos = context.Pessoas.ToList();
        //    }

        //    Pessoas = new SelectList(alunos, "PessoaId", "Nome");
        //}
    }
}
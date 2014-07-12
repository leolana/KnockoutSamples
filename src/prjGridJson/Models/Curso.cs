using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prjGridJson.Models
{
    public class Curso
    {
        public int CursoID { get; set; }
        public string CursoNome { get; set; }
        public DateTime DataConclusao { get; set; }
        public virtual List<Pessoa> Pessoas { get; set; }
        public List<int> PessoasIDs { get; set; }

        //public void LoadDefaultValues()
        //{
        //    using (var context = new PessoaContext())
        //    {
        //        Pessoas = context.Pessoas.ToList();
        //    }
        //}
    }

    
}
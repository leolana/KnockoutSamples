using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prjGridJson.Models;
using Newtonsoft.Json;

namespace prjGridJson.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var idade = new Idade(25);
            ViewBag.Message = "Grid - Json";

            return View();
        }

        public JsonResult CarregaGrid(int page, int rows)
        {
            //http://haacked.com/archive/2009/04/14/using-jquery-grid-with-asp.net-mvc.aspx/
            List<Pessoa1> listaPessoa1s = new List<Pessoa1>();
            listaPessoa1s.Add(new Pessoa1 { Nome = "Leonardo Lucas", Sobrenome = "Lana", Idade = "22" });
            listaPessoa1s.Add(new Pessoa1 { Nome = "Alexandre José", Sobrenome = "Lana", Idade = "31" });
            listaPessoa1s.Add(new Pessoa1 { Nome = "Leandro Luís", Sobrenome = "Lana", Idade = "31" });
            listaPessoa1s.Add(new Pessoa1 { Nome = "Leandro Luís", Sobrenome = "Lana", Idade = "31" });
            listaPessoa1s.Add(new Pessoa1 { Nome = "Leonardo Lucas", Sobrenome = "Lana", Idade = "22" });
            listaPessoa1s.Add(new Pessoa1 { Nome = "Alexandre José", Sobrenome = "Lana", Idade = "31" });
            listaPessoa1s.Add(new Pessoa1 { Nome = "Leandro Luís", Sobrenome = "Lana", Idade = "31" });
            listaPessoa1s.Add(new Pessoa1 { Nome = "Leandro Luís", Sobrenome = "Lana", Idade = "31" });
            listaPessoa1s.Add(new Pessoa1 { Nome = "Leonardo Lucas", Sobrenome = "Lana", Idade = "22" });
            listaPessoa1s.Add(new Pessoa1 { Nome = "Alexandre José", Sobrenome = "Lana", Idade = "31" });
            listaPessoa1s.Add(new Pessoa1 { Nome = "Leandro Luís", Sobrenome = "Lana", Idade = "31" });
            listaPessoa1s.Add(new Pessoa1 { Nome = "Leandro Luís", Sobrenome = "Lana", Idade = "31" });
            listaPessoa1s.Add(new Pessoa1 { Nome = "Leonardo Lucas", Sobrenome = "Lana", Idade = "22" });
            listaPessoa1s.Add(new Pessoa1 { Nome = "Alexandre José", Sobrenome = "Lana", Idade = "31" });
            listaPessoa1s.Add(new Pessoa1 { Nome = "Leandro Luís", Sobrenome = "Lana", Idade = "31" });
            listaPessoa1s.Add(new Pessoa1 { Nome = "Leandro Luís", Sobrenome = "Lana", Idade = "31" });
            listaPessoa1s.Add(new Pessoa1 { Nome = "Leonardo Lucas", Sobrenome = "Lana", Idade = "22" });
            listaPessoa1s.Add(new Pessoa1 { Nome = "Alexandre José", Sobrenome = "Lana", Idade = "31" });
            listaPessoa1s.Add(new Pessoa1 { Nome = "Leandro Luís", Sobrenome = "Lana", Idade = "31" });
            listaPessoa1s.Add(new Pessoa1 { Nome = "Leandro Luís", Sobrenome = "Lana", Idade = "31" });
            listaPessoa1s.Add(new Pessoa1 { Nome = "Leonardo Lucas", Sobrenome = "Lana", Idade = "22" });
            listaPessoa1s.Add(new Pessoa1 { Nome = "Alexandre José", Sobrenome = "Lana", Idade = "31" });
            listaPessoa1s.Add(new Pessoa1 { Nome = "Leandro Luís", Sobrenome = "Lana", Idade = "31" });
            listaPessoa1s.Add(new Pessoa1 { Nome = "Leandro Luís", Sobrenome = "Lana", Idade = "31" });
            listaPessoa1s.Add(new Pessoa1 { Nome = "Leonardo Lucas", Sobrenome = "Lana", Idade = "22" });
            listaPessoa1s.Add(new Pessoa1 { Nome = "Alexandre José", Sobrenome = "Lana", Idade = "31" });
            listaPessoa1s.Add(new Pessoa1 { Nome = "Leandro Luís", Sobrenome = "Lana", Idade = "31" });
            listaPessoa1s.Add(new Pessoa1 { Nome = "Leandro Luís", Sobrenome = "Lana", Idade = "31" });
            listaPessoa1s.Add(new Pessoa1 { Nome = "Leonardo Lucas", Sobrenome = "Lana", Idade = "22" });
            listaPessoa1s.Add(new Pessoa1 { Nome = "Alexandre José", Sobrenome = "Lana", Idade = "31" });
            listaPessoa1s.Add(new Pessoa1 { Nome = "Leandro Luís", Sobrenome = "Lana", Idade = "31" });
            listaPessoa1s.Add(new Pessoa1 { Nome = "Leandro Luís", Sobrenome = "Lana", Idade = "31" });

            var result = new
            {
                page = page,
                records = rows,
                total = listaPessoa1s.Count,
                rows = listaPessoa1s.ToArray()
            };
            
            //Entity Framework
           // var pessoa = new Pessoa
           // {
           //     Nome = "Leonardo Lucas Lana",
           //     DataNasc = new DateTime(1991, 2, 15, 8, 0, 0),
           //     Telefone = "32623015",
           //     Endereco = "Sitio São Luis",
           //     Cep = "18540-000"
           // };
           // var curso = new Curso
           // {
           //     CursoNome = "ADS",
           //     DataConclusao = new DateTime(1985, 3, 25, 0, 0, 0)
           // };
           // pessoa.Cursos = new List<Curso>();
           // pessoa.Cursos.Add(curso);
           //// curso.Pessoa = pessoa;
           // using (var context = new PessoaContext())
           // {
           //     context.Pessoas.Add(pessoa);
           //     context.SaveChanges();

           //    // Curso cursouowww = context.Cursos.FirstOrDefault(x => x.CursoID == curso.CursoID);
           // }

            return Json(result, JsonRequestBehavior.AllowGet);

        }
        

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prjGridJson.Models;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Data.Entity;

namespace prjGridJson.Controllers
{
    public class CursoController : Controller
    {
        //
        // GET: /Curso/
        /*
         * Dúvidas: Como alterar o aluno que faz o curso em um edição.
         * Como fazer a paginção dinâmica com o jqGrid.
         * Como fazer o filtro no jqGrid.
         */

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form()
        {
            //LoadAluno();
            Curso model = new Curso();
            //model.LoadDefaultValues();
            return View(model);
        }

        //private void LoadAluno()
        //{
        //    IEnumerable<SelectListItem> alunos = new List<SelectListItem>();
        //    using (var context = new PessoaContext())
        //    {
        //        alunos = new SelectList(context.Pessoas.ToList(), "PessoaId", "Nome");
        //    }

        //    ViewBag.Alunos = alunos;
        //}

        //public ActionResult Edit(int id)
        //{
        //    Curso model = ObtemCursoPessoa(id);
        //    model.LoadDefaultValues();
        //    using (var context = new PessoaContext())
        //    {
        //        var cursoExistente = context.Cursos.FirstOrDefault(c => c.CursoID == id);
        //        model.PessoasIDs = new List<int>();
        //        foreach (var pessoa in cursoExistente.Pessoas)
        //        {
        //            model.PessoasIDs.Add(pessoa.PessoaId);
        //        }
        //    }
        //    return View("Form", model);
        //}

        //private Curso ObtemCursoPessoa(int id)
        //{
        //    Curso curso;
        //    IEnumerable<Pessoa> pessoas;
        //    using (var context = new PessoaContext())
        //    {
        //        curso = context.Cursos.Where(x => x.CursoID == id).SingleOrDefault();
        //        pessoas = context.Pessoas.ToList();
        //        foreach (var item_pessoa in pessoas)
        //        {
        //            foreach (var item_curso in item_pessoa.Cursos)
        //            {
        //                if (item_curso.CursoID == curso.CursoID)
        //                {
        //                    curso.Pessoas.Add(item_pessoa);
        //                    return curso;
        //                }
        //            }
        //        }
        //        return null;
        //    }
        //}

        //private Pessoa ObtemPessoa(int id)
        //{
        //    Pessoa pessoa;
        //    using (var context = new PessoaContext())
        //    {
        //        pessoa = context.Pessoas.FirstOrDefault(p => p.PessoaId == id);
        //    }
        //    return pessoa;
        //}

        //[HttpPost]
        //public ActionResult Save(Curso curso)
        //{
        //    if (curso.CursoID == 0)
        //    {
        //        string erro = Insert(curso, curso.PessoasIDs);
        //        if (erro != "")
        //            return View("Form");
        //    }
        //    else
        //    {
        //    //    curso.Pessoa = ObtemPessoa(curso.Pessoa.PessoaId);
        //        string erro = Update(curso);
        //        if (erro != "")
        //            return View("Form");
        //    }
        //    return View("Index");
        //}

        //private string Insert(Curso curso, IEnumerable<int> pessoasIDs)
        //{
        //    using (var context = new PessoaContext())
        //    {
        //        try
        //        {
        //          //  Pessoa pessoa = context.Pessoas.FirstOrDefault(x => x.PessoaId == pessoaId);
        //          //  pessoa.Cursos.Add(curso);
        //            curso.Pessoas = new List<Pessoa>();
        //            foreach (int pessoaId in pessoasIDs)
        //            {
        //                Pessoa pessoa = context.Pessoas.FirstOrDefault(x => x.PessoaId == pessoaId);
        //                curso.Pessoas.Add(pessoa);
        //            }
        //            context.Cursos.Add(curso);
        //            context.SaveChanges();
        //        }
        //        catch (DbEntityValidationException ex)
        //        {
        //            context.GetValidationErrors();
        //            return ex.ToString();
        //        }
        //        catch (DbUpdateException ex)
        //        {
        //            context.GetValidationErrors();
        //            return ex.ToString();
        //        }

        //    }

        //    return "";
        //}

        //private string Update(Curso curso)
        //{
        //    using (var context = new PessoaContext())
        //    {
        //        try
        //        {
        //            Curso cursoExistente = context.Cursos.FirstOrDefault(c => c.CursoID == curso.CursoID);
        //            var pessoasExistentes = context.Pessoas.ToList();
        //            foreach (int pessoaId in curso.PessoasIDs)
        //            {
        //                var pessoa = pessoasExistentes.Where(p => p.PessoaId == pessoaId).FirstOrDefault();
        //                var pessoaEncontrada = cursoExistente.Pessoas.Where(p => p.PessoaId == pessoaId).FirstOrDefault();
        //                if (pessoaEncontrada == null)
        //                {
        //                    cursoExistente.Pessoas.Add(pessoa);
        //                }
        //            }
        //            context.Cursos.Attach(cursoExistente);
        //            context.Entry(cursoExistente).State = EntityState.Modified;
        //            context.SaveChanges();
        //        }
        //        catch (DbEntityValidationException ex)
        //        {
        //            context.GetValidationErrors();
        //            return ex.ToString();
        //        }
        //        catch (DbUpdateException ex)
        //        {
        //            context.GetValidationErrors();
        //            return ex.ToString();
        //        }

        //    }

        //    return "";
        //}

        //public JsonResult Delete(int id)
        //{
        //    Curso model;
        //    using (var context = new PessoaContext())
        //    {
        //        model = context.Cursos.Where(x => x.CursoID == id).FirstOrDefault();
        //        context.Cursos.Remove(model);
        //        context.SaveChanges();
        //    }
        //    return Json(new { success = true }, JsonRequestBehavior.AllowGet);
        //}

        //public JsonResult Search(string page, string rows, string sidx, string sord)
        //{
        //    using (var context = new PessoaContext())
        //    {
        //        int pageIndex = Convert.ToInt32(page) - 1;
        //        int pageSize = Convert.ToInt32(rows);
        //        int totalRecords = context.Cursos.Count();
        //        int totalPages = (int)Math.Ceiling((float)totalRecords / (float)pageSize);
        //        //OU
        //      //  int totalPages = (totalRecords + rows - 1) / rows;

        //        //IEnumerable<Curso> cursos = context.Cursos.OrderBy(x => x.CursoID).Skip(pageIndex * pageSize).Take(pageSize);
        //        IEnumerable<Curso> cursos = context.Cursos;
        //        IEnumerable<Pessoa> pessoas = context.Pessoas.ToList();
        //        var result = new
        //        {
        //            total = totalPages,
        //            page,
        //            records = totalRecords,
        //            rows = (from curso in cursos
        //                    select new
        //                    {
        //                        id = curso.CursoID,
        //                        cell = new string[] {
        //                                "",
        //                                curso.CursoID.ToString(),
        //                                curso.CursoNome,
        //                                curso.DataConclusao.ToString()
        //                            }
        //                    }
        //                ).ToArray()
        //        };

        //        return Json(result, JsonRequestBehavior.AllowGet);
        //    }
        //}

        //public JsonResult SearchPessoa(int id)
        //{
        //    //http://www.codeproject.com/Articles/609442/Using-JqGrid-in-ASP-NET
        //    //http://codefucius.blogspot.co.uk/2012/11/implementing-jqgrid-search.html
        //    using (var context = new PessoaContext())
        //    {

        //        List<Curso> cursosDaPessoa = context.Pessoas.FirstOrDefault(x => x.PessoaId == id).Cursos;

        //        int totalRecords = cursosDaPessoa.Count();
        //        int totalPages = totalRecords / 10;

        //        IEnumerable<Pessoa> pessoas = context.Pessoas.ToList();
        //        var result = new
        //        {
        //            total = totalPages,
        //            page = 1,
        //            records = totalRecords,
        //            rows = (from curso in cursosDaPessoa
        //                    select new
        //                    {
        //                        id = curso.CursoID,
        //                        cell = new string[] {
        //                                "",
        //                                curso.CursoID.ToString(),
        //                                curso.CursoNome,
        //                                curso.DataConclusao.ToString()
        //                            }
        //                    }
        //                ).ToArray()
        //        };

        //        return Json(result, JsonRequestBehavior.AllowGet);
        //    }
        //}
    }
}

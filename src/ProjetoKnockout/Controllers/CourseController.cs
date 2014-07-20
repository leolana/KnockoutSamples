using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoKnockout.Entities;

namespace ProjetoKnockout.Controllers
{
    public class CourseController : Controller
    {
        //
        // GET: /Course/

        public ActionResult Index()
        {
            //using (var context = new DatabaseContext())
            //{
            //    EmpresaIndexViewModel model = new EmpresaIndexViewModel() { Context = context }; ;
            //    model.LoadDefaultValues();
            //    return View(model);
            //}
            return View();
        }

        //public JsonResult Search(DataTableParameter parameter)
        //{
        //    parameter.SetColumnFilters(Request.QueryString);
        //    using (DatabaseContext ctx = new DatabaseContext())
        //    {
        //        PesquisarEmpresaQueryObject query = new PesquisarEmpresaQueryObject(ctx);
        //        var result = query.Get(parameter);
        //        return Json(result, JsonRequestBehavior.AllowGet);

        //    }
        //}

        public JsonResult SaveGrid(IEnumerable<IEnumerable<PasteParameter>> Grid)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                //foreach(var parametro in Grid)
                //{
                //    var parametroTraco = new TracoParametrizacao()
                //    {
                //        fck = parametro.FirstOrDefault(x => x.Name == "fck").Value,
                //        adicao = Convert.ToDecimal( parametro.FirstOrDefault(x => x.Name == "adicao").Value ),
                //        aditivo1 = Convert.ToDecimal(parametro.FirstOrDefault(x => x.Name == "aditivo1").Value ),
                //        aditivo2 = Convert.ToDecimal( parametro.FirstOrDefault(x => x.Name == "aditivo2").Value ),
                //        miudo1 = Convert.ToDecimal( parametro.FirstOrDefault(x => x.Name == "miudo1").Value ),
                //        miudo2 = Convert.ToDecimal( parametro.FirstOrDefault(x => x.Name == "miudo2").Value ),
                //        graudo1 = Convert.ToDecimal( parametro.FirstOrDefault(x => x.Name == "graudo1").Value ),
                //        graudo2 = Convert.ToDecimal( parametro.FirstOrDefault(x => x.Name == "graudo2").Value ),
                //        agua = Convert.ToDecimal( parametro.FirstOrDefault(x => x.Name == "agua").Value ),
                //        cimento = Convert.ToDecimal( parametro.FirstOrDefault(x => x.Name == "cimento").Value ),
                //        volume = 0,
                //        custo = 0
                //    };

                //    context.TracoParametrizacao.AddObject(parametroTraco);   
                //}
                //context.SaveChanges();

                return Json(new { success = true, message = "" }, JsonRequestBehavior.AllowGet);
            }
        }

        //public ActionResult New()
        //{
        //    using (var context = new DatabaseContext())
        //    {
        //        var model = new EmpresaFormViewModel() { Context = context };
        //        model.LoadDefaultValues();

        //        return View("Form", model);
        //    }
        //}


        //[HttpPost]
        //public ActionResult New(EmpresaFormViewModel model)
        //{
        //    return Save(model);
        //}

        //private ActionResult Save(EmpresaFormViewModel model)
        //{
        //    using (var context = new DatabaseContext())
        //    {
        //        model.Context = context;

        //        if (!ModelState.IsValid)
        //        {
        //            model.LoadDefaultValues();
        //            return View("Form", model);
        //        }

        //        var empresa = context.Empresa.Where(e => e.IdEmpresa == model.IdEmpresa).FirstOrDefault();
        //        if (empresa == null)
        //        {
        //            empresa = new Empresa();
        //            empresa.IdEmpresa = Guid.NewGuid();
        //            context.Empresa.AddObject(empresa);
        //        }

        //        empresa.Check(model.IdResponsavel);

        //        var empresaLogo = context.EmpresaLogo.Where(e => e.IdEmpresa == model.IdEmpresa).FirstOrDefault();
        //        if (empresaLogo == null)
        //        {
        //            empresaLogo = new EmpresaLogo()
        //            {
        //                Empresa = empresa
        //            };
        //        }
        //        if (model.Logo != null)
        //            empresaLogo.Logo = HttpPostedFileBaseExtensions.ReadAllBytes(model.Logo);

        //        empresa.RazaoSocial = model.RazaoSocial;
        //        empresa.Codigo = model.CodigoEmpresa;
        //        empresa.Email = model.Email;
        //        empresa.IdResponsavel = model.IdResponsavel;
        //        empresa.CNPJ = model.CNPJ;
        //        empresa.Fator = model.Fator ?? 0;
        //        empresa.Agencia = model.CodigoAgencia ?? 0;
        //        empresa.NossoNumero = model.NossoNumero ?? 0;
        //        empresa.Conta = model.NumeroConta ?? 0;

        //        context.SaveChanges();

        //        return RedirectToAction("Index");
        //    }
        //}

        //public ActionResult Edit(Guid id)
        //{
        //    using (var context = new DatabaseContext())
        //    {
        //        var model = new EmpresaFormViewModel();
        //        model.Context = context;
        //        model.IdEmpresa = id;

        //        model.LoadDefaultValues();

        //        var empresa = context.Empresa.SingleOrDefault(x => x.IdEmpresa == id);

        //        if (empresa != null)
        //        {
        //            model.RazaoSocial = empresa.RazaoSocial;
        //            model.CodigoEmpresa = empresa.Codigo;
        //            model.Email = empresa.Email;
        //            model.CNPJ = empresa.CNPJ;
        //            model.IdResponsavel = empresa.IdResponsavel;
        //            model.Fator = empresa.Fator;
        //            model.CodigoAgencia = empresa.Agencia;
        //            model.NossoNumero = empresa.NossoNumero;
        //            model.NumeroConta = empresa.Conta;
        //        }

        //        return View("Form", model);
        //    }
        //}

        //[HttpPost]
        //public ActionResult Edit(EmpresaFormViewModel model)
        //{
        //    return Save(model);
        //}


        //public JsonResult Delete(Guid id)
        //{
        //    using (var context = new DatabaseContext())
        //    {
        //        var empresa = context.Empresa.Include("EmpresaHistoricoResponsavel").SingleOrDefault(x => x.IdEmpresa == id);

        //        if (empresa == null)
        //        {
        //            return Json(new { success = false, message = "Empresa não encontrada." }, JsonRequestBehavior.AllowGet);
        //        }

        //        if (empresa.Filial.Any(x => x.Audit_Excluido == (int)enumAuditExcluido.ACTIVE))
        //        {
        //            return Json(new { success = false, message = "Essa Empresa possui Filiais e não poderá ser excluída." }, JsonRequestBehavior.AllowGet);
        //        }

        //        empresa.Audit_Excluido = (int)enumAuditExcluido.INACTIVE;
        //        empresa.EmpresaHistoricoResponsavel.ToList().ForEach(empresa.DeleteHistory);
        //        empresa.EmpresaLogo.Audit_Excluido = (int)enumAuditExcluido.INACTIVE;

        //        context.SaveChanges();

        //        return Json(new { success = true, message = "" }, JsonRequestBehavior.AllowGet);
        //    }
        //}

    }
}

﻿using Business;
using System;
using System.Web.Mvc;

namespace MVC_GerenciadorDeConteudo.Controllers
{
    public class PaginasController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Paginas = new Pagina().Lista();
            return View();
        }
        public ActionResult Novo()
        {
            return View();
        }
        [HttpPost]
        public void Criar()
        {
            DateTime data;
            DateTime.TryParse(Request["data"], out data);
            var pagina = new Pagina();
            pagina.Nome = Request["nome"];
            pagina.Data = data;
            pagina.Conteudo = Request["conteudo"];
            pagina.Save();
            Response.Redirect("/paginas");
        }
        public ActionResult Editar(int id)
        {
            var pagina = Pagina.BuscarPorId(id);
            ViewBag.Pagina = pagina;
            return View();
        }

        [HttpPost]
        public void Alterar( int id)
        {
            try { 
            var pagina = Pagina.BuscarPorId(id);
            
            DateTime data;
            DateTime.TryParse(Request["data"], out data);
            
            pagina.Nome = Request["nome"];
            pagina.Data = data;
            pagina.Conteudo = Request["conteudo"];
            pagina.Save();

            TempData["sucesso"] = "Pagina Alterada com sucesso!";
            }
            catch
            {
                TempData["erro"] = "Pagina não pode ser alterada!";
            }
            Response.Redirect("/paginas");
        }
        public void Excluir(int id)
        {
            Pagina.Excluir(id);
            Response.Redirect("/paginas");
        }
    }
}
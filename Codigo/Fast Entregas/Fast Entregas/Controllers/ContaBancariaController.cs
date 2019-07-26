using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Services;

namespace FastEntregasWeb.Controllers
{
    public class ContaBancariaController : Controller
    {
        private readonly IGerenciadorConta gerenciadorConta;

        public ContaBancariaController(IGerenciadorConta _gerenciadorConta)
        {
            gerenciadorConta = _gerenciadorConta;
        }

        // GET: ContaBancaria
        public ActionResult Index()
        {
            return View(gerenciadorConta.ObterTodos());
        }

        // GET: ContaBancaria/Details/5
        public ActionResult Details(int codigo)
        {
            ContaBancaria conta = gerenciadorConta.Obter(codigo);
            return View(conta);
        }

        // GET: ContaBancaria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContaBancaria/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ContaBancaria conta)
        {
            if (ModelState.IsValid)
            {
                gerenciadorConta.Inserir(conta);
                return RedirectToAction(nameof(Index));
            }

            return View(conta);
        }

        // GET: ContaBancaria/Edit/5
        public ActionResult Edit(int codigo)
        {
            ContaBancaria conta = gerenciadorConta.Obter(codigo);
            return View(conta);
        }

        // POST: ContaBancaria/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int codigo, ContaBancaria conta)
        {
            if (ModelState.IsValid)
            {
                gerenciadorConta.Editar(conta);
                return RedirectToAction(nameof(Index));
            }

            return View(conta);
        }

        // GET: ContaBancaria/Delete/5
        public ActionResult Delete(int id)
        {
            ContaBancaria conta = gerenciadorConta.Obter(id);
            return View(conta);
        }

        // POST: ContaBancaria/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            gerenciadorConta.Remover(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
using System;
using System.Net;
using System.Web.Mvc;
using Agenda.Aplicacao.Interfaces;
using Agenda.Aplicacao.ViewModels;

namespace Agenda.UI.Mvc.Controllers
{
    public class ContatosController : Controller
    {
        private readonly IContatoAppServico _contatoAppServico;

        public ContatosController(IContatoAppServico contatoAppServico)
        {
            _contatoAppServico = contatoAppServico;
        }

        // GET: Contatos
        public ActionResult Index()
        {
            var contatoViewModel = _contatoAppServico.ObterTodos();

            return View(contatoViewModel);
        }

        // GET: Contatos/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var contatoViewModel = _contatoAppServico.ObterPorId(id.Value);

            if (contatoViewModel == null)
            {
                return HttpNotFound();
            }
            return View(contatoViewModel);
        }

        // GET: Contatos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contatos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ContatoEnderecoTelefoneEmailViewModel contatoEnderecoTelefoneEmailViewModel)
        {
            if (ModelState.IsValid)
            {
                _contatoAppServico.Adicionar(contatoEnderecoTelefoneEmailViewModel);

                return RedirectToAction("Index");
            }

            return View(contatoEnderecoTelefoneEmailViewModel);
        }

        // GET: Contatos/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var contatoViewModel = _contatoAppServico.ObterPorId(id.Value);
            if (contatoViewModel == null)
            {
                return HttpNotFound();
            }
            return View(contatoViewModel);
        }

        // POST: Contatos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ContatoViewModel contatoViewModel)
        {
            if (ModelState.IsValid)
            {
                _contatoAppServico.Atualizar(contatoViewModel);
                return RedirectToAction("Index");
            }
            return View(contatoViewModel);
        }

        // GET: Contatos/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var contatoViewModel = _contatoAppServico.ObterPorId(id.Value);
            if (contatoViewModel == null)
            {
                return HttpNotFound();
            }
            return View(contatoViewModel);
        }

        // POST: Contatos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _contatoAppServico.Excluir(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _contatoAppServico.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
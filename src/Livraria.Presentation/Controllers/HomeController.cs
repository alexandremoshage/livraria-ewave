using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Livraria.Presentation.Models;
using Livraria.Domain.Interfaces.Services;
using AutoMapper;
using Livraria.AppServices.ViewModel;
using Livraria.Domain.Entities;

namespace Livraria.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILivroService _livroService;
        private readonly IMapper _mapper;

        public HomeController(ILogger<HomeController> logger, ILivroService livroService, IMapper mapper)
        {
            _logger = logger;
            _livroService = livroService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var dados = _mapper.Map<IEnumerable<LivroViewModel>>(this._livroService.ObertTodos());

            return View(dados);
        }


        public IActionResult Buscar(string filtro)
        {
            IEnumerable < LivroViewModel > dados;
            if (filtro != null)
            {
                 dados = _mapper.Map<IEnumerable<LivroViewModel>>(this._livroService.FiltrarTitulo(filtro));
            }
            else
            {
                 dados = _mapper.Map<IEnumerable<LivroViewModel>>(this._livroService.ObertTodos());
            }

            return View("Index", dados);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(LivroViewModel viewModel)
        {
            var retorno = _mapper.Map<LivroViewModel>(_livroService.Save(_mapper.Map<Livro>(viewModel)));

            if (retorno.ListaErros.Count > 0)
            {
                foreach (var item in retorno.ListaErros)
                {
                    ModelState.AddModelError("Erro", item);
                }
                return View(retorno);
            }
            else
            {
                return RedirectToAction("Index");
            }

        }

        public IActionResult Details(int id)
        {
            var dados = _mapper.Map<LivroViewModel>(this._livroService.GetById(id));

            return View(dados);
        }

        public IActionResult Delete(int id)
        {
            var livro = _livroService.GetById(id);
            _livroService.Delete(livro);

            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

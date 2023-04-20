using System;
using System.Collections.Generic;
using Hsf_Receitas.Models;
using Hsf_Receitas.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Hsf_Receitas.Controllers
{
    public class ReceituarioController : Controller
    {
        private readonly ILogger<ReceituarioController> _logger;
        private List<Receituario> listaDeReceitas;

        public ReceituarioController(ILogger<ReceituarioController> logger)
        {
            _logger = logger;
            listaDeReceitas = new List<Receituario>();
        }

        public IActionResult Prescription()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Prescription(Receituario novaReceita, int id)
        {
           try 
           {
                ReceituarioServices recServ = new ReceituarioServices();
                recServ.AddReceita(novaReceita);

                id = novaReceita.Id;

                return Json(new { stats = "OK", id = id});

            }catch (Exception e)
            {
                _logger.LogError("Erro ao adicionar receita!" + e.Message);
                return Json(new { stats = "INVALID", message = "Falha ao cadastrar Receita!" });
            }

        }

        public IActionResult CompletePrescription (int id)
        {
            Receituario buscaReceita = new ReceituarioServices().SearchForId(id);
            return View(buscaReceita);
        }

        [HttpPost]
        public IActionResult CompletePrescription(Receituario editReceita)
        {
            try {

                new ReceituarioServices().EditReceita(editReceita);
                return RedirectToAction("Receituario", "Prescription");

            }catch (Exception e)
            {
                _logger.LogError("Erro ao completar o receituário !" + e.Message);
                return RedirectToAction("Index", "Home");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
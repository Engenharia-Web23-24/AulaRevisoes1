using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoRevisoes1.Data;
using ProjetoRevisoes1.Models;

namespace ProjetoRevisoes1.Controllers
{
    public class BolsasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BolsasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Bolsas
        public async Task<IActionResult> Lista()
        {
            return View(await _context.Bolsas.ToListAsync());
        }

        // GET: Bolsas/Details/5
        public async Task<string> Detalhes(int? id)
        {
            //if (id == null || _context.Bolsas == null)
            //{
            //    return NotFound();
            //}

            var bolsaInvestigacao = await _context.Bolsas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bolsaInvestigacao == null)
            {
                return "";
            }

            return "<td>" + bolsaInvestigacao.Remuneracao + "€ durante "
                + bolsaInvestigacao.Duracao + " meses</td>";
        }

        // GET: Bolsas/Create
        public IActionResult Adiciona()
        {
            return View();
        }

        // POST: Bolsas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Adiciona([Bind("Id,Titulo,Area,Duracao,Remuneracao")] BolsaInvestigacao bolsaInvestigacao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bolsaInvestigacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Lista));
            }
            return View(bolsaInvestigacao);
        }
    }
}

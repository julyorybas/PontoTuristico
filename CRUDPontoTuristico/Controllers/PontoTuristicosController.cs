using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CRUDPontoTuristico.Context;
using CRUDPontoTuristico.Models;

namespace CRUDPontoTuristico.Controllers
{
    public class PontoTuristicosController : Controller
    {
        private readonly Conexao _context;

        public PontoTuristicosController(Conexao context)
        {
            _context = context;
        }

        // GET: PontoTuristicos
        public async Task<IActionResult> Index()
        {
              return View(await _context.PontoTuristico.ToListAsync());
        }

        // GET: PontoTuristicos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PontoTuristico == null)
            {
                return NotFound();
            }

            var pontoTuristico = await _context.PontoTuristico
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pontoTuristico == null)
            {
                return NotFound();
            }

            return View(pontoTuristico);
        }

        // GET: PontoTuristicos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PontoTuristicos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,UF,Cidade,Referencia,Descricao")] PontoTuristico pontoTuristico)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pontoTuristico);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pontoTuristico);
        }

        // GET: PontoTuristicos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PontoTuristico == null)
            {
                return NotFound();
            }

            var pontoTuristico = await _context.PontoTuristico.FindAsync(id);
            if (pontoTuristico == null)
            {
                return NotFound();
            }
            return View(pontoTuristico);
        }

        // POST: PontoTuristicos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,UF,Cidade,Referencia,Descricao")] PontoTuristico pontoTuristico)
        {
            if (id != pontoTuristico.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pontoTuristico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PontoTuristicoExists(pontoTuristico.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(pontoTuristico);
        }

        // GET: PontoTuristicos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PontoTuristico == null)
            {
                return NotFound();
            }

            var pontoTuristico = await _context.PontoTuristico
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pontoTuristico == null)
            {
                return NotFound();
            }

            return View(pontoTuristico);
        }

        // POST: PontoTuristicos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PontoTuristico == null)
            {
                return Problem("Entity set 'Conexao.PontoTuristico'  is null.");
            }
            var pontoTuristico = await _context.PontoTuristico.FindAsync(id);
            if (pontoTuristico != null)
            {
                _context.PontoTuristico.Remove(pontoTuristico);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PontoTuristicoExists(int id)
        {
          return _context.PontoTuristico.Any(e => e.Id == id);
        }
    }
}

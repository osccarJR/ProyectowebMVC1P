using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TicketProyectoP1.Data;
using TicketProyectoP1.Models;

namespace TicketProyectoP1.Controllers
{
    public class ComentarioController : Controller
    {
        private readonly TicketProyectoP1Context _context;

        public ComentarioController(TicketProyectoP1Context context)
        {
            _context = context;
        }

        // GET: Comentario
        public async Task<IActionResult> Index()
        {
            var ticketProyectoP1Context = _context.Comentario.Include(c => c.Evento).Include(c => c.Usuario);
            return View(await ticketProyectoP1Context.ToListAsync());
        }

        // GET: Comentario/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comentario = await _context.Comentario
                .Include(c => c.Evento)
                .Include(c => c.Usuario)
                .FirstOrDefaultAsync(m => m.ComentarioId == id);
            if (comentario == null)
            {
                return NotFound();
            }

            return View(comentario);
        }

        // GET: Comentario/Create
        public IActionResult Create()
        {
            ViewData["EventoId"] = new SelectList(_context.Evento, "EventoId", "Nombre");
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "UsuarioId", "UsuarioId");
            return View();
        }

        // POST: Comentario/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ComentarioId,UsuarioId,EventoId,Texto,FechaComentario,Calificacion")] Comentario comentario)
        {
            {
                _context.Add(comentario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EventoId"] = new SelectList(_context.Evento, "EventoId", "Nombre", comentario.EventoId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "UsuarioId", "UsuarioId", comentario.UsuarioId);
            return View(comentario);
        }

        // GET: Comentario/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comentario = await _context.Comentario.FindAsync(id);
            if (comentario == null)
            {
                return NotFound();
            }
            ViewData["EventoId"] = new SelectList(_context.Evento, "EventoId", "Nombre", comentario.EventoId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "UsuarioId", "UsuarioId", comentario.UsuarioId);
            return View(comentario);
        }

        // POST: Comentario/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ComentarioId,UsuarioId,EventoId,Texto,FechaComentario,Calificacion")] Comentario comentario)
        {
            if (id != comentario.ComentarioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(comentario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComentarioExists(comentario.ComentarioId))
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
            ViewData["EventoId"] = new SelectList(_context.Evento, "EventoId", "Nombre", comentario.EventoId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "UsuarioId", "UsuarioId", comentario.UsuarioId);
            return View(comentario);
        }

        // GET: Comentario/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comentario = await _context.Comentario
                .Include(c => c.Evento)
                .Include(c => c.Usuario)
                .FirstOrDefaultAsync(m => m.ComentarioId == id);
            if (comentario == null)
            {
                return NotFound();
            }

            return View(comentario);
        }

        // POST: Comentario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var comentario = await _context.Comentario.FindAsync(id);
            if (comentario != null)
            {
                _context.Comentario.Remove(comentario);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ComentarioExists(int id)
        {
            return _context.Comentario.Any(e => e.ComentarioId == id);
        }
    }
}

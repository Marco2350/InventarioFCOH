using Microsoft.AspNetCore.Mvc;
using InventarioFCOH.Models;
using System.Linq;

namespace InventarioFCOH.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly DB20162000225Context _context;

        public CategoriaController(DB20162000225Context context)
        {
            _context = context;
        }

        public IActionResult ObtenerCategoria()
        {
            var categorias = _context.Categorias.ToList(); 
            return View(categorias);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoria = _context.Categorias
                .FirstOrDefault(m => m.CategoriaId == id);
            if (categoria == null)
            {
                return NotFound();
            }

            return View(categoria);
        }

        public IActionResult CrearCategoria()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("CategoriaId,Descripcion")] Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                _context.Add(categoria);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(categoria);
        }

        public IActionResult Editar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoria = _context.Categorias.Find(id);
            if (categoria == null)
            {
                return NotFound();
            }
            return View(categoria);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("CategoriaId,Descripcion")] Categoria categoria)
        {
            if (id != categoria.CategoriaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(categoria);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            return View(categoria);
        }
    }
}

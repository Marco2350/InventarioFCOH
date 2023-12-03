using InventarioFCOH.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace InventarioFCOH.Models.Controllers
{
	public class ReporteGeneralInventarioController : Controller
    {
        private readonly DB20162000225Context _context;

        public ReporteGeneralInventarioController(DB20162000225Context context)
        {
            _context = context;
        }
		public IActionResult ObtenerGeneralInventario(string equipoId, string categoria, string estado)
		{
			var categorias = _context.VwReporteGeneralInventarios
					.Select(x => x.Categoría)
					.Distinct()
					.ToList();

			var categoriasSelectList = new SelectList(categorias);

			ViewBag.Categorias = categoriasSelectList;
			var reporteGeneral = _context.VwReporteGeneralInventarios.AsQueryable();

			if (!string.IsNullOrEmpty(equipoId))
			{
				reporteGeneral = reporteGeneral.Where(x => x.IdEquipo == equipoId);
			}

			if (!string.IsNullOrEmpty(categoria))
			{
				reporteGeneral = reporteGeneral.Where(x => x.Categoría == categoria);
			}

			if (!string.IsNullOrEmpty(estado))
			{
				reporteGeneral = reporteGeneral.Where(x => x.Estado == estado);
			}

			return View(reporteGeneral.ToList());
		}

	}
}

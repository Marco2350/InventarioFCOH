using InventarioFCOH.Models;
using Microsoft.AspNetCore.Mvc;

namespace InventarioFCOH.Models.Controllers
{
	public class ReporteGeneralInventarioController : Controller
    {
        private readonly DB20162000225Context _context;

        public ReporteGeneralInventarioController(DB20162000225Context context)
        {
            _context = context;
        }
        public IActionResult ObtenerGeneralInventario()
        {
            var reporteGeneral = _context.VwReporteGeneralInventarios.ToList();
            return View(reporteGeneral);
        }
    }
}

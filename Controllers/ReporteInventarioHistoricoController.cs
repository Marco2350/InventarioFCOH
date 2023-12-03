using InventarioFCOH.Models;
using Microsoft.AspNetCore.Mvc;

namespace InventarioFCOH.Models.Controllers
{
	public class ReporteInventarioHistoricoController : Controller
    {
        private readonly DB20162000225Context _context;

        public ReporteInventarioHistoricoController(DB20162000225Context context)
        {
            _context = context;
        }
        public IActionResult ObtenerInventarioHistorico()
        {
            var reporteGeneral = _context.VwReporteInventarioHistoricos.ToList();
            return View(reporteGeneral);
        }
    }
}

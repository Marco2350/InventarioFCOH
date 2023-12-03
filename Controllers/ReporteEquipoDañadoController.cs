using InventarioFCOH.Models;
using Microsoft.AspNetCore.Mvc;

namespace InventarioFCOH.Models.Controllers
{
    public class ReporteEquipoDañadoController : Controller
    {
        private readonly DB20162000225Context _context;

        public ReporteEquipoDañadoController(DB20162000225Context context)
        {
            _context = context;
        }
        public IActionResult ObtenerReporteEquipoDañado()
        {
            var reporteEquipoDañado = _context.VwDamagedEquipmentReports.ToList();
            return View(reporteEquipoDañado);
        }
    }
}

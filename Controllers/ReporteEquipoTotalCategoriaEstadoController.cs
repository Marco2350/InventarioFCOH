using InventarioFCOH.Models;
using Microsoft.AspNetCore.Mvc;

namespace InventarioFCOH.Models.Controllers
{
    public class ReporteEquipoTotalCategoriaEstadoController : Controller
    {
        private readonly DB20162000225Context _context;

        public ReporteEquipoTotalCategoriaEstadoController(DB20162000225Context context)
        {
            _context = context;
        }
        public IActionResult ObtenerEquipoTotalCategoria()
        {
            var equipoTotalCategoria = _context.VwReporteEquipoTotalPorCategoriaEstados.ToList();   
            return View(equipoTotalCategoria);
        }


    }
}

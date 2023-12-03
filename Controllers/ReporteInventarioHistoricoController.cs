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
		public IActionResult ObtenerInventarioHistorico(int pageIndex = 1, int pageSize = 5)
		{
			var query = _context.VwReporteInventarioHistoricos.AsQueryable();
			var paginatedList = PaginatedList<VwReporteInventarioHistorico>.Create(query, pageIndex, pageSize);

			return View(paginatedList);
		}
	}
}

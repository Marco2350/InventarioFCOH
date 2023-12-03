using InventarioFCOH.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace InventarioFCOH.Models.Controllers
{
    public class HistoricoNivelUsuarioController : Controller
    {
        private readonly DB20162000225Context _context;

        public HistoricoNivelUsuarioController(DB20162000225Context context)
        {
            _context = context;
        }

        public IActionResult ObtenerHistoricoNivelUsuario(string nombreUsuario, int? equipoId)
        {
            var historicoNivelUsuario = _context.VwHistoricalReports.AsQueryable();

            if (!string.IsNullOrEmpty(nombreUsuario))
            {
                historicoNivelUsuario = historicoNivelUsuario
                    .Where(u => u.NombreUsuario.Contains(nombreUsuario));
            }

            if (equipoId.HasValue)
            {
                historicoNivelUsuario = historicoNivelUsuario
                    .Where(e => e.CodigoEquipo == equipoId.ToString());
            }

            var historicoNivelUsuarioList = historicoNivelUsuario.ToList();
            return View("ObtenerHistoricoNivelUsuario", historicoNivelUsuarioList);
        }
    }
}

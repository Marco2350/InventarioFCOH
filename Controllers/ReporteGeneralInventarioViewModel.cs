using Microsoft.AspNetCore.Mvc.Rendering;

namespace InventarioFCOH.Models.Controllers
{
	internal class ReporteGeneralInventarioViewModel
	{
		public SelectList Categorias { get; set; }
		public List<VwReporteGeneralInventario> ReporteGeneralInventario { get; set; }
	}
}
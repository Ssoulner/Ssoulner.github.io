using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace opa_site.Pages
{
	public class WieModel : PageModel
	{
		private readonly ILogger<WieModel> _logger;

		public WieModel(ILogger<WieModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{

		}
	}
}

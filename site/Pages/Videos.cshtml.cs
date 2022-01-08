using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace opa_site.Pages
{
	public class VideosModel : PageModel
	{
		private readonly ILogger<VideosModel> _logger;

		public List<string> videos = new List<string>() {
			"DIC and I love her",
			"DIC Brown sugar",
			"DIC Honky tonk women",
			"DIC Jumpig jack flash",
			"DIC Oerend hard",
			"DIC Ole time Rock & Roll",
			"DIC Watching the riverflow",
			"DIC Wonderfull tonight",
			"DIC You can't stop the music",
			"meppel (1)",
			"meppel (2)",
		};

		public VideosModel(ILogger<VideosModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{

		}
	}
}

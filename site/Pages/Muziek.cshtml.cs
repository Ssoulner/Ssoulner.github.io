using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace opa_site.Pages
{
	public class MuziekModel : PageModel
	{
		private readonly ILogger<MuziekModel> _logger;

		public List<string> eersteHelft = new List<string>() {
			"02 Die Is Cast - 02 days (live)",
			"Break the rules",
			"Days",
			"Everybody needs somebody to love",
			"Feelin allright",
			"For miss caulker",
			"Gloria",
			"Heartbreak hotel",
			"In my life",
		};
		public List<string> tweedeHelft = new List<string>() {
			"It'll be me",
			"Medley Red River Rock",
			"Mr Spaceman",
			"Roll over Beethoven",
			"San Francisco Bay",
			"What did say",
			"Whole lotta shaking",
			"Wonderful tonight",
			"You can't stop the music",
		};

		public MuziekModel(ILogger<MuziekModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{

		}
	}
}

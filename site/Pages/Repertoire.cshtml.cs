using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace opa_site.Pages
{
	public class RepertoireModel : PageModel
	{
		private readonly ILogger<RepertoireModel> _logger;

		public List<string> eersteHelft = new List<string>() {
			"After midnight",
			"All my loving",
			"And I love her",
			"Apache",
			"Back in the USSR",
			"Backstreet girl",
			"Bad moon rising",
			"Ballad of John and Yoko",
			"Big Mamou",
			"Blues before sunrise",
			"Blue suede shoes",
			"Break the rules",
			"Bring it on home to me",
			"Call me the breeze",
			"Cocaine",
			"Cry to me",
			"Danger",
			"Days",
			"Don’t stop",
			"Everybody needs somebody",
			"Every breath you take",
			"Feelin’ allright",
			"For miss Caulker",
			"Get off of my cloud",
			"Girl",
			"Gloria",
			"Great balls of fire",
			"Heartbreak Hotel",
			"Heart of stone",
			"Hey Jude",
			"Homeward bound",
			"Honky Tonk Women",
			"I’ll follow the sun",
			"In my life",
			"I saw her standing there",
			"I will",
			"Jailhouse rock",
			"Kansas City",
		};
		public List<string> tweedeHelft = new List<string>() {
			"Lady Jane",
			"Lady Madonna",
			"Lawdy miss Clawdy",
			"Learning to fly",
			"Mary Jane’s last dance",
			"Me and Bobby McGee",
			"Medley I (Red River Rock)",
			"Medley II (Bird Dog)",
			"Mister Pleasant",
			"Mister Spaceman",
			"Mister Tambourine Man",
			"Norwegian wood",
			"Nowhere man",
			"Oh! Pretty woman",
			"Old time Rock and Roll",
			"One night with you",
			"Only the lonely",
			"Only you",
			"Play with fire",
			"Rock ‘til you drop",
			"Route 66",
			"San Francisco Bay Blues",
			"Stir it up",
			"Summer in the city",
			"Sunny afternoon",
			"The last time",
			"Twist and shout",
			"Walk of life",
			"What’d I say?",
			"Whatever you want",
			"Whole lotta shaking going on",
			"Why worry?",
			"With a little help from my friends",
			"Wonderful tonight",
			"You can make it if you try",
			"You can’t stop the music",
			"You’ve got to hide your love away",
		};

		public RepertoireModel(ILogger<RepertoireModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{

		}
	}
}

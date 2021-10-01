using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TasksCalendar.Models;

namespace TasksCalendar.Controllers
{
	public class CalendarController : Controller
	{
		// GET
		public IActionResult Index() { return Calendar(); }

		[ HttpGet ]
		public IActionResult Calendar()
		{
			var model = new CalendarViewModel();

			return View( model );
		}

		[ HttpPost ]
		public IActionResult Calendar( HourViewModel hourViewModel )
		{
			var model = new CalendarViewModel();
			return Calendar();
		}
	}
}
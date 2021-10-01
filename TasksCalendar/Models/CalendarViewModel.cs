using System.Collections.Generic;
using TasksCalendar.Enums;

namespace TasksCalendar.Models
{
	public class CalendarViewModel
	{
		public Dictionary<DayOfWeek, HourViewModel[]> Map { get; } = new();

		public CalendarViewModel()
		{
			for ( var i = DayOfWeek.Понедельник; i < DayOfWeek.Воскресение; i++ )
			{
				var hours = new HourViewModel[24];

				for ( var j = 0; j < hours.Length; j++ ) hours[j] = new(j);

				Map[i] = hours;
			}
		}
	}
}
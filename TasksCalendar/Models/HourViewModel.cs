using TasksCalendar.Enums;

namespace TasksCalendar.Models
{
	public class HourViewModel
	{
		public HourViewModel(int value)
		{
			Value = value;
		}
		public int            Value  { get; }
		public string         Task   { get; }
		public CompleteStatus Status { get; set; }

		public override string ToString() => Task;
	}

}
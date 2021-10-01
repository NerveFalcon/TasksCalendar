using System.Collections.Generic;

namespace TasksCalendar.Enums
{
	public static class Extend
	{
		public static IEnumerable<CompleteStatus> ForEach( this CompleteStatus completeStatus )
		{
			for (var  i = CompleteStatus.ToDo; i < CompleteStatus.Done; i++ )
			{
				yield return i;
			}
		}
	}
}
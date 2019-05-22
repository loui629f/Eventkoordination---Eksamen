using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer;

namespace ApplicationLayer
{
    public class EventRepository
    {
		public List<Event> Events { get; private set; } = new List<Event>();
        
	
        
		public void Add(Event newEvent)
		{
			Events.Add(newEvent);
		}
		public int GetCount() => Events.Count;
		public string GetEventName(string date)
		{
			foreach (Event item in Events)
			{
				if (item.EventDate.ToString() == date)
				{
					return item.EventName;
				}
				
			}
			return null;
		}
		public string GetEventDescription(string date)
		{
			foreach (Event item in Events)
			{
				if (item.EventDate.ToString() == date)
				{
					return item.EventDescription;
				}
			}
			return null;
		}






		public List<string> GetDate()
		{

			List<string> DateOfEvents = new List<string>();
			foreach (Event events in Events)
			{
				DateOfEvents.Add(events.EventDate.ToString());
			}
			return DateOfEvents;
		}

	}
}

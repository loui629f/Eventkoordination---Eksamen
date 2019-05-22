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
